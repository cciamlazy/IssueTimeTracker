using IssueTimeTracker.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker.Forms.Deprecated
{
    public partial class Settings : Form
    {
        Main _Main;
        TestIssueTimeTracker _main;
        public Settings(Main main)
        {
            InitializeComponent();
            _Main = main;
        }

        public Settings(TestIssueTimeTracker main)
        {
            InitializeComponent();
            _main = main;
        }

        #region Variables

        FormAnimator.AnimationDirection[] Directions = { FormAnimator.AnimationDirection.Up, FormAnimator.AnimationDirection.Down, FormAnimator.AnimationDirection.Left, FormAnimator.AnimationDirection.Right };

        bool SettingsHaveChanged = false;
        bool FormLoaded = false;

        int OriginalScreen;
        int OriginalCorner;

        bool SawFrequencyWarning = false;

        HotKeyLayout Hotkey;
        bool RegisterHotkey = false;

        #endregion

        #region Save/Load

        private void Settings_Load(object sender, EventArgs e)
        {
            Setting.Reload();
            this.Text = "Settings - Current Version: " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
            //Load timer settings
            Timer_TotalColor.BackColor = Setting.Value.Timer_TotalProgressColor;
            Timer_CurrentColor.BackColor = Setting.Value.Timer_CurrentTaskColor;
            Timer_XPos.Text = Setting.Value.Timer_StartLocation.X.ToString();
            Timer_YPos.Text = Setting.Value.Timer_StartLocation.Y.ToString();
            Timer_MaxRecentIssues.Value = Setting.Value.Timer_MaxRecentIssues;
            Timer_Notes.Checked = Setting.Value.Timer_Notes;
            //UpdateHotkey(Setting.Value.Timer_QuickUse);

            if (Classes.Data.AdminControl.Control.View_Mode == Classes.Data.AdminControl.ViewMode.Advanced)
                updateFileButton.Visible = true;

            //Load Notification settings
            Notification_Messages.Checked = Setting.Value.Notification_Messages;
            OriginalScreen = Setting.Value.Notification_Screen;
            OriginalCorner = Setting.Value.Notification_Corner;
            Notification_ScreenComboBox.SelectedIndex = Setting.Value.Notification_Screen;
            Notification_CornerComboBox.SelectedIndex = Setting.Value.Notification_Corner;
            Notification_DirectionComboBox.SelectedIndex = Setting.Value.Notification_Direction;
            Notification_Frequency.Value = Setting.Value.Notification_Frequency;
            Notification_Scale.Value = Setting.Value.Notification_Scale;
            Notification_Color.BackColor = Setting.Value.Notification_Color;
            Notification_TextColor.BackColor = Setting.Value.Notification_TextColor;

            var soundsFolder = new DirectoryInfo(Path.Combine(Program.DataPath, "Sounds"));
            foreach (var file in soundsFolder.GetFiles())
            {
                Notification_SoundComboBox.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
            Notification_SoundComboBox.SelectedItem = Setting.Value.Notification_Sound;

            //Load Log Settings
            Log_ExportXlsx.Checked = Setting.Value.Log_WriteXlsx;
            Log_ExcelLocation.Text = Setting.Value.Log_XlsxDestination;

            //Load Jira Settings
            Jira_Link.Text = Setting.Value.Jira_Link;
            Jira_Username.Text = Setting.Value.Jira_Username;
            Jira_AutoCheckBox.Checked = Setting.Value.Jira_AutoCheck;

            FormLoaded = true;
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            //Save Timer Settings
            Setting.Value.Timer_TotalProgressColor = Timer_TotalColor.BackColor;
            Setting.Value.Timer_CurrentTaskColor = Timer_CurrentColor.BackColor;
            Setting.Value.Timer_StartLocation = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
            Setting.Value.Timer_MaxRecentIssues = (int)Timer_MaxRecentIssues.Value;
            Setting.Value.Timer_Notes = Timer_Notes.Checked;
            _Main.UpdateRecentIssues();

            //Save Notification settings
            Setting.Value.Notification_Messages = Notification_Messages.Checked;
            Setting.Value.Notification_Screen = Notification_ScreenComboBox.SelectedIndex;
            Setting.Value.Notification_Corner = Notification_CornerComboBox.SelectedIndex;
            Setting.Value.Notification_Direction = Notification_DirectionComboBox.SelectedIndex;
            Setting.Value.Notification_Frequency = (int)Notification_Frequency.Value;
            Setting.Value.Notification_Scale = (int)Notification_Scale.Value;
            Setting.Value.Notification_Sound = Notification_SoundComboBox.SelectedItem.ToString();
            Setting.Value.Notification_Color = Notification_Color.BackColor;
            Setting.Value.Notification_TextColor = Notification_TextColor.BackColor;

            //Save Log Settings
            Setting.Value.Log_WriteXlsx = Log_ExportXlsx.Checked;
            Setting.Value.Log_XlsxDestination = Log_ExcelLocation.Text;

            //Save Jira Settings
            if (Jira_Username.Text != Setting.Value.Jira_Username)
                new JiraLogin(Jira_Username.Text);

            Setting.Value.Jira_Link = Jira_Link.Text;
            Setting.Value.Jira_Username = Jira_Username.Text;
            Setting.Value.Jira_AutoCheck = Jira_AutoCheckBox.Checked;

            Setting.Save();

            SettingsHaveChanged = false;

            _Main.UpdateNewSettings();

            //TimeHandler._Main.RegisterHotkey(Setting.Value.Timer_QuickUse);
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SettingsHaveChanged)
            {
                if (MessageBox.Show("Are you sure you want to quit without saving?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Setting.Value.Notification_Screen = OriginalScreen;
                    Setting.Value.Notification_Corner = OriginalCorner;
                    Setting.Reload();
                }
            }
        }

        private void CloseWithoutSavingButton_Click(object sender, EventArgs e)
        {
            SettingsHaveChanged = false;
            Setting.Value.Notification_Screen = OriginalScreen;
            Setting.Value.Notification_Corner = OriginalCorner;
            this.Close();
        }

        #endregion

        #region Settings

        public void UpdateHotkey(HotKeyLayout hotkey)
        {
            if (FormLoaded)
            {
                Hotkey = hotkey;
                hotKeyLabel.Text = (hotkey.Ctrl ? "Ctrl+" : "") + (hotkey.Shift ? "Shift+" : "") + (hotkey.Alt ? "Alt+" : "") + hotkey.Key.ToString();
                SettingsHaveChanged = true;
                RegisterHotkey = true;
            }
        }

        private void Notification_ScreenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                Setting.Value.Notification_Screen = Notification_ScreenComboBox.SelectedIndex;
                TestToast();
                SettingsHaveChanged = true;
            }
        }

        private void Notification_CornerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                Setting.Value.Notification_Corner = Notification_CornerComboBox.SelectedIndex;
                TestToast();
                SettingsHaveChanged = true;
            }
        }

        private void Notification_DirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                TestToast();
                SettingsHaveChanged = true;
            }
        }

        private void Notification_SoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                PlayNotificationSound(Notification_SoundComboBox.SelectedItem.ToString());
                SettingsHaveChanged = true;
            }
        }

        private void Notification_Frequency_ValueChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
                if (!SawFrequencyWarning && Notification_Frequency.Value > 15)
                {
                    if (MessageBox.Show("Are you sure you want to set the frequency of this timer to more than 15 minutes?", "LA County", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        Notification_Frequency.Value = 15;
                    }
                    else
                    {
                        SawFrequencyWarning = true;
                    }
                }
            }
        }

        private void Timer_TestStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
                MessageBox.Show("A restart is required for this setting to be applied", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Timer_TotalColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Timer_TotalColor.BackColor = cd.Color;
        }

        private void Timer_CurrentColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Timer_CurrentColor.BackColor = cd.Color;
        }

        private void TestToast(string sound = "")
        {
            var animationMethod = FormAnimator.AnimationMethod.Slide;

            var animationDirection = Directions[Notification_DirectionComboBox.SelectedIndex];

            var toastNotification = new Notification("Test Notification", "This is just a test", 3, animationMethod, animationDirection, (int)Notification_Scale.Value);
            toastNotification.Show();

            if (sound != "")
                PlayNotificationSound(sound);
        }

        private static void PlayNotificationSound(string sound)
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Setting.Value.Log_XlsxDestination;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Log_ExcelLocation.Text = fbd.SelectedPath;
                }
            }
        }

        private void Log_ExportXlsx_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Log_ExcelLocation_TextChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            var soundsFolder = Path.Combine(Program.DataPath, "Sounds");

            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Sound File (*.wav)|*.wav";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FileNames.Length > 1)
                {
                    foreach (string s in openFile.FileNames)
                    {
                        File.Copy(s, Path.Combine(soundsFolder, Path.GetFileName(s)));
                    }
                }
                else
                    File.Copy(openFile.FileName, Path.Combine(soundsFolder, Path.GetFileName(openFile.FileName)));
            }

            var soundFolder = new DirectoryInfo(Path.Combine(Program.DataPath, "Sounds"));
            Notification_SoundComboBox.Items.Clear();
            foreach (var file in soundFolder.GetFiles())
            {
                Notification_SoundComboBox.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
            Notification_SoundComboBox.SelectedItem = Setting.Value.Notification_Sound;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                if (_Main != null)
                {
                    Timer_XPos.Text = _Main.Location.X.ToString();
                    Timer_YPos.Text = _Main.Location.Y.ToString();
                }
                else if (_main != null)
                {
                    Timer_XPos.Text = _main.Location.X.ToString();
                    Timer_YPos.Text = _main.Location.Y.ToString();
                }
                SettingsHaveChanged = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                Timer_XPos.Text = "100";
                Timer_YPos.Text = "75";
                SettingsHaveChanged = true;
                if (_Main != null)
                    _Main.Location = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
                else if (_main != null)
                    _main.Location = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
            }
        }

        private void Jira_Link_TextChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Jira_Username_TextChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
            if (Classes.Data.AdminControl.Control.View_Mode == Classes.Data.AdminControl.ViewMode.Advanced)
                updateFileButton.Visible = true;
        }

        private void Jira_AutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void updateFileButton_Click(object sender, EventArgs e)
        {
            new GenerateUpdateFile().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new JiraLogin(Jira_Username.Text);
        }

        private void Notification_TextColor_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                if (cd.Color != Notification_TextColor.BackColor)
                    SettingsHaveChanged = true;
                Notification_TextColor.BackColor = cd.Color;
            }
        }

        private void Notification_Color_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                if (cd.Color != Notification_Color.BackColor)
                    SettingsHaveChanged = true;
                Notification_Color.BackColor = cd.Color;
            }
        }

        private void Notification_Scale_ValueChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
                TestToast();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            if(!Program.CheckForInternetConnection())
            {
                MessageBox.Show("You have no internet connection");
                return;
            }
            string version = Program.getLatestVersion(wc);
            if ((File.Exists(Path.Combine(Program.DataPath, "CurrentVersion.json")) && Program.isNewer(Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version, version)) || Program.isNewer(FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion, Program.getLatestVersion(wc)))
            {
                if (MessageBox.Show("An update is avaailable, would you like to update now?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
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

        private void button7_Click(object sender, EventArgs e)
        {
            //new HotKeySetup(this, Hotkey).Show();
        }

        private void Timer_MaxRecentIssues_ValueChanged(object sender, EventArgs e)
        {
            if(FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Timer_Notes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Notification_Messages_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Notification_TextColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
