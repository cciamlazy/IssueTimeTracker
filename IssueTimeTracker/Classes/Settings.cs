using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IssueTimeTracker.Classes
{
    public enum JiraMode
    {
        Nothing,
        InApplication,
        WebBrowser
    }

    public enum Position
    {
        TechnicalSupport,
        AccountManager,
        ImplementationEngineer,
        BusinessAnalyst,
        Other,
    }
    public class Settings
    {

        //General Settings
        public bool General_FirstTime { get; set; } = true;
        public string General_CurrentVersion { get; set; }
        public bool General_FirstTimeAfterUpdate { get; set; } = true;
        public Position General_Position { get; set; } = Position.TechnicalSupport;               // 0
        public bool General_JiraAccess { get; set; } = true;
        public bool General_APSUtlizer { get; set; } = true;

        //public int Message_Total { get; set; } = 0;

        //Notification Settings
        public bool Notification_Messages { get; set; } = true;
        public int Notification_Screen { get; set; } = 0;
        public int Notification_Corner { get; set; } = 2;
        public int Notification_Direction { get; set; } = 0;
        public int Notification_Frequency { get; set; } = 13;
        public int Notification_Scale { get; set; } = 100;
        public string Notification_Sound { get; set; } = "normal";
        [XmlElement(Type = typeof(XmlColor))]
        public Color Notification_Color { get; set; } = Color.FromArgb(64, 64, 64);
        [XmlElement(Type = typeof(XmlColor))]
        public Color Notification_TextColor { get; set; } = Color.White;
        public bool Notification_WindowsNotification { get; set; } = false;

        //Timer Settings
        [XmlElement(Type = typeof(XmlColor))]
        public Color Timer_TotalProgressColor { get; set; } = Color.DeepSkyBlue;
        [XmlElement(Type = typeof(XmlColor))]
        public Color Timer_CurrentTaskColor { get; set; } = Color.DodgerBlue;
        public Point Timer_StartLocation { get; set; } = new Point(300, 75);
        public HotKeyLayout Timer_QuickUse { get; set; } // Ctrl+Shift+Q
        public int Timer_MaxRecentIssues { get; set; } = 5;
        public bool Timer_Notes { get; set; } = false;
        public int Timer_RoundUpMinutes { get; set; } = 3;
        public int Timer_RoundUpSeconds { get; set; } = 0;
        public decimal Timer_Opacity { get; set; } = 0.85m;
        public bool Timer_Themes { get; set; } = false;

        public bool PreviewTheme { get; set; } = false;
        public Theme CurrentTheme { get; set; } = Theme.LightTheme;
        public List<Theme> Themes { get; set; } = new List<Theme>();

        //Log Settings
        public int Log_CurrentDayID { get; set; } = 0;       // 0
        public int Log_CurrentTaskID { get; set; } = 0;      // 0
        public bool Log_WriteXlsx { get; set; } = false;
        public string Log_XlsxDestination { get; set; } = "!";    // !
        public bool Log_Backup { get; set; } = false;

        //Jira Settings
        public string Jira_Username { get; set; } = "";
        public string Jira_Link { get; set; } = "https://eccoviasolutions.atlassian.net/";
        public bool Jira_AutoCheck { get; set; } = false;
        public JiraMode Jira_Mode { get; set; } = JiraMode.InApplication;
        public string Jira_Response { get; set; } = "";
        public List<string> Jira_Responses { get; set; } = new List<string>();
        public bool Jira_SavePassword { get; set; } = false;
        public string Jira_EncryptedPassword { get; set; } = "";
        public bool Jira_ShowTrayIcon { get; set; } = true;

        //Notes
        public List<string> Notes_OpenTabs = new List<string>();
        public int Notes_SelectedNote { get; set; } = -1;
        public bool Notes_AlwaysOnTop { get; set; } = false;
        public bool Notes_WordWrap { get; set; } = false;

        //Bugs
        public int Bugs_Remember { get; set; } = 0;

        //Jira Data form
        public List<JiraDataSave> JiraData_List { get; set; } = new List<JiraDataSave>();

        //Reminders
        public Point Reminder_FormPosition { get; set; } = new Point(300, 75);
        public Size Reminder_FormSize { get; set; } = new Size(275, 375);
        public int Reminder_ItemWidth { get; set; } = 125;
        public int Reminder_DateWidth { get; set; } = 100;
        public bool Reminder_ShowCompleted { get; set; } = false;
    }
}
