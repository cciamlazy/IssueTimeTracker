using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker
{
    public partial class OnePointSevenConverter : Form
    {
        public OnePointSevenConverter()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        #region Variables
        NewSettings newSettings;

        private bool drag = false;
        private Point start_point = new Point(0, 0);

        //If true it will be the time progressbar and false will be the task progressbar
        bool TimeProgressBar = true;

        #endregion
        
        #region Events

        private void OnePointSevenConverter_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, this.Width, this.Height));
            DayProgress.ProgressColor = Setting.Value.Timer_TotalProgressColor;
            MessageBox.Show("Due to a large change that I made to the way data is stored, all data created from this application must be converted. I recommend using the available backup button to create a backup before proceeding with this process in case anything goes wrong.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, this.Width, this.Height));
        }

        #endregion

        #region Drag Window

        private void DayProgress_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
            this.start_point = new Point(e.X, e.Y);
        }

        private void DayProgress_MouseMove(object sender, MouseEventArgs e)
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

        private void DayProgress_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        #endregion

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (newSettings == null || newSettings.IsDisposed)
                newSettings = new NewSettings();
            newSettings.Show();
            newSettings.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Issue Time Tracker Backup|*.ittb";
            saveDialog.Title = "Create Backup";
            
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName))
                    File.Delete(saveDialog.FileName);
                CreateBackup(saveDialog.FileName);
            }
        }

        private void CreateBackup(string loc)
        {
            List<FileInfo> files = new List<FileInfo>();

            if (Program.DataPath == null || Program.DataPath == "")
                Program.DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker\\Data\\";

            if(File.Exists(Path.Combine(Program.DataPath, "Settings.xml")))
                files.Add(new FileInfo(Path.Combine(Program.DataPath, "Settings.xml")));
            if (File.Exists(Path.Combine(Program.DataPath, "Data.xml")))
                files.Add(new FileInfo(Path.Combine(Program.DataPath, "Data.xml")));
            if (File.Exists(Path.Combine(Program.DataPath, "AdminControl.xml")))
                files.Add(new FileInfo(Path.Combine(Program.DataPath, "AdminControl.xml")));
            List<string> f = new List<string>();

            string[] dirs = new string[] { "Messages", "Notes", "Sounds", "TaskData" };
            foreach (string s in dirs)
                if (Directory.Exists(Path.Combine(Program.DataPath, s)))
                    f.AddRange(Directory.GetFiles(Path.Combine(Program.DataPath, s), "*", SearchOption.AllDirectories));

            List<DownloadFile> download = Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.xml")).Files;
            for (int i = f.Count - 1; i >= 0; i--)
            {
                foreach (DownloadFile df in download)
                    if (f[i].Contains(df.FileName))
                        f.RemoveAt(i);
            }

            foreach (string l in f)
                if (File.Exists(l))
                    files.Add(new FileInfo(l));

            using (var fileStream = new FileStream(loc, FileMode.Create))
            {
                using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create))
                {
                    foreach (FileInfo fi in files)
                    {
                        archive.CreateEntryFromFile(fi.FullName, fi.FullName.Replace(Program.DataPath, ""));
                    }
                }
            }

            MessageBox.Show("Backup completed");
        }

        int progress = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            string[] files = Directory.GetFiles(Program.DataPath, "*.xml", SearchOption.AllDirectories);

            DayProgress.Maximum = files.Length * 4;
            bool completed = ConvertAllDataToJSON(files);
            if(completed)
            {
                MessageLabel.ForeColor = Color.Green;
                MessageLabel.Text = "Completed";
                progress = DayProgress.Maximum;
                DayProgress.ProgressColor = Color.Green;
                Program.NeedsConversiontoJSON = false;
                Thread.Sleep(3000);
                MessageBox.Show("Application needs to restart to complete changes");
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IssueTimeTracker\\IssueTimeTracker.exe");
                this.Close();
            }
            else
            {
                MessageLabel.ForeColor = Color.Red;
                MessageLabel.Text = "Failed";
                progress = DayProgress.Maximum;
                DayProgress.ProgressColor = Color.Red;
            }
        }

        private bool ConvertAllDataToJSON(string[] files)
        {
            // Convert TaskData
            string curPath = Path.Combine(Program.DataPath, "TaskData");
            if (Directory.Exists(curPath))
            {
                string[] taskFiles = Directory.GetFiles(curPath, "*.xml", SearchOption.AllDirectories);
                foreach(string s in taskFiles)
                {
                    progress++;
                    Day day = Serializer<Day>.LoadFromXMLFile(s);
                    progress++;
                    Serializer<Day>.WriteToJSONFile(day, s.Replace("xml", "json"));
                    progress++;
                }
            }

            // Convert 
            curPath = Path.Combine(Program.DataPath, "AdminControl.xml");
            if (File.Exists(curPath))
            {
                AdminControl adminControl = Serializer<AdminControl>.LoadFromXMLFile(curPath);
                Serializer<AdminControl>.WriteToJSONFile(adminControl, curPath.Replace("xml", "json"));
                //progress++;
            }

            foreach (string s in files)
                if (File.Exists(s))
                    try
                    {
                        File.Delete(s);
                        progress++;
                    }
                    catch { }

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DayProgress.Value = progress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool clean = CleanData.CleanAllData();
            if (clean)
                MessageBox.Show("Successfully cleaned all bad data. You can now run the conversion");
            else
                MessageBox.Show("Failed to clean all bad data (This isn't necessary for a successful conversion)");
            button1.Enabled = true;
        }
    }
}
