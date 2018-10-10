using Atlassian.Jira;
using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public static class JiraChecker
    {
        public static bool LoggedIn { get { return _loggedIn; } set
            {
                StaticHandler._ThemedMain.jiraBrowserToolStripMenuItem.Enabled = value;
                StaticHandler._ThemedMain.jiraDataToolStripMenuItem.Enabled = value;
                _loggedIn = value;
            }
        }
        private static bool _loggedIn = false;
        public static Jira _Jira { get { return jira; } set { jira = value; MainData.Instance.ApproxLoginCount++; MainData.Export(); } }
        private static Jira jira;
        public static SecureString JiraPassword { get; set; }
        public static int JiraFailCount = 0;
        private static int oldJiraFailCount = 0;
        
        private static bool lostInternet = false;


        public async static void CheckJira()
        {
            if (_Jira == null || JiraFailCount > 5)
            {
                NotificationHandler.jiraCheckingState = JiraCheckingState.Unknown;
                return;
            }

            if (!DoInternetCheck())
                return;

            if (JiraFailCount == 5)
            {
                JiraFailCount++;
                NotificationHandler.ToastNotification("Jira Failed", "Jira failed at getting Jira issues too many times. Log in again from settings");
                NotificationHandler.jiraCheckingState = JiraCheckingState.FailedLogin;
                LoggedIn = false;
                return;
            }

            await JiraCheck();
        }


        private static bool DoInternetCheck()
        {
            bool internet = Program.CheckForInternetConnection();

            if (!internet && !lostInternet)
            {
                lostInternet = true;
                NotificationHandler.ToastNotification("Lost Connection", "You've lost internet connection. Jira will not be checked in the meantime");
                LoggedIn = false;
                NotificationHandler.jiraCheckingState = JiraCheckingState.LostInternet;
                return false;
            }
            else if (internet && lostInternet)
            {
                lostInternet = false;
                NotificationHandler.ToastNotification("Connection Established", "Jira checking will resume");
                LoggedIn = true;
                NotificationHandler.jiraCheckingState = JiraCheckingState.Checking;
                return true;
            }
            else if (!internet && lostInternet)
                return false;
            return true;
        }


        private static async Task<bool> JiraCheck()
        {
            bool relogged = false;
            if(JiraFailCount > oldJiraFailCount && Setting.Value.Jira_Username != "" && Setting.Value.Jira_Username != "!" && JiraPassword != null)
            {
                _Jira = Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(JiraPassword), new JiraRestClientSettings() { EnableRequestTrace = true });
                relogged = true;
                LoggedIn = true;
            }
            _Jira.Issues.MaxIssuesPerRequest = 5;
            foreach (SLA sla in Setting.Value.Jira_SLAs)
            {
                if (sla.JiraProject != "")
                {
                    try
                    {
                        IEnumerable<Issue> jiraIssues = await _Jira.Issues.GetIssuesFromJqlAsync("project = " + sla.JiraProject + " AND resolution = unresolved AND assignee is empty");
                        foreach (var issue in jiraIssues)
                        {
                            if (issue.Project.Equals(sla.JiraProject) && (issue.Assignee == null || issue.Assignee == ""))
                                JiraNotification("\n" + issue.Key.Value + " - " + GetTimeLeft(issue.Created.Value, sla.Minutes).ToString() + " minutes left\n" + issue.Summary, issue.Key.Value);
                        }
                        NotificationHandler.JiraLastChecked = DateTime.Now;
                        NotificationHandler.jiraCheckingState = JiraCheckingState.Checking;
                        LoggedIn = true;
                    }
                    catch (Exception e)
                    {
                        ErrorLog.GenerateLog("JiraChecker - SLA: " + sla.JiraProject, e.Message, e.StackTrace);
                        NotificationHandler.ToastNotification("Failed", "Failed to poll Jira project: " + sla.JiraProject + (relogged ? "\nThere is a problem connecting you to the " + sla.JiraProject + " project" : ""), true, 10);
                        oldJiraFailCount = JiraFailCount;
                        JiraFailCount++;
                    }
                }
            }

            /*if (relogin && StaticHandler.JiraFailCount > 3 && Setting.Value.Jira_Username != "" && Setting.Value.Jira_Username != "!" && JiraPassword != null)
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
                        JiraNotification("\n" + issue.Key.Value + " - " + GetTimeLeft(issue.Created.Value, 15).ToString() + " minutes left\n" + issue.Summary, issue.Key.Value);
                }
                NotificationHandler.JiraLastChecked = DateTime.Now;
                NotificationHandler.jiraCheckingState = JiraCheckingState.Checking;
            }
            catch
            {
                jiraBrowserToolStripMenuItem.Enabled = false;
                NotificationHandler.jiraCheckingState = JiraCheckingState.FailedLogin;
                if (StaticHandler.JiraFailCount > 0 && Setting.Value.Jira_Username != "" && Setting.Value.Jira_Username != "!" && JiraPassword != null)
                {
                    _Jira = Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(JiraPassword), new JiraRestClientSettings() { EnableRequestTrace = true });
                }
                if (!loop)
                    JiraCheck(true);
                else
                {
                    StaticHandler.JiraFailCount++;
                    NotificationHandler.jiraCheckingState = JiraCheckingState.FailedLogin;

                }
            }*/
            return true;
        }

        private static int GetTimeLeft(DateTime time, int minutes)
        {
            return (int)(minutes - (DateTime.Now - time).TotalMinutes);
        }

        public static void JiraNotification(string _jira = "", string laissue = "")
        {
            int duration = -1;

            if (_jira != "")
                duration = 30;
            else
                duration = Setting.Value.Notification_Frequency * 60;

            /*string jira = "";
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
                jira = _jira;*/

            NotificationHandler.ToastNotification("LA County Issues", (_jira != "" ? "New Jira Issue" + _jira : (Setting.Value.Jira_AutoCheck ? "No new issues found\n" : "Jira Auto Check is Off\nCheck LA County for issues")), true, duration, laissue);
        }
    }
}
