using IssueTimeTracker.Classes.Notifications;
using IssueTimeTracker.Forms;
using IssueTimeTracker.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker.Classes.Helper
{
    public static class NotificationHandler
    {
        static FormAnimator.AnimationDirection[] Directions = { FormAnimator.AnimationDirection.Up, FormAnimator.AnimationDirection.Down, FormAnimator.AnimationDirection.Left, FormAnimator.AnimationDirection.Right };
        public static NotifyIcon trayIcon;
        
        //public static JiraIssueBrowser jiraTicket;

        public static DateTime JiraLastChecked;
        public static JiraCheckingState jiraCheckingState
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
        private static JiraCheckingState _jiraCheckingState = JiraCheckingState.Disabled;

        public static bool ComputerLocked { get; private set; } = false;

        public static Dictionary<string, string> Carriers { get; private set; } = new Dictionary<string, string>();

        static Dictionary<string, int> trayMenuItems = new Dictionary<string, int>();

        public static void Initialize()
        {
            Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.closed,
                Visible = true
            };

            trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Quick Enter Issue #", QuickEnter) {  },
                new MenuItem("Check Jira Now", TickJiraChecker),
                new MenuItem("Resume Checking Jira", ResumeCheckingJira),
                new MenuItem("Pause Checking Jira", StopCheckingJira),
                new MenuItem("Minimize to system tray", MinimizeToSystemTray),
                new MenuItem("Restore", RestoreFromSystemTray),
                new MenuItem("Check for Updates", CheckForUpdates)
            });

            trayMenuItems.Add("QuickEnter", trayMenuItems.Count);
            trayMenuItems.Add("Check", trayMenuItems.Count);
            trayMenuItems.Add("Resume", trayMenuItems.Count);
            trayMenuItems.Add("Pause", trayMenuItems.Count);
            trayMenuItems.Add("Minimize", trayMenuItems.Count);
            trayMenuItems.Add("Restore", trayMenuItems.Count);
            trayMenuItems.Add("Update", trayMenuItems.Count);

            UpdateTrayItem("Resume", false);
            UpdateTrayItem("Restore", false);

            Carriers.Add("AT&T", "@mms.att.net");
            Carriers.Add("T-Mobile", "@tmomail.net");
            Carriers.Add("Verizon", "@vzwpix.com");
            Carriers.Add("Sprint", "@pm.sprint.com");
            Carriers.Add("Virgin Mobile", "@vmpix.com");
            Carriers.Add("Metro PCS", "@mymetropcs.com");
            Carriers.Add("Cricket", "@mms.cricketwireless.net");
            Carriers.Add("Google Fi", "@msg.fi.google.com");
            Carriers.Add("Ting", "@message.ting.com");
            Carriers.Add("Boost Mobile", "@myboostmobile.com");
        }

        private static void UpdateTrayItem(string tag, bool visible)
        {
            trayIcon.ContextMenu.MenuItems[trayMenuItems[tag]].Visible = visible;
        }

        public static void Dispose()
        {
            trayIcon.Dispose();
        }

        private static List<string> IssuesTexted = new List<string>();

        private static List<TicketNameAssist> balloonTickets = new List<TicketNameAssist>();

        public static void ToastNotification(string header, string body, bool sound = true, int duration = -1, string issue = "")
        {
            if (Setting.Value.Notification_TextNotification && (ComputerLocked || Setting.Value.Notification_TextWhenUnlocked) && issue != "" && !IssuesTexted.Contains(issue))
            {
                WebClient webClient = new WebClient();
                try
                {
                    string project = issue.Split('-')[0];
                    IssuesTexted.Add(issue);
                    webClient.DownloadString(MainData.Instance.Domain + string.Format("IssueTimeTracker/PostText.php?email={0}&subject={1}&msg={2}",
                        (Setting.Value.Notification_PhoneNumber + Carriers[Setting.Value.Notification_Carrier]), header, body + "\r\n" + Setting.Value.Jira_Link + @"projects/" + project + "/issues/" + issue));
                }
                catch (Exception ea)
                {
                    ErrorLog.GenerateLog("NotificationHandler.ToastNotification", ea.Message, ea.StackTrace);
                }
                webClient.Dispose();
            }

            if (Setting.Value.Notification_WindowsNotification)
            {
                if (trayIcon == null)
                {
                    Initialize();
                }
                balloonTickets.Add(new TicketNameAssist() { Issue = issue, Text = body });
                trayIcon.BalloonTipTitle = header;
                trayIcon.BalloonTipText = body;
                trayIcon.BalloonTipClicked += new EventHandler(BalloonTipClick);
                if (duration == -1)
                    duration = 30;
                else if (duration <= 5)
                    duration = 5;
                duration *= 1000;
                if (duration > 30000)
                    duration = 30000;
                trayIcon.Visible = true;
                trayIcon.Tag = issue;
                trayIcon.ShowBalloonTip(duration);
            }
            else
            {
                var toastNotification = new Notification(header, body, duration, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction], -1, issue);
                toastNotification.Show();
                PlayNotificationSound(Setting.Value.Notification_Sound);
            }
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

        public async static void BalloonTipClick(object sender, EventArgs e)
        {
            NotifyIcon n = (NotifyIcon)sender;
            string issue = "";
            foreach (TicketNameAssist t in balloonTickets)
                if (t.Text == n.BalloonTipText)
                    issue = t.Issue;
            if (issue != null && issue != "" && Setting.Value.Jira_Mode != Classes.JiraMode.Nothing)
            {
                if (Setting.Value.Jira_Mode == Classes.JiraMode.InApplication)
                {
                    StaticHandler._ThemedMain.jiraTicket = new JiraIssueBrowser();
                    StaticHandler._ThemedMain.jiraTicket.Show();
                    await StaticHandler._ThemedMain.jiraTicket.NavigateToIssueByKey(issue);
                    StaticHandler._ThemedMain.jiraTicket.AddPremadeResponse();
                }
                else if (Setting.Value.Jira_Mode == Classes.JiraMode.WebBrowser)
                {
                    string project = issue.Split('-')[0];
                    Process.Start(Setting.Value.Jira_Link + @"projects/" + project + "/issues/" + issue);
                }
            }
        }

        public static void UpdateSystemTrayIcon(bool isCheckingJira)
        {
            if (trayIcon == null)
            {
                Initialize();
            }


            if (isCheckingJira)
            {
                UpdateTrayItem("Resume", false);
                UpdateTrayItem("Pause", true);
                trayIcon.Text = "Jira is currently being monitored for new tickets";
                trayIcon.Icon = Resources.closed_green;
            }
            else
            {
                if (JiraChecker._Jira != null)
                {

                    UpdateTrayItem("Resume", true);
                    UpdateTrayItem("Pause", false);
                }
                trayIcon.Text = "Jira is not currently being monitored\r\nReason: " + Regex.Replace(Enum.GetName(typeof(JiraCheckingState), jiraCheckingState), "(\\B[A-Z])", " $1");
                trayIcon.Icon = Resources.closed_red;
            }
        }

        public static void JiraCheckerCorrector()
        {
            if (JiraLastChecked == null)
                JiraLastChecked = DateTime.Now;

            if (JiraLastChecked.Second + 60 < DateTime.Now.Second && StaticHandler._ThemedMain.JiraTicketChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Unknown;
            else if (StaticHandler._ThemedMain.JiraTicketChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Checking;
            else if (!StaticHandler._ThemedMain.JiraTicketChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Disabled;
        }

        public static void MinimizeToSystemTray(object Sender, EventArgs e)
        {
            trayIcon.Visible = true;
            StaticHandler._ThemedMain.Hide();
            UpdateTrayItem("Minimize", false);
            UpdateTrayItem("Restore", true);
        }

        public static void QuickEnter(object Sender, EventArgs e)
        {
            StaticHandler._ThemedMain.QuickUse();
        }

        public static  void TickJiraChecker(object Sender, EventArgs e)
        {
            StaticHandler._ThemedMain.JiraChecker_Tick(Sender, e);
        }

        public static void RestoreFromSystemTray(object Sender, EventArgs e)
        {
            StaticHandler._ThemedMain.Show();
            if (!StaticHandler._ThemedMain.IsOnScreen(StaticHandler._ThemedMain))
                StaticHandler._ThemedMain.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + 400, Screen.PrimaryScreen.WorkingArea.Y + 100);
            UpdateTrayItem("Minimize", true);
            UpdateTrayItem("Restore", false);
        }

        public static void CheckForUpdates(object Sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            if (!Program.CheckForInternetConnection())
            {
                MessageBox.Show("You have no internet connection");
                return;
            }
            string version = Program.getLatestVersion(wc);
            if ((File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")) &&
                Program.isNewer(Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version, version)) ||
                Program.isNewer(FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion, Program.getLatestVersion(wc)))
            {
                if (MessageBox.Show("An update is available, would you like to update now?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
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
            }
            else
            {
                MessageBox.Show("Issue Time Tracker is up-to-date!");
            }
        }

        public static void StopCheckingJira(object Sender, EventArgs e)
        {
            StaticHandler._ThemedMain.JiraTicketChecker.Enabled = false;
            jiraCheckingState = JiraCheckingState.Disabled;
        }

        public static void ResumeCheckingJira(object Sender, EventArgs e)
        {
            if (jiraCheckingState == JiraCheckingState.FailedLogin)
                StaticHandler._ThemedMain.jiraLogin.Show();
            else if (jiraCheckingState == JiraCheckingState.LostInternet)
            {
                if (Program.CheckForInternetConnection())
                {
                    StaticHandler._ThemedMain.JiraTicketChecker.Enabled = true;
                    jiraCheckingState = JiraCheckingState.Checking;
                }
                else
                {
                    jiraCheckingState = JiraCheckingState.LostInternet;
                    ToastNotification("Lost Internet Connection", "Cannot connect to the internet. Unable resume checking Jira", true, 5);
                }
            }
            else
            {
                StaticHandler._ThemedMain.JiraTicketChecker.Enabled = true;
                jiraCheckingState = JiraCheckingState.Checking;
            }
        }
        
        private static void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                //I left my desk
                ComputerLocked = true;
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                //I returned to my desk
                ComputerLocked = false;
            }
        }
    }
}
