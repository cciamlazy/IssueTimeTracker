using IssueTimeTracker.Forms;
using IssueTimeTracker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        
        public static JiraIssueBrowser jiraTicket;

        private static DateTime JiraLastChecked;
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

        public static void Initialize()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.closed,
                Visible = Setting.Value.Jira_ShowTrayIcon
            };
        }

        public static void ToastNotification(string header, string body, bool sound = true, int duration = -1, string issue = "")
        {
            if (Setting.Value.Notification_WindowsNotification)
            {
                if (trayIcon == null)
                {
                    Initialize();
                }
                TempIssue = issue;
                trayIcon.BalloonTipTitle = header;
                trayIcon.BalloonTipText = body;
                trayIcon.BalloonTipClicked += new EventHandler(BalloonTipClick);
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

        public static string TempIssue = "";

        public async static void BalloonTipClick(object sender, EventArgs e)
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

        public static void UpdateSystemTrayIcon(bool isCheckingJira)
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
                trayIcon.Icon = Resources.green_icon;
                trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                        new MenuItem("Stop Checking Jira", StopCheckingJira),
                        //new MenuItem("Check Jira Now", StaticHandler._ThemedMain.JiraChecker_Tick)
                    });
                if (!Setting.Value.Notification_WindowsNotification)
                    trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Hide Tray Icon", HideTrayIcon));
                trayIcon.Visible = true;
                trayIcon.Text = "Jira is currently being monitored for new tickets";
            }
            else
            {
                trayIcon.Icon = Resources.red_icon;
                if (StaticHandler._ThemedMain._Jira != null)
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

        private static void JiraCheckerCorrector()
        {
            if (JiraLastChecked == null)
                JiraLastChecked = DateTime.Now;

            if (JiraLastChecked.Second + 60 < DateTime.Now.Second && StaticHandler._ThemedMain.JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Unknown;
            else if (StaticHandler._ThemedMain.JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Checking;
            else if (!StaticHandler._ThemedMain.JiraChecker.Enabled)
                jiraCheckingState = JiraCheckingState.Disabled;
        }

        public static void HideTrayIcon(object Sender, EventArgs e)
        {
            Setting.Value.Jira_ShowTrayIcon = false;
            Setting.Save();
            if (trayIcon != null)
                trayIcon.Visible = false;
        }

        public static void StopCheckingJira(object Sender, EventArgs e)
        {
            StaticHandler._ThemedMain.JiraChecker.Enabled = false;
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
                    StaticHandler._ThemedMain.JiraChecker.Enabled = true;
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
                StaticHandler._ThemedMain.JiraChecker.Enabled = true;
                jiraCheckingState = JiraCheckingState.Checking;
            }
        }
    }
}
