using IssueTimeTracker.Classes.Data;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class GenerateUpdateFile : Form
    {
        public GenerateUpdateFile()
        {
            InitializeComponent();
        }

        List<DownloadFile> files = new List<DownloadFile>();

        string[] DirectoryBlackList = new string[] { "TaskData", "ErrorLog", "Notes", "Jira", "Messages" };
        string[] ParentDirectoryBlackList = new string[] { "Messages", "Jira", "TaskData" };
        string[] FileBlackList = new string[] { "Reminders.json", "CurrentVersion.json", "OldVersion.json", "NewVersion.json", "Settings.json", "Data.json", "AdminControl.json",
            "CurrentVersion.xml", "OldVersion.xml", "NewVersion.xml", "Settings.xml", "Data.xml", "AdminControl.xml", "IssueTimeTrackerUpdater.exe" };

        private void GenerateUpdateFile_Load(object sender, EventArgs e)
        {
            ReleaseNotes.Text = "Build " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion + "\r\n" + DateTime.Today.ToShortDateString();
            Version.Text = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
            DateFromTextBox.Text = DateTime.Today.ToShortDateString();

            List<string> allfiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker", "*.*", System.IO.SearchOption.AllDirectories).ToList();
            foreach (string file in allfiles)
            {
                FileInfo f = new FileInfo(file);
                if(!DirectoryBlackList.Contains(f.Directory.Name) && !ParentDirectoryBlackList.Contains(f.Directory.Parent.Name) && !FileBlackList.Contains(f.Name))
                {
                    string newPath = file.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker", @"\").Replace("\\\\", "\\");
                    if(f.Name == "IssueTimeTracker.exe" || f.Name == "IssueTimeTracker.exe.config" || f.Name == "IssueTimeTracker.pdb" || isNew(f.Name))
                        files.Add(new DownloadFile() { FileName = newPath, FileVersion = Version.Text, DownloadLink = newPath.Replace(@"\", "/")});
                    else if (isOldFile(f.Name))
                        files.Add(GetDownloadFile(f.Name));
                    else
                        files.Add(new DownloadFile() { FileName = newPath, FileVersion = "1.0.0.0", DownloadLink = newPath.Replace(@"\", "/") });
                }
            }
            dataGrid.DataSource = files;
#if DEBUG
            ReleaseOrDebug.Text = "This is a Debug version";
            ReleaseOrDebug.ForeColor = Color.Red;
#else
            ReleaseOrDebug.Text = "This is a Release version";
            ReleaseOrDebug.ForeColor = Color.Black;
#endif
        }

        private bool isNew(string filename)
        {
            Update old;
            if (File.Exists(Program.DataPath + "CurrentVersion.json"))
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.json");
            else
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.xml");
            bool isNew = true;
            foreach(DownloadFile d in old.Files)
            {
                if (d.FileName.ToLower().Contains(filename.ToLower()))
                    isNew = false;
            }
            return isNew;
        }

        private bool isOldFile(string filename)
        {
            bool isOld = false;
            Update old;
            if (File.Exists(Program.DataPath + "CurrentVersion.json"))
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.json");
            else
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.xml");
            foreach (DownloadFile d in old.Files)
            {
                if (d.FileName.ToLower().Contains(filename.ToLower()))
                    isOld = true;
            }
            return isOld;
        }

        private DownloadFile GetDownloadFile(string filename)
        {
            Update old;
            if (File.Exists(Program.DataPath + "CurrentVersion.json"))
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.json");
            else
                old = GetUpdateFile(Program.DataPath + "CurrentVersion.xml");
            foreach (DownloadFile d in old.Files)
            {
                if (d.FileName.ToLower().Contains(filename.ToLower()))
                    return d;
            }
            return null;
        }

        private Update GetUpdateFile(string path)
        {
            Update update = null;
            if (File.Exists(path))
            {
                if (path.Contains(".xml"))
                    update = Serializer<Update>.LoadFromXMLFile(path);
                else
                    update = Serializer<Update>.LoadFromJSONFile(path);
            }
            return update;
        }

        string oldVersion = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;

        private void Version_TextChanged(object sender, EventArgs e)
        {
            ReleaseNotes.Text = ReleaseNotes.Text.Replace(oldVersion, Version.Text);
            oldVersion = Version.Text;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            for (int i = files.Count - 1; i >= 0; i--)
                if (files[i].FileVersion == "" || files[i].FileName.Contains("IssueTimeTrackerUpdater.exe"))
                    files.RemoveAt(i);

            Update update = new Update()
            {
                Version = Version.Text,
                ReleaseDate = DateFromTextBox.Text,
                ReleaseNotes = ReleaseNotes.Text,
                RequiredUpdate = Required.Checked,
                Skip = false,
                UpdateData = new List<UpdateData>(),
                Files = files
            };

            if (Verify.Checked)
                update.VerifyUpdate = true;
            

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IssueTimeTrackerUpdate\\";

            if (!Directory.Exists(Path.Combine(path, Version.Text, "Data")))
            {
                Directory.CreateDirectory(Path.Combine(path, Version.Text, "Data"));
            }

            File.WriteAllText(path + "index.html", Version.Text);

            foreach(DownloadFile d in update.Files)
            {
                if (d.FileVersion == Version.Text.Trim())
                {
                    string getFileFrom = AppDomain.CurrentDomain.BaseDirectory + d.FileName;
                    string getFileTo = path + Version.Text + d.FileName;
                    if (File.Exists(getFileTo))
                        File.Delete(getFileTo);
                    File.Copy(getFileFrom.Replace("\\\\", "\\"), getFileTo);
                }
            }
            if (File.Exists(path + "IssueTimeTrackerUpdater.exe"))
                File.Delete(path + "IssueTimeTrackerUpdater.exe");
            string updaterPath = "C:\\Users\\csmith\\Dropbox\\Programming\\IssueTimeTrackerUpdater\\IssueTimeTrackerUpdater\\bin\\Release\\IssueTimeTrackerUpdater.exe";
            if (File.Exists(updaterPath))
                File.Copy(updaterPath, path + "IssueTimeTrackerUpdater.exe");
            else if (File.Exists(updaterPath.Replace("Release", "Debug")))
                File.Copy(updaterPath.Replace("Release", "Debug"), path + "IssueTimeTrackerUpdater.exe");
            else
                MessageBox.Show("Updater not copied");

            var curPath = Path.Combine(path, Version.Text, "Data") + "\\CurrentVersion.json";

            Serializer<Update>.WriteToJSONFile(update, curPath);
            
            MessageBox.Show("Update files created successfully");
            button1.Enabled = true;
        }

        private void DateFromButton_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = true; // Make the calender visible for selecting a day
            monthCalendar.BringToFront(); //Bring the monthCalender control to the front of everything
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateFromTextBox.Text = monthCalendar.SelectionStart.ToShortDateString();
            monthCalendar.Visible = false;
        }

        string oldDate = DateTime.Now.ToShortDateString();

        private void DateFromTextBox_TextChanged(object sender, EventArgs e)
        {
            ReleaseNotes.Text = ReleaseNotes.Text.Replace(oldDate, DateFromTextBox.Text);
            oldDate = DateFromTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SftpClient client = new SftpClient("server237.web-hosting.com", 21098, AdminControl.Control.Domain_Username, AdminControl.Control.Domain_Password))
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IssueTimeTrackerUpdate\\";

                    client.Connect();
                    client.ChangeDirectory("/home/csmioyik/public_html/IssueTimeTracker");
                    foreach (string s in Directory.GetFiles(path))
                    {
                        using (FileStream fs = new FileStream(s, FileMode.Open))
                        {
                            client.BufferSize = 4 * 1024;
                            client.UploadFile(fs, Path.GetFileName(s));
                        }
                    }

                    client.CreateDirectory(Version.Text);
                    client.ChangeDirectory("/home/csmioyik/public_html/IssueTimeTracker/" + Version.Text);
                    foreach (string s in Directory.GetFiles(path + Version.Text))
                    {
                        using (FileStream fs = new FileStream(s, FileMode.Open))
                        {
                            client.BufferSize = 4 * 1024;
                            client.UploadFile(fs, Path.GetFileName(s));
                        }
                    }
                    client.CreateDirectory("Data");
                    client.ChangeDirectory("/home/csmioyik/public_html/IssueTimeTracker/" + Version.Text + "/Data");
                    foreach (string s in Directory.GetFiles(path + Version.Text + "\\Data"))
                    {
                        using (FileStream fs = new FileStream(s, FileMode.Open))
                        {
                            client.BufferSize = 4 * 1024;
                            client.UploadFile(fs, Path.GetFileName(s));
                        }
                    }
                }
                MessageBox.Show("Upload completed");
            }
            catch (Exception ae)
            {
                MessageBox.Show("Upload failed - " + ae.Message);
            }
        }
    }
}
