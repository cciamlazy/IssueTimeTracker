using IssueTimeTracker.Classes;
using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker
{
    static class Program
    {
        public static string DataPath;

        public static BugReporter bugReporter;

        public static bool NeedsConversiontoJSON = false;

        internal static void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t)
        {
            Exception e = t.Exception;
            StackTrace st = new StackTrace(e);
            try
            {

                if (!Directory.Exists(Path.Combine(Program.DataPath, "ErrorLog")))
                    Directory.CreateDirectory(Path.Combine(Program.DataPath, "ErrorLog"));

                Dictionary<string, string> data = new Dictionary<string, string>
                {
                    { "ApproxLoginCount", MainData.Instance.ApproxLoginCount.ToString() }
                };

                ErrorLog log = new ErrorLog()
                {
                    Name = (Setting.Value.Jira_Username != null && Setting.Value.Jira_Username != "" ? Setting.Value.Jira_Username : Environment.UserName),
                    Date = DateTime.Now.ToString("M-d-yyyy"),
                    Time = DateTime.Now.ToString("h-mm-ss tt"),
                    Version = GetUpdateFile(Path.Combine(DataPath, "CurrentVersion.json")).Version,
                    StackTrace = e.StackTrace,
                    Source = e.Source,
                    Message = e.Message,
                    Data = data
                };
                bugReporter = new BugReporter(log);
                
                var path = Path.Combine(Program.DataPath + "ErrorLog", log.Date + " " + log.Time + " Error.json");

                Serializer<ErrorLog>.WriteToJSONFile(log, path);

                if (e.Source == "Atlassian.Jira")
                    JiraChecker.JiraFailCount++;
            }
            catch
            {
                //it done messed up
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static Update GetUpdateFile(string path)
        {
            Update update = null;
            if (File.Exists(path))
            {
                update = Serializer<Update>.LoadFromJSONFile(path);
            }
            return update;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if !DEBUG
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Program.OnThreadException);
#endif

            Program.DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker\\Data\\";

            if(File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.xml")) && !File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")))
            {
                Serializer<Update>.WriteToJSONFile(Serializer<Update>.LoadFromXMLFile(Path.Combine(Program.DataPath, "CurrentVersion.xml")), Path.Combine(Program.DataPath, "CurrentVersion.json"));
            }

            if (File.Exists(Path.Combine(Program.DataPath, "Settings.xml")))
            {
                Setting.Load("xml");
                NeedsConversiontoJSON = true;
            }
            else
                Setting.Load();

            AdminControl.Load();

            MainData.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!NeedsConversiontoJSON)
            {
                if (!File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")) || Setting.Value.General_CurrentVersion == null || isNewer(Setting.Value.General_CurrentVersion, Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version))
                {
                    Setting.Value.General_FirstTimeAfterUpdate = true;
                    if (File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")))
                        Setting.Value.General_CurrentVersion = Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version;
                    else
                        Setting.Value.General_CurrentVersion = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
                }
                else
                    Setting.Value.General_FirstTimeAfterUpdate = false;
            }
            else
            {
                UpdateToOnePointSeven();
                return;
            }

            if (Setting.Value.General_FirstTimeAfterUpdate)
            {
                if (Directory.Exists(Path.Combine(DataPath, "ErrorLog")))
                    foreach (string s in Directory.GetFiles(Path.Combine(DataPath, "ErrorLog")))
                        File.Delete(s);
            }
            try
            {
                if (!Directory.Exists(Program.DataPath))
                    Directory.CreateDirectory(Program.DataPath);
                if (!Directory.Exists(Program.DataPath + "\\TaskData\\"))
                    Directory.CreateDirectory(Program.DataPath + "\\TaskData\\");
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Tasks\\"))
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Tasks\\");
            }
            catch
            {
                MessageBox.Show("Please run as Administrator for setup");
            }

            WebClient wc = new WebClient();
            if (CheckForInternetConnection() && File.Exists(Path.Combine(DataPath, "CurrentVersion.json")) && isNewer(GetUpdateFile(Path.Combine(DataPath, "CurrentVersion.json")).Version, getLatestVersion(wc)))
            {
                string updater = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker\\IssueTimeTrackerUpdater.exe";
                try
                {
                    if (File.Exists(updater))
                        File.Delete(updater);
                    wc.DownloadFile(MainData.Instance.Domain + "IssueTimeTracker/IssueTimeTrackerUpdater.exe", updater);
                }
                catch
                {

                }
                if (File.Exists(updater))
                    Process.Start(updater);
            }

            
            
            if (Setting.Value.General_FirstTime)
                Application.Run(new FirstTimeSetup());

            Setting.Value.General_FirstTimeAfterUpdate = false;
            Setting.Save();

            /*if (Properties.Settings.Default.Timer_TestStyle)
                Application.Run(new TestIssueTimeTracker());
            else*/
            //if (Setting.Value.Timer_Themes)
                Application.Run(new ThemedMain());
            //else
            //    Application.Run(new Main());
        }

        private static void UpdateToOnePointSeven()
        {
            Serializer<Settings>.WriteToJSONFile(Setting.Value, Path.Combine(Program.DataPath, "Settings.json"));
            Application.Run(new OnePointSevenConverter());
        }
        
        public static string getLatestVersion(WebClient webClient)
        {
            try
            {
                if (!CheckForInternetConnection())
                    return FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
                return webClient.DownloadString(MainData.Instance.Domain + "IssueTimeTracker/");
            }
            catch { }
            return "";
        }

        public static bool isNewer(string curVersion, string newVersion)
        {
            try
            {
                return new Version(newVersion) > new Version(curVersion);
            }
            catch { }
            return false;
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
    }
}
