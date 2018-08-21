using Atlassian.Jira;
using IssueTimeTracker.Classes;
using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Classes.Helper;
using IssueTimeTracker.Classes.Messenger;
using IssueTimeTracker.Forms;
using IssueTimeTracker.Forms.Basic_Forms;
using IssueTimeTracker.Forms.Basic_Forms.ColorPicker;
using IssueTimeTracker.Forms.Data;
using IssueTimeTracker.Forms.Jira;
using IssueTimeTracker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker
{
    public partial class ThemedMain : Form
    {
        public ThemedMain()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            DoubleBuffered = true;

            CurrentTheme = Setting.Value.CurrentTheme;

            SetGlobalTimer();
            SetTaskTimer();

            this.Location = Setting.Value.Timer_StartLocation;
            if (!IsOnScreen(this))
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + 400, Screen.PrimaryScreen.WorkingArea.Y + 100);
            this.TopMost = true;
            UpdateNewSettings();
            StaticHandler._ThemedMain = this;

            // Setup recent issues combo box
            IssueNumberCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RecentIssuesAutoCompleteSource.AddRange(TaskTracker.GetAllIssues().ToArray());
            IssueNumberCombo.AutoCompleteCustomSource = RecentIssuesAutoCompleteSource;
            IssueNumberCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;


            if (Setting.Value.General_Position != 0)
                jiraBrowserToolStripMenuItem.Visible = false;
            //RegisterHotkey(Setting.Value.Timer_QuickUse);
            if (AdminControl.Control.View_Mode == AdminControl.ViewMode.Advanced)
                adminToolStripMenuItem.Visible = true;
        }

        #region Variables

        public Theme CurrentTheme { get { return _currentTheme; } set
            {
                _currentTheme = value;
                _currentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(TextBox), typeof(CircularProgressBar.CircularProgressBar), typeof(ComboBox), typeof(CheckBox) }, TopMenu);
                IconI.Image = Theme.RecolorImage(new Bitmap(IconI.Image), _currentTheme.Foreground);
                SetGlobalTimer();
                SetTaskTimer();
            }
        }
        private Theme _currentTheme;

        //

        public Jira _Jira { get { return jira; } set { jira = value; MainData.Instance.ApproxLoginCount++; MainData.Export(); } }
        private Jira jira;
        public SecureString JiraPassword;
        public MasterClock MainWatch = new MasterClock();

        //

        NewSettings newSettings;
        LogBrowser logBrowser = new LogBrowser();
        public JiraLogin jiraLogin = new JiraLogin();
        public JiraIssueBrowser jiraTicket;

        FormAnimator.AnimationDirection[] Directions = { FormAnimator.AnimationDirection.Up, FormAnimator.AnimationDirection.Down, FormAnimator.AnimationDirection.Left, FormAnimator.AnimationDirection.Right };

        //Stopwatch MainWatch = new Stopwatch();
        Stopwatch TaskWatch = new Stopwatch();

        TimerHelper GlobalTimerHelper = new TimerHelper();
        TimerHelper TaskTimerHelper = new TimerHelper();

        float CurrentTask = 0.0f;
        float Leftover = 0.0f;
        float LeftoverTransfer = 0.0f;
        float Quarters = 0.0f;
        string previousTaskLabel = "0.00";

        bool FirstStart = true;

        AutoCompleteStringCollection RecentIssuesAutoCompleteSource = new AutoCompleteStringCollection();

        MessageWatcher messageWatcher = new Classes.MessageWatcher();

        Advanced advanced;

        bool dontUpdate = false;

        private DateTime JiraLastChecked;
        public NotifyIcon trayIcon;
        public JiraCheckingState jiraCheckingState
        {
            get { return _jiraCheckingState; }
            set
            {
                if (value != _jiraCheckingState)
                {
                    UpdateSystemTrayIcon(value == JiraCheckingState.Checking);
                    _jiraCheckingState = value;
                }
            }
        }
        private JiraCheckingState _jiraCheckingState = JiraCheckingState.Disabled;

        #endregion

        #region Timer

        public void UpdateNewSettings()
        {
            CurrentTheme = Setting.Value.CurrentTheme;
            SetGlobalTimer();
            SetTaskTimer();

            this.Opacity = Convert.ToDouble(Setting.Value.Timer_Opacity);
            if (Setting.Value.Notification_Frequency == 0)
                LACounty.Enabled = false;
            else
                LACounty.Enabled = true;
            if (Setting.Value.Notification_Frequency != 0 && Setting.Value.Notification_Frequency * 60000 != LACounty.Interval)
                LACounty.Interval = Setting.Value.Notification_Frequency * 60000;

            jiraBrowserToolStripMenuItem.Visible = Setting.Value.General_JiraAccess;
            jiraDataToolStripMenuItem.Visible = Setting.Value.General_JiraAccess;

            APSCheckbox.Visible = Setting.Value.General_APSUtlizer;

            if (Setting.Value.General_JiraAccess && Setting.Value.Jira_AutoCheck && !JiraChecker.Enabled && StaticHandler.JiraFailCount < 5)
            {
                if (Program.CheckForInternetConnection())
                {
                    if (_Jira == null)
                    {
                        jiraLogin.Show();
                    }
                    //JiraChecker.Enabled = true;
                }
            }
            else if (!Setting.Value.Jira_AutoCheck && JiraChecker.Enabled)
            {
                _Jira = null;
                JiraChecker.Enabled = false;
            }
            //UpdateSystemTrayIcon(JiraChecker.Enabled);
            if (!Program.CheckForInternetConnection())
                jiraCheckingState = JiraCheckingState.LostInternet;
            else if (JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Checking;
            else
                jiraCheckingState = JiraCheckingState.Disabled;

            notesToolStripMenuItem.Visible = Setting.Value.Timer_Notes;
            /*Technical Support
            Account Manager
            Implementation Engineer
            Business Analyst
            Other*/
            switch (Setting.Value.General_Position)
            {
                case Position.TechnicalSupport:
                    TaskLabel.Text = "Issue #:";
                    break;
                case Position.AccountManager:
                    TaskLabel.Text = "Task:";
                    break;
                case Position.ImplementationEngineer:
                    TaskLabel.Text = "Issue #:";
                    break;
                case Position.BusinessAnalyst:
                    TaskLabel.Text = "Task:";
                    break;
                case Position.Other:
                    TaskLabel.Text = "Task:";
                    break;
                default:
                    TaskLabel.Text = "Issue #:";
                    break;
            }

            UpdateRecentIssues();
        }

        /// <summary>
        /// This needs CPU optimization and is currently being worked on
        /// </summary>
        private void Global_Timer_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (MainWatch.IsRunning)
                SetGlobalTimer();
            if (TaskWatch.IsRunning)
                SetTaskTimer();
            CalculateCurrentTaskLabel();
            this.ResumeLayout();

            JiraCheckerCorrector();
        }



        private void SetGlobalTimer()
        {
            GlobalTimerHelper.Milliseconds = MainWatch.Elapsed.Milliseconds;
            GlobalTimerHelper.Seconds = MainWatch.Elapsed.Seconds;
            GlobalTimerHelper.Minutes = MainWatch.Elapsed.Minutes;
            GlobalTimerHelper.Hours = MainWatch.Elapsed.Hours;

            if (GlobalTimerHelper.MillisecondChanged)
            {
                Global_Millisecond.Text = (GlobalTimerHelper.Milliseconds / 10 < 10 ? "0" : "") + (GlobalTimerHelper.Milliseconds / 10).ToString();
                if (MainWatch.Elapsed.TotalMilliseconds >= 1)
                    Global_Millisecond.ForeColor = CurrentTheme.Foreground;
            }

            if (MainWatch.Elapsed.TotalMilliseconds == 0)
                Global_Millisecond.ForeColor = CurrentTheme.OtherForeground;

            if (GlobalTimerHelper.SecondChanged)
            {
                Global_Second.Text = (GlobalTimerHelper.Seconds < 10 ? "0" : "") + (GlobalTimerHelper.Seconds).ToString();
                if (MainWatch.Elapsed.TotalSeconds >= 1)
                {
                    Global_Second.ForeColor = CurrentTheme.Foreground;
                    Global_SecondPeriod.ForeColor = CurrentTheme.Foreground;
                }
            }

            if (MainWatch.Elapsed.TotalSeconds == 0)
            {
                Global_Second.ForeColor = CurrentTheme.OtherForeground;
                Global_SecondPeriod.ForeColor = CurrentTheme.OtherForeground;
            }

            if (GlobalTimerHelper.MinuteChanged)
            {
                Global_Minute.Text = (GlobalTimerHelper.Minutes < 10 ? "0" : "") + (GlobalTimerHelper.Minutes).ToString();
                if (MainWatch.Elapsed.TotalMinutes >= 1)
                {
                    Global_Minute.ForeColor = CurrentTheme.Foreground;
                    Global_MinuteColon.ForeColor = CurrentTheme.Foreground;
                }
            }

            if (MainWatch.Elapsed.TotalMinutes == 0)
            {
                Global_Minute.ForeColor = CurrentTheme.OtherForeground;
                Global_MinuteColon.ForeColor = CurrentTheme.OtherForeground;
            }

            if (GlobalTimerHelper.HourChanged)
            {

                Global_Hour.Text = (GlobalTimerHelper.Hours < 10 ? "0" : "") + (GlobalTimerHelper.Hours).ToString();
                if (MainWatch.Elapsed.TotalHours >= 1)
                {
                    Global_Hour.ForeColor = CurrentTheme.Foreground;
                    Global_HourColon.ForeColor = CurrentTheme.Foreground;
                }
            }

            if (MainWatch.Elapsed.TotalHours == 0)
            {
                Global_Hour.ForeColor = CurrentTheme.OtherForeground;
                Global_HourColon.ForeColor = CurrentTheme.OtherForeground;
            }
        }

        private void SetTaskTimer()
        {
            Task_Millisecond.Text = (TaskWatch.Elapsed.Milliseconds / 10 < 10 ? "0" : "") + (TaskWatch.Elapsed.Milliseconds / 10).ToString();
            if (TaskWatch.Elapsed.TotalMilliseconds >= 1)
                Task_Millisecond.ForeColor = CurrentTheme.Foreground;
            else
                Task_Millisecond.ForeColor = CurrentTheme.OtherForeground;

            Task_Second.Text = (TaskWatch.Elapsed.Seconds < 10 ? "0" : "") + (TaskWatch.Elapsed.Seconds).ToString();
            if (TaskWatch.Elapsed.TotalSeconds >= 1)
            {
                Task_Second.ForeColor = CurrentTheme.Foreground;
                Task_SecondPeriod.ForeColor = CurrentTheme.Foreground;
            }
            else
            {
                Task_Second.ForeColor = CurrentTheme.OtherForeground;
                Task_SecondPeriod.ForeColor = CurrentTheme.OtherForeground;
            }

            Task_Minute.Text = (TaskWatch.Elapsed.Minutes < 10 ? "0" : "") + (TaskWatch.Elapsed.Minutes).ToString();
            if (TaskWatch.Elapsed.TotalMinutes >= 1)
            {
                Task_Minute.ForeColor = CurrentTheme.Foreground;
                Task_MinuteColon.ForeColor = CurrentTheme.Foreground;
            }
            else
            {
                Task_Minute.ForeColor = CurrentTheme.OtherForeground;
                Task_MinuteColon.ForeColor = CurrentTheme.OtherForeground;
            }


            Task_Hour.Text = (TaskWatch.Elapsed.Hours < 10 ? "0" : "") + (TaskWatch.Elapsed.Hours).ToString();
            if (TaskWatch.Elapsed.TotalHours >= 1)
            {
                Task_Hour.ForeColor = CurrentTheme.Foreground;
                Task_HourColon.ForeColor = CurrentTheme.Foreground;
            }
            else
            {
                Task_Hour.ForeColor = CurrentTheme.OtherForeground;
                Task_HourColon.ForeColor = CurrentTheme.OtherForeground;
            }
        }

        private float extraTaskTime = 0.0f;

        public void AddExtraTaskTime(float time)
        {
            float taskTime = (float)(Math.Ceiling((TaskWatch.Elapsed.TotalMinutes - Setting.Value.Timer_RoundUpMinutes) / 15) * .25) + (LeftoverTransfer >= 0.25f ? LeftoverTransfer : 0);
            extraTaskTime += time;
            if (taskTime + extraTaskTime < 0.0f)
                extraTaskTime = -taskTime;
            CalculateCurrentTaskLabel();
            for (int i = UseComboBox.Items.Count - 1; i >= 0; i--)
            {
                if (float.Parse(UseComboBox.Items[i].ToString()) > taskTime + extraTaskTime)
                {
                    UseComboBox.Items.RemoveAt(i);
                    UseComboBox.SelectedIndex = i - 1;
                    if (UseComboBox.Items.Count == 0)
                    {
                        UseComboBox.Items.Clear();
                        UseComboBox.ResetText();
                        UseComboBox.Text = "Use";
                    }
                }
            }
        }

        private void CalculateCurrentTaskLabel()
        {
            LeftoverLabel.Text = Leftover.ToString();

            string newTaskLabel = "0.00";
            float taskTime = (float)(Math.Ceiling((TaskWatch.Elapsed.TotalMinutes - Setting.Value.Timer_RoundUpMinutes) / 15) * .25) + (LeftoverTransfer >= 0.25f ? LeftoverTransfer : 0);

            taskTime += extraTaskTime;

            if (CurrentTask != taskTime)
                CurrentTask = taskTime;

            newTaskLabel = taskTime.ToString();

            if (newTaskLabel != previousTaskLabel)
            {
                CurrentTaskLabel.Text = newTaskLabel;
                previousTaskLabel = newTaskLabel;
            }
        }

        private void StartPauseButton_Click(object sender, EventArgs e)
        {
            ToggleTimer();
            StopButton.Enabled = true;
            endToolStripMenuItem.Enabled = true;
        }

        private void ToggleTimer()
        {
            if (!TaskWatch.IsRunning)
            {
                startToolStripMenuItem.Text = "Pause Task";
                StartPauseButton.Text = ";";
                StartPauseButton.Font = new Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
                if (!MainWatch.IsRunning)
                    MainWatch.Start();
                TaskWatch.Start();
                AddQuarterProgress(0.0f);

                if (FirstStart)
                {
                    TaskTracker.StartNewDay();
                    TaskTracker.StartNewTask();
                    FirstStart = false;
                    if (TaskTracker.GetCurrentDay.TotalUsedTime != null)
                    {
                        AddQuarterProgress(float.Parse(TaskTracker.GetCurrentDay.TotalUsedTime));
                        try
                        {
                            MainWatch.Offset = TimeSpan.ParseExact(TaskTracker.GetCurrentDay.TotalTime, "hh\\:mm\\:ss\\.ff", CultureInfo.InvariantCulture);
                        }
                        catch { }
                    }
                }
                else
                {
                    if (TaskTracker.isCurrentTaskNull)
                        TaskTracker.StartNewTask();
                }
            }
            else
            {
                startToolStripMenuItem.Text = "Resume Task";
                StartPauseButton.Text = "w";
                StartPauseButton.Font = new Font("Wingdings 3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
                //MainWatch.Stop();
                TaskWatch.Stop();
            }
        }

        #endregion

        #region LACounty

        private void LACounty_Tick(object sender, EventArgs e)
        {
            LACountyNotification();
        }

        bool lostInternet = false;

        private void JiraChecker_Tick(object sender, EventArgs e)
        {
            if (_Jira == null || StaticHandler.JiraFailCount > 5)
            {
                jiraCheckingState = JiraCheckingState.Unknown;
                return;
            }

            bool internet = Program.CheckForInternetConnection();

            if (!internet && !lostInternet)
            {
                lostInternet = true;
                ToastNotification("Lost Connection", "You've lost internet connection. Jira will not be checked in the meantime", 30, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction]);
                jiraBrowserToolStripMenuItem.Enabled = false;
                jiraCheckingState = JiraCheckingState.LostInternet;
                return;
            }
            else if (!internet && lostInternet)
                return;
            else if (internet && lostInternet)
            {
                lostInternet = false;
                ToastNotification("Connection Established", "Jira checking will resume", 5, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction]);
                jiraBrowserToolStripMenuItem.Enabled = true;
                jiraCheckingState = JiraCheckingState.Checking;
            }
            if (StaticHandler.JiraFailCount == 5)
            {
                StaticHandler.JiraFailCount++;
                ToastNotification("Jira Failed", "Jira failed at getting LAC issues too many times. Log in again from settings", 5, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction]);
                jiraBrowserToolStripMenuItem.Enabled = false;
                jiraCheckingState = JiraCheckingState.FailedLogin;
                return;
            }

            JiraCheck();
        }

        bool relogin = false;

        async void JiraCheck(bool loop = false)
        {
            if (relogin && StaticHandler.JiraFailCount > 3 && Setting.Value.Jira_Username != "" && Setting.Value.Jira_Username != "!" && JiraPassword != null)
            {
                _Jira = Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(JiraPassword), new JiraRestClientSettings() { EnableRequestTrace = true });
                relogin = false;
                jiraBrowserToolStripMenuItem.Enabled = true;
            }
            _Jira.Issues.MaxIssuesPerRequest = 5;
            try
            {
                IEnumerable<Issue> jiraIssues = await _Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND assignee is empty");
                jiraBrowserToolStripMenuItem.Enabled = true;
                foreach (var issue in jiraIssues)
                {
                    if (issue.Project.Equals("LAC") && (issue.Assignee == null || issue.Assignee == ""))
                        LACountyNotification("\n" + issue.Key.Value + " - " + GetTimeLeft(issue.Created.Value, 15).ToString() + " minutes left\n" + issue.Summary, issue.Key.Value);
                }
                JiraLastChecked = DateTime.Now;
                jiraCheckingState = JiraCheckingState.Checking;
            }
            catch
            {
                jiraBrowserToolStripMenuItem.Enabled = false;
                jiraCheckingState = JiraCheckingState.FailedLogin;
                if (StaticHandler.JiraFailCount > 0 && Setting.Value.Jira_Username != "" && Setting.Value.Jira_Username != "!" && JiraPassword != null)
                {
                    _Jira = Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(JiraPassword), new JiraRestClientSettings() { EnableRequestTrace = true });
                }
                if (!loop)
                    JiraCheck(true);
                else
                {
                    StaticHandler.JiraFailCount++;
                    jiraCheckingState = JiraCheckingState.FailedLogin;

                }
            }
        }

        private int GetTimeLeft(DateTime time, int minutes)
        {
            return (int)(minutes - (DateTime.Now - time).TotalMinutes);
        }

        private async void LACountyNotification(string _jira = "", string laissue = "")
        {
            int duration = -1;

            if (_jira != "")
                duration = 30;
            else
                duration = Setting.Value.Notification_Frequency * 60;

            var animationMethod = FormAnimator.AnimationMethod.Slide;

            var animationDirection = Directions[Setting.Value.Notification_Direction];
            string jira = "";
            if (_jira == "" && StaticHandler.JiraFailCount < 5 && Setting.Value.Jira_AutoCheck && _Jira != null)
            {

                try
                {
                    IEnumerable<Issue> jiraIssues = await _Jira.Issues.GetIssuesFromJqlAsync("Project = LAC AND assignee = ''");
                    foreach (var issue in jiraIssues)
                    {
                        if (issue.Project.Equals("LAC") && (issue.Assignee == null || issue.Assignee == ""))
                        {
                            jira += "\n" + issue.Key.Value + " - " + GetTimeLeft(issue.Created.Value, 15).ToString() + " minutes left\n" + issue.Summary;
                            laissue = issue.Key.Value;
                        }
                    }
                }
                catch { StaticHandler.JiraFailCount++; }
            }
            else
                jira = _jira;

            ToastNotification("LA County Issues", (jira != "" ? "New Jira Issue" + jira : (Setting.Value.Jira_AutoCheck ? "No new issues found\n" : "Jira Auto Check is Off\nCheck LA County for issues")), duration, animationMethod, animationDirection, laissue);
        }

        public static void ToastNotification(string header, string body, int duration = -1, FormAnimator.AnimationMethod method = FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection direction = FormAnimator.AnimationDirection.Up, string issue = "")
        {
            if (Setting.Value.Notification_WindowsNotification)
            {
                if (StaticHandler._ThemedMain.trayIcon == null)
                {
                    StaticHandler._ThemedMain.trayIcon = new NotifyIcon()
                    {
                        Icon = Resources.closed,
                        Visible = true
                    };
                }
                StaticHandler._ThemedMain.TempIssue = issue;
                StaticHandler._ThemedMain.trayIcon.BalloonTipTitle = header;
                StaticHandler._ThemedMain.trayIcon.BalloonTipText = body;
                StaticHandler._ThemedMain.trayIcon.BalloonTipClicked += new EventHandler(StaticHandler._ThemedMain.BalloonTipClick);
                StaticHandler._ThemedMain.trayIcon.ShowBalloonTip(duration);
            }
            else
            {
                var toastNotification = new Notification(header, body, duration, method, direction, -1, issue);
                PlayNotificationSound(Setting.Value.Notification_Sound);
                toastNotification.Show();
            }
        }

        public string TempIssue = "";

        public async void BalloonTipClick(object sender, EventArgs e)
        {
            if (TempIssue != null && TempIssue != "" && Setting.Value.Jira_Mode != Classes.JiraMode.Nothing)
            {
                if (Setting.Value.Jira_Mode == Classes.JiraMode.InApplication)
                {
                    jiraTicket = new JiraIssueBrowser();
                    jiraTicket.Show();
                    await jiraTicket.NavigateToIssueByKey(TempIssue);
                    jiraTicket.AddPremadeResponse();
                }
                else if (Setting.Value.Jira_Mode == Classes.JiraMode.WebBrowser)
                {
                    Process.Start(Setting.Value.Jira_Link + @"projects/LAC/queues/custom/7/" + TempIssue);
                }
            }
            TempIssue = "";
        }

        public static void PlayNotificationSound(string sound)
        {
            var soundsFolder = Path.Combine(Program.DataPath, "Sounds");
            var soundFile = Path.Combine(soundsFolder, sound + ".wav");

            try
            {
                using (var player = new System.Media.SoundPlayer(soundFile))
                {
                    player.Play();
                }
            }
            catch { }
        }

        #endregion

        #region Timer Functions

        public void QuickUse()
        {
            if (IssueNumber.Visible)
                IssueNumber.Text = Clipboard.GetText();
            else
                IssueNumberCombo.Text = Clipboard.GetText();
            UseTime();
            IssueNumber.Text = "";
            IssueNumberCombo.Text = "";
        }

        public void ClearRecentIssues()
        {
            IssueNumberCombo.Visible = false;
            IssueNumber.Visible = true;
        }

        private void AddQuarterProgress(float i)
        {
            Quarters += i;
            int total = (int)Math.Round((double)(Quarters * 12.5));
            DayProgress.Value = ((total <= 100) ? total : 100);
            DayProgress.Text = Quarters.ToString();
        }

        private void UseTime()
        {
            string IssueText = "";
            if (IssueNumber.Visible)
                IssueText = IssueNumber.Text.Trim();
            else
                IssueText = IssueNumberCombo.Text.Trim();
            if (IssueText == "")
            {
                MessageBox.Show("You need to fill out an issue number");
                return;
            }

            if (TaskTracker.isCurrentTaskNull)
                TaskTracker.StartNewTask();

            if (UseComboBox.Items.Count <= 0)
                return;
            LeftoverTransfer = 0.0f;

            string sendTime = UseComboBox.SelectedItem.ToString();
            if (sendTime.StartsWith("."))
                sendTime = "0" + sendTime;
            float useAmount = float.Parse(sendTime);

            float leftover = CurrentTask - useAmount;
            if (leftover >= 0.25f)
                Leftover += leftover;

            if (Leftover > 0f)
                MoveLeftOverButton.Enabled = true;
            else
                MoveLeftOverButton.Enabled = false;

            LastTaskLabel.Text = sendTime;
            AddQuarterProgress(useAmount);
            TaskTracker.EndCurrentTask(IssueText, Task_Hour.Text + ":" + Task_Minute.Text + ":" + Task_Second.Text + "." + Task_Millisecond.Text, DateTime.Now.ToLongTimeString(), sendTime, APSCheckbox.Checked);

            APSCheckbox.Checked = false;

            RecentIssuesAutoCompleteSource.Add(IssueText);

            UpdateRecentIssues();
            IssueNumber.Text = "";
            IssueNumberCombo.Text = "";

            extraTaskTime = 0.0f;
            UseComboBox.Items.Clear();
            UseComboBox.ResetText();
            UseComboBox.Text = "Use";
            UseComboBox.SelectedIndex = -1;
            if (TaskWatch.IsRunning)
            {
                TaskWatch.Restart();
                TaskTracker.StartNewTask();
            }
            else
                TaskWatch.Reset();

            SetGlobalTimer();
            SetTaskTimer();
            CalculateCurrentTaskLabel();
        }

        private void EndDay()
        {
            DialogResult d = MessageBox.Show("Are you sure you want to end the day?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                TaskTracker.NullCurrentTask();
                TaskTracker.EndCurrentDay();

                if (MainWatch.IsRunning)
                    StartPauseButton_Click(null, null);
                MainWatch.Reset();
                TaskWatch.Reset();

                CurrentTask = 0.0f;
                Leftover = 0.0f;
                LeftoverTransfer = 0.0f;
                Quarters = 0.0f;
                extraTaskTime = 0.0f;
                previousTaskLabel = "0.00";
                LastTaskLabel.Text = "0.00";
                UseComboBox.Items.Clear();
                AddQuarterProgress(0.0f);
                FirstStart = true;
                StopButton.Enabled = false;
                StartPauseButton.Text = "w";
                StartPauseButton.Font = new Font("Wingdings 3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
                SetGlobalTimer();
                SetTaskTimer();
                CalculateCurrentTaskLabel();
            }
        }

        public void UpdateRecentIssues()
        {
            if (Setting.Value.Timer_MaxRecentIssues == 0)
                ClearRecentIssues();
            else
            {
                IssueNumberCombo.Visible = true;
                IssueNumber.Visible = false;
                IssueNumberCombo.Items.Clear();
                IssueNumberCombo.Items.AddRange(TaskTracker.GetLatestIssuesNumbers(Setting.Value.Timer_MaxRecentIssues).ToArray());
            }
        }

        #endregion

        #region Functions

        public bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Rectangle formRectangle = new Rectangle(form.Left, form.Top,
                                                         form.Width, form.Height);

                if (screen.WorkingArea.Contains(formRectangle))
                {
                    return true;
                }
            }

            return false;
        }

        public async void TestNotif()
        {
            try
            {
                IEnumerable<Issue> jiraIssues = await _Jira.Issues.GetIssuesFromJqlAsync("Project=LAC");
                string laissue = "";
                string jira = "";
                foreach (var issue in jiraIssues)
                {
                    if (issue.Project.Equals("LAC"))
                    {
                        jira += "\n" + issue.Key.Value + " - " + GetTimeLeft(issue.Created.Value, 15).ToString() + " minutes left\n" + issue.Summary;
                        laissue = issue.Key.Value;
                        break;
                    }
                }

                int duration = 30;

                var animationMethod = FormAnimator.AnimationMethod.Slide;

                var animationDirection = Directions[Setting.Value.Notification_Direction];
                ToastNotification("LA County Issues", "New Jira Issue" + jira, duration, animationMethod, animationDirection, laissue);

            }
            catch
            {
            }
        }

        private void CheckForUpdate()
        {
            if (dontUpdate)
                return;
            WebClient wc = new WebClient();
            if (!Program.CheckForInternetConnection())
            {
                return;
            }
            string version = Program.getLatestVersion(wc);
            if ((File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")) &&
                Program.isNewer(Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version, version)) ||
                Program.isNewer(FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion, Program.getLatestVersion(wc)))
            {
                if (MessageBox.Show("An update is available, would you like to update now?\n\nNote: As of 1.6, your total time will load if the application is restarted. Just make sure to enter the last task because that will be lost.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (File.Exists(Path.Combine(Program.DataPath, "NewVersion.xml")))
                    {
                        File.Delete(Path.Combine(Program.DataPath, "NewVersion.xml"));
                    }
                    if (File.Exists(Path.Combine(Program.DataPath, "NewVersion.json")))
                    {
                        File.Delete(Path.Combine(Program.DataPath, "NewVersion.json"));
                    }
                    string updater = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker\\IssueTimeTrackerUpdater.exe";
                    if (File.Exists(updater))
                        File.Delete(updater);
                    wc.DownloadFile(MainData.Instance.Domain + "IssueTimeTracker/IssueTimeTrackerUpdater.exe", updater);
                    if (File.Exists(updater))
                        Process.Start(updater);
                }
                else
                    dontUpdate = true;
            }
        }

        #endregion

        #region Events

        private void CurrentTaskLabel_TextChanged(object sender, EventArgs e)
        {
            bool pass = true;
            foreach (string s in UseComboBox.Items)
                if (s == CurrentTaskLabel.Text)
                    pass = false;

            if (pass && float.Parse(CurrentTaskLabel.Text) != 0.00f)
            {
                UseComboBox.Items.Add(CurrentTaskLabel.Text);
                if (UseComboBox.SelectedIndex + 1 < UseComboBox.Items.Count)
                    UseComboBox.SelectedIndex++;
                else
                    UseComboBox.SelectedIndex = UseComboBox.Items.Count - 1;
                UseComboBox.Enabled = true;
            }
        }

        private void IssueNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UseTime();
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                if (UseComboBox.SelectedIndex > 0)
                    UseComboBox.SelectedIndex--;
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                if (UseComboBox.SelectedIndex < UseComboBox.Items.Count - 1)
                    UseComboBox.SelectedIndex++;
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            UseTime();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Leftover >= 0.25f)
            {
                LeftoverTransfer += 0.25f;
                Leftover -= 0.25f;
            }
            if (Leftover == 0f)
                MoveLeftOverButton.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EndDay();
        }

        private void LastTaskLabel_Click(object sender, EventArgs e)
        {
            LastTaskLabel.Text = "0.00";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Removed because it should just auto-end day. If the user restarts the program, it will continue anyways
            /*if (StaticHandler.MainWatch.IsRunning || StaticHandler.MainWatch.ElapsedMilliseconds > 0 || !TaskTracker.isCurrentTaskNull)
            {
                if (e.CloseReason.Equals(CloseReason.WindowsShutDown))
                {
                    if (MessageBox.Show("Are you sure you want to exit without ending the current Task?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) != DialogResult.Yes)
                        e.Cancel = true;
                }
                else if (MessageBox.Show("Are you sure you want to exit without ending the current Task?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }*/

            if (!TaskTracker.isCurrentTaskNull)
                TaskTracker.NullCurrentTask();
            TaskTracker.EndCurrentDay();

            Setting.Save();

            CleanData.CleanJira();

            if (trayIcon != null)
                trayIcon.Visible = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_Hotkey.Registered)
                _Hotkey.Unregister();
        }

        private void IssueNumberCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UseButton_Click((object)sender, (EventArgs)e);
            }
        }

        private void LastTaskLabel_TextChanged(object sender, EventArgs e)
        {
            if (LastTaskLabel.Text == "0.00" || LastTaskLabel.Text == "0")
            {
                LastTaskLabel.Visible = false;
                label2.Visible = false;
            }
            else
            {
                LastTaskLabel.Visible = true;
                label2.Visible = true;
            }
        }

        private void LeftoverLabel_TextChanged(object sender, EventArgs e)
        {
            if (LeftoverLabel.Text == "0.00" || LeftoverLabel.Text == "0")
            {
                LeftoverLabel.Visible = false;
                label1.Visible = false;
                MoveLeftOverButton.Visible = false;
            }
            else
            {
                LeftoverLabel.Visible = true;
                label1.Visible = true;
                MoveLeftOverButton.Visible = true;
            }
        }

        private void Main_LocationChanged(object sender, EventArgs e)
        {
            if (jiraLogin.Visible)
            {
                jiraLogin.Location = new Point(this.Location.X - this.Width, this.Location.Y);
            }
        }

        private void MessageWatcher_Tick(object sender, EventArgs e)
        {
            //messageWatcher.CheckAsync();
        }

        private void logBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logBrowser.IsDisposed)
                logBrowser = new LogBrowser();
            logBrowser.Show();
            logBrowser.Focus();
        }

        private void jiraBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jiraTicket != null && jiraTicket.Visible)
            {
                jiraTicket.DefaultScreen();
            }
            else
            {
                jiraTicket = new JiraIssueBrowser();
                jiraTicket.DefaultScreen();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newSettings == null || newSettings.IsDisposed)
                newSettings = new NewSettings();
            newSettings.Show();
            newSettings.Focus();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleTimer();
            StopButton.Enabled = true;
            endToolStripMenuItem.Enabled = true;
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndDay();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SendMessage().Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticHandler.Notes.Show();
            if (IssueNumber.Text != "")
                StaticHandler.Notes.AddTab(IssueNumber.Text);
            else if (IssueNumberCombo.Text != "")
                StaticHandler.Notes.AddTab(IssueNumberCombo.Text);
        }

        private void useStripMenuItem1_Click(object sender, EventArgs e)
        {
            UseTime();
        }

        private void advancedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (advanced == null || advanced.IsDisposed)
                advanced = new Advanced();
            advanced.Show();
            advanced.Focus();
        }

        private void manualStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManualTime().Show();
        }

        private void suggestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Suggestion().Show();
        }

        private void jiraDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new JiraData().Show();
        }

        private void applyThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("http://csmithut.net/RandomFiles/img.gif");
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            BackgroundPicture.Image = img;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestNotif();
        }

        private void dataVisualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.Data.DataVisualizer().Show();
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clean up unnecessary data? \n\nThis will not affect recorded data. This will only clean up data that is no longer used. This includes cached Jira attachments, backup data, etc.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CleanData.CleanAllData())
                    MessageBox.Show("Clean was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Clean was unsuccessful", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstTimeSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FirstTimeSetup().Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Setting.Value.General_JiraAccess && Setting.Value.Jira_AutoCheck)
                jiraLogin.AutoLogin(sender, e);
        }

        private void playgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Playground().Show();
        }

        #endregion

        #region Deprecated
        //HotKey _hotKey = new HotKey(Key.F9, KeyModifier.Shift | KeyModifier.Win, TimeHandler.OnHotKeyHandler);

        Hotkey _Hotkey = new Hotkey();

        public void RegisterHotkey(HotKeyLayout hk)
        {
            if (_Hotkey.Registered)
                _Hotkey.Unregister();
            _Hotkey.KeyCode = hk.Key;
            _Hotkey.Control = hk.Ctrl;
            _Hotkey.Shift = hk.Shift;
            _Hotkey.Alt = hk.Alt;
            _Hotkey.Pressed += delegate { QuickUse(); };

            _Hotkey.Register(this);
        }
        #endregion

        public void UpdateSystemTrayIcon(bool isCheckingJira)
        {
            if (!Setting.Value.Jira_ShowTrayIcon && !Setting.Value.Notification_WindowsNotification)
            {
                if (trayIcon != null)
                    trayIcon.Visible = false;
                return;
            }
            if (trayIcon == null)
            {
                trayIcon = new NotifyIcon();
            }


            if (isCheckingJira)
            {
                this.Icon = Resources.closed;
                trayIcon.Icon = Resources.green_icon;
                trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                        new MenuItem("Stop Checking Jira", StopCheckingJira),
                        new MenuItem("Check Jira Now", JiraChecker_Tick)
                    });
                if (!Setting.Value.Notification_WindowsNotification)
                    trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Hide Tray Icon", HideTrayIcon));
                trayIcon.Visible = true;
                trayIcon.Text = "Jira is currently being monitored for new tickets";
            }
            else
            {
                this.Icon = Resources.closed;
                trayIcon.Icon = Resources.red_icon;
                if (_Jira != null)
                {
                    trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {

                        new MenuItem("Resume Checking Jira", ResumeCheckingJira)
                    });
                }
                else
                {
                    trayIcon.ContextMenu = new ContextMenu();
                }
                if (!Setting.Value.Notification_WindowsNotification)
                    trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Hide Tray Icon", HideTrayIcon));
                trayIcon.Visible = true;
                trayIcon.Text = "Jira is not currently being monitored\r\nReason: " + Regex.Replace(Enum.GetName(typeof(JiraCheckingState), jiraCheckingState), "(\\B[A-Z])", " $1");
            }
        }

        private void JiraCheckerCorrector()
        {
            if (JiraLastChecked == null)
                JiraLastChecked = DateTime.Now;

            if (JiraLastChecked.Second + 60 < DateTime.Now.Second && JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Unknown;
            else if (JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Checking;
            else if (!JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Disabled;
        }

        public void HideTrayIcon(object Sender, EventArgs e)
        {
            Setting.Value.Jira_ShowTrayIcon = false;
            Setting.Save();
            if (trayIcon != null)
                trayIcon.Visible = false;
        }

        public void StopCheckingJira(object Sender, EventArgs e)
        {
            JiraChecker.Enabled = false;
            jiraCheckingState = JiraCheckingState.Disabled;
        }

        public void ResumeCheckingJira(object Sender, EventArgs e)
        {
            if (jiraCheckingState == JiraCheckingState.FailedLogin)
                jiraLogin.Show();
            else if (jiraCheckingState == JiraCheckingState.LostInternet)
            {
                if (Program.CheckForInternetConnection())
                {
                    JiraChecker.Enabled = true;
                    jiraCheckingState = JiraCheckingState.Checking;
                }
                else
                {
                    jiraCheckingState = JiraCheckingState.LostInternet;
                    ToastNotification("Lost Internet Connection", "Cannot connect to the internet. Unable resume checking Jira", 5, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction]);
                }
            }
            else
            {
                JiraChecker.Enabled = true;
                jiraCheckingState = JiraCheckingState.Checking;
            }
        }

        private void enterCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Command().Show();
        }

        private void lACPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void taskListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Tasks().Show();
        }

        private void clearChromeCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\Cache");
            foreach (string s in files)
            {
                try
                {
                    File.Delete(s);
                }
                catch { }
            }
            MessageBox.Show("Chrome cache cleared");
        }

        #region Theme Stuff
        private bool drag = false;
        private Point start_point = new Point(0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.start_point = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.start_point.X,
                                     p2.Y - this.start_point.Y);
                this.Location = p3;
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            //this.ForeColor = Invert(this.ForeColor);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void colorPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ColorPicker().Show();
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Command().Show();
        }

        private void ThemedMain_Load(object sender, EventArgs e)
        {
            if (Setting.Value.General_JiraAccess && Setting.Value.Jira_AutoCheck)
                jiraLogin.AutoLogin(sender, e);
        }
    }
}
