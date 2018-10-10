using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;
using System.IO.Compression;
using IssueTimeTracker.Properties;
using IssueTimeTracker.Classes;
using IssueTimeTracker.Forms.Basic_Forms;
using Renci.SshNet;
using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Forms.Basic_Forms.Themes;
using IssueTimeTracker.Classes.Helper;
using System.Net.Mail;

namespace IssueTimeTracker.Forms
{
    public partial class NewSettings : Form
    {
        public NewSettings()
        {
            InitializeComponent();
            InitMenuStrip();
        }

        #region Variables

        FormAnimator.AnimationDirection[] Directions = { FormAnimator.AnimationDirection.Up, FormAnimator.AnimationDirection.Down, FormAnimator.AnimationDirection.Left, FormAnimator.AnimationDirection.Right };

        bool SettingsHaveChanged = false;
        bool FormLoaded = false;
        bool RestartRequired = false;

        int OriginalScreen;
        int OriginalCorner;

        bool SawFrequencyWarning = false;

        HotKeyLayout Hotkey;
        bool RegisterHotkey = false;

        List<Theme> TempThemes;


        private ContextMenuStrip ThemeMenuOptions;

        #endregion

        private void settingPages_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = settingPages.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = settingPages.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Setting.Value.CurrentTheme.SelectedForeground);
                g.FillRectangle(new SolidBrush(Setting.Value.CurrentTheme.SelectedBackground), e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(Setting.Value.CurrentTheme.Foreground);
                g.FillRectangle(new SolidBrush(Setting.Value.CurrentTheme.Background), e.Bounds);
                //e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = _tabPage.Font;

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void NewSettings_Load(object sender, EventArgs e)
        {
            Setting.Reload();
            Title.Text = "Settings - Current Version: " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
            //Load timer settings
            //Timer_CurrentColor.BackColor = Setting.Value.Timer_CurrentTaskColor;
            Timer_XPos.Text = Setting.Value.Timer_StartLocation.X.ToString();
            Timer_YPos.Text = Setting.Value.Timer_StartLocation.Y.ToString();
            Timer_MaxRecentIssues.Value = Setting.Value.Timer_MaxRecentIssues;
            //Timer_Notes.Checked = Setting.Value.Timer_Notes;
            Timer_RoundUpMinutes.Value = Setting.Value.Timer_RoundUpMinutes;
            Timer_Opacity.Value = Setting.Value.Timer_Opacity * 100;
            Timer_Themes.Checked = Setting.Value.Timer_Themes;
            TempThemes = Setting.Value.Themes;
            if(TempThemes.Count == 0)
            {
                TempThemes.Add(Theme.LightTheme);
                TempThemes.Add(Theme.DarkTheme);
            }
            LoadThemeImages(TempThemes);
            //UpdateHotkey(Setting.Value.Timer_QuickUse);

            if (Classes.Data.AdminControl.Control.View_Mode == Classes.Data.AdminControl.ViewMode.Advanced)
                updateFileButton.Visible = true;

            //Load Notification settings
            OriginalScreen = Setting.Value.Notification_Screen;
            OriginalCorner = Setting.Value.Notification_Corner;
            Notification_ScreenComboBox.SelectedIndex = Setting.Value.Notification_Screen;
            Notification_CornerComboBox.SelectedIndex = Setting.Value.Notification_Corner;
            Notification_DirectionComboBox.SelectedIndex = Setting.Value.Notification_Direction;
            Notification_Frequency.Value = Setting.Value.Notification_Frequency;
            Notification_Scale.Value = Setting.Value.Notification_Scale;
            Notification_TextNotification.Checked = Setting.Value.Notification_TextNotification;
            Notification_PhoneNumber.Text = Setting.Value.Notification_PhoneNumber;

            foreach (var v in NotificationHandler.Carriers)
                Notification_Carrier.Items.Add(v.Key);

            Notification_Carrier.SelectedItem = Setting.Value.Notification_Carrier;

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
            switch(Setting.Value.Jira_Mode)
            {
                case Classes.JiraMode.Nothing:
                    Jira_Mode.SelectedIndex = 0;
                    break;
                case Classes.JiraMode.InApplication:
                    Jira_Mode.SelectedIndex = 1;
                    break;
                case Classes.JiraMode.WebBrowser:
                    Jira_Mode.SelectedIndex = 2;
                    break;
            }
            BindingList<SLA> SLAlist = new BindingList<SLA>(Setting.Value.Jira_SLAs);
            jiraSLAGrid.DataSource = SLAlist;

            if (Setting.Value.Notification_WindowsNotification)
                Jira_WindowsNotification.SelectedIndex = 1;
            else
                Jira_WindowsNotification.SelectedIndex = 0;

            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(TextBox), typeof(ComboBox), typeof(CheckBox), typeof(TabPage), typeof(NumericUpDown), typeof(Panel), typeof(GroupBox), typeof(DataGridView) });

            FormLoaded = true;
        }

        #region Theme Stuff

        private void InitMenuStrip()
        {
            var NewMenuItem = new ToolStripMenuItem { Text = "Add New", BackColor = Color.White };
            NewMenuItem.Click += NewMenuItem_Click;
            var EditMenuItem = new ToolStripMenuItem { Text = "Edit", BackColor = Color.White };
            EditMenuItem.Click += EditMenuItem_Click;
            var DuplicateMenuItem = new ToolStripMenuItem { Text = "Duplicate", BackColor = Color.White };
            DuplicateMenuItem.Click += DuplicateMenuItem_Click;
            var ImportMenuItem = new ToolStripMenuItem { Text = "Import", BackColor = Color.White };
            ImportMenuItem.Click += ImportMenuItem_Click;
            var ExportMenuItem = new ToolStripMenuItem { Text = "Export", BackColor = Color.White };
            ExportMenuItem.Click += ExportMenuItem_Click;
            var UploadMenuItem = new ToolStripMenuItem { Text = "Share", BackColor = Color.White, Tag = "Upload" };
            UploadMenuItem.Click += UploadMenuItem_Click;
            var DeleteMenuItem = new ToolStripMenuItem { Text = "Delete", BackColor = Color.White };
            DeleteMenuItem.Click += DeleteMenuItem_Click;
            ThemeMenuOptions = new ContextMenuStrip();
            ThemeMenuOptions.Items.AddRange(new ToolStripItem[] { NewMenuItem, EditMenuItem, DuplicateMenuItem, ImportMenuItem, ExportMenuItem, UploadMenuItem, DeleteMenuItem });
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            using (ThemeCreator tc = new ThemeCreator())
            {
                if(tc.ShowDialog() == DialogResult.OK)
                {
                    int id = TempThemes.Count;
                    Theme t = tc.Theme;
                    t.ID = id;
                    TempThemes.Add(t);
                    SettingsHaveChanged = true;
                }
            }

            LoadThemeImages(TempThemes);
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            using (ThemeCreator tc = new ThemeCreator((Theme)SelectedItem.Tag))
            {
                if (tc.ShowDialog() == DialogResult.OK)
                {
                    SelectedItem.Tag = tc.Theme;
                    for (int i = 0; i < TempThemes.Count; i++)
                        if (TempThemes[i].ID == tc.Theme.ID)
                            TempThemes[i] = tc.Theme;
                    SettingsHaveChanged = true;
                }
            }

            LoadThemeImages(TempThemes);
        }

        private string incrementName(string name)
        {
            bool pass = false;
            int num = 1;
            string tempname = name;
            while(!pass)
            {
                tempname = name + " (" + num + ")";
                bool eq = false;
                foreach (Theme t in TempThemes)
                {
                    if (t.Name == tempname)
                        eq = true;
                }
                if (eq)
                    num++;
                else
                    pass = true;
            }
            return tempname;
        }

        private void DuplicateMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null || SelectedItem.Tag == null)
                return;
            Theme d = (Theme)SelectedItem.Tag;
            Theme t = new Theme()
            {
                ID = TempThemes.Count,
                Name = incrementName(d.Name),
                Background = d.Background,
                Foreground = d.Foreground,
                MouseDown = d.MouseDown,
                MouseOver = d.MouseOver,
                OtherForeground = d.OtherForeground,
                Selected = d.Selected
            };

            TempThemes.Add(t);

            SettingsHaveChanged = true;
            LoadThemeImages(TempThemes);
        }

        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Issue Time Tracker Theme|*.json";
            openFile.Title = "Load Theme";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Theme t = Serializer<Theme>.LoadFromJSONFile(openFile.FileName);
                TempThemes.Add(t);
                LoadThemeImages(TempThemes);
                SettingsHaveChanged = true;
            }
        }

        private void ExportMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null || SelectedItem.Tag == null)
                return;
            Theme theme = (Theme)SelectedItem.Tag;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Issue Time Tracker Theme|*.json";
            saveDialog.Title = "Export Theme";
            
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName))
                    File.Delete(saveDialog.FileName);
                Serializer<Theme>.WriteToJSONFile(theme, saveDialog.FileName);
            }
        }

        private void UploadMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null || SelectedItem.Tag == null)
                return;
            Theme theme = (Theme)SelectedItem.Tag;
            theme.UploadedBy = (Setting.Value.Jira_Username != null && Setting.Value.Jira_Username != "" ? Setting.Value.Jira_Username : Environment.UserName);

            var path = Path.Combine(Program.DataPath, theme.Name + ".json");
            if (File.Exists(path))
                File.Delete(path);
            Serializer<Theme>.WriteToJSONFile(theme, path);
            try
            {
                /*using (SftpClient client = new SftpClient("server237.web-hosting.com", 21098, AdminControl.Control.Domain_Username, AdminControl.Control.Domain_Password))
                {
                    client.Connect();
                    client.ChangeDirectory("/home/csmioyik/public_html/IssueTimeTracker/Themes");
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        client.BufferSize = 4 * 1024;
                        client.UploadFile(fs, Path.GetFileName(path));
                    }
                }*/
                WebClient Client = new WebClient();

                Client.Headers.Add("Content-Type", "binary/octet-stream");

                byte[] result = Client.UploadFile(MainData.Instance.Domain + "IssueTimeTracker/Themes/index.php", "POST", path);

                string s = Encoding.UTF8.GetString(result, 0, result.Length);
                MessageBox.Show("Shared Successfully");
            }
            catch (Exception ae)
            {
                MessageBox.Show("Upload failed - " + ae.Message);
            }
            if (File.Exists(path))
                File.Delete(path);
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TempThemes.Count; i++)
                TempThemes.Remove((Theme)SelectedItem.Tag);

            LoadThemeImages(TempThemes);
            SettingsHaveChanged = true;
        }

        private ListViewItem lastItemChecked;

        private void themeListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != themeListView.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastItemChecked.Checked = false;
            }
            // store current item
            lastItemChecked = themeListView.Items[e.Index];
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (ThemeBrowser tb = new ThemeBrowser())
            {
                if (tb.ShowDialog() == DialogResult.OK)
                {
                    List<Theme> themes = tb.SelectedThemes;
                    for (int i = 0; i < themes.Count; i++)
                    {
                        themes[i].ID = TempThemes.Count + i;
                    }
                    if (themes.Count > 0)
                        SettingsHaveChanged = true;
                    TempThemes.AddRange(themes);
                }
            }

            LoadThemeImages(TempThemes);
        }

        private ListViewItem SelectedItem;

        private void themeListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((themeListView.FocusedItem != null && themeListView.FocusedItem.Bounds.Contains(e.Location)) || (themeListView.SelectedItems != null && themeListView.SelectedItems.Count == 1 && themeListView.SelectedItems[0].Bounds.Contains(e.Location)))
                {
                    ThemeMenuOptions.Show(Cursor.Position);
                    Theme t = (Theme)themeListView.FocusedItem.Tag;
                    if (t.ID != 0 && t.ID != 1)
                    {
                        ThemeMenuOptions.Items[1].Visible = true;
                        ThemeMenuOptions.Items[5].Visible = true;
                        ThemeMenuOptions.Items[6].Visible = true;
                    }
                    else
                    {
                        ThemeMenuOptions.Items[1].Visible = false;
                        ThemeMenuOptions.Items[5].Visible = false;
                        ThemeMenuOptions.Items[6].Visible = false;
                    }
                    ThemeMenuOptions.Items[2].Visible = true;
                    ThemeMenuOptions.Items[4].Visible = true;
                    SelectedItem = themeListView.FocusedItem;
                }
                else
                {
                    ThemeMenuOptions.Show(Cursor.Position);
                    ThemeMenuOptions.Items[1].Visible = false;
                    ThemeMenuOptions.Items[2].Visible = false;
                    ThemeMenuOptions.Items[4].Visible = false;
                    ThemeMenuOptions.Items[5].Visible = false;
                    ThemeMenuOptions.Items[6].Visible = false;
                    SelectedItem = null;
                }
            }
        }

        private void LoadThemeImages(List<Theme> themes)
        {
            if (themeList == null)
                themeList = new ImageList();
            themeList.Images.Clear();
            themeListView.Items.Clear();
            foreach (Theme t in themes)
            {
                themeList.Images.Add(t.Name, t.Theme2Image());
            }
            themeList.ImageSize = new Size(64, 18);
            themeListView.SmallImageList = themeList;
            themeListView.View = View.SmallIcon;
            themeListView.CheckBoxes = true;
            foreach (Theme t in themes)
            {
                ListViewItem lv = new ListViewItem(t.Name, t.Name) { Tag = t, Checked = (t.ID == Setting.Value.CurrentTheme.ID) };
                themeListView.Items.Add(lv);
            }
        }

        #endregion

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                Timer_XPos.Text = "300";
                Timer_YPos.Text = "75";
                SettingsHaveChanged = true;
                if (StaticHandler._Main != null)
                    StaticHandler._Main.Location = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
                if (StaticHandler._ThemedMain != null)
                    StaticHandler._ThemedMain.Location = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                if (StaticHandler._Main != null)
                {
                    Timer_XPos.Text = StaticHandler._Main.Location.X.ToString();
                    Timer_YPos.Text = StaticHandler._Main.Location.Y.ToString();
                }
                if (StaticHandler._ThemedMain != null)
                {
                    Timer_XPos.Text = StaticHandler._ThemedMain.Location.X.ToString();
                    Timer_YPos.Text = StaticHandler._ThemedMain.Location.Y.ToString();
                }
                SettingsHaveChanged = true;
            }
        }

        private void Timer_MaxRecentIssues_ValueChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void updateFileButton_Click(object sender, EventArgs e)
        {
            new GenerateUpdateFile().Show();
        }

        private void Timer_TotalColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
        }

        private void Timer_Notes_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
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

        private void button5_Click(object sender, EventArgs e)
        {
            new JiraLogin(Jira_Username.Text).Show();
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

        private void Log_ExcelLocation_TextChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Log_ExportXlsx_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Notification_Messages_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
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

        private void Notification_Frequency_ValueChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
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

        private void Notification_DirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
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

        private void Notification_ScreenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                Setting.Value.Notification_Screen = Notification_ScreenComboBox.SelectedIndex;
                TestToast();
                SettingsHaveChanged = true;
            }
        }

        private void TestToast(string sound = "")
        {
            if (Jira_WindowsNotification.SelectedIndex == 1)
            {
                if (StaticHandler._Main != null)
                {
                    if (StaticHandler._Main.trayIcon == null)
                    {
                        StaticHandler._Main.trayIcon = new NotifyIcon()
                        {
                            Icon = Resources.closed,
                            Visible = true
                        };
                    }
                    StaticHandler._Main.trayIcon.BalloonTipTitle = "Test Notification";
                    StaticHandler._Main.trayIcon.BalloonTipText = "This is just a test";
                    StaticHandler._Main.trayIcon.ShowBalloonTip(3);
                }
                else if (StaticHandler._ThemedMain != null)
                {
                    if (NotificationHandler.trayIcon == null)
                    {
                        NotificationHandler.Initialize();
                    }
                    NotificationHandler.trayIcon.BalloonTipTitle = "Test Notification";
                    NotificationHandler.trayIcon.BalloonTipText = "This is just a test";
                    NotificationHandler.trayIcon.ShowBalloonTip(3);
                }
            }
            else
            {

                var animationMethod = FormAnimator.AnimationMethod.Slide;

                var animationDirection = Directions[Notification_DirectionComboBox.SelectedIndex];

                var toastNotification = new Notification("Test Notification", "This is just a test", 3, animationMethod, animationDirection, (int)Notification_Scale.Value);
                toastNotification.Show();

                //if (sound != "")
                //    PlayNotificationSound(sound);
            }
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void CloseWithoutSavingButton_Click(object sender, EventArgs e)
        {
            SettingsHaveChanged = false;
            RestartRequired = false;
            Setting.Value.Notification_Screen = OriginalScreen;
            Setting.Value.Notification_Corner = OriginalCorner;
            this.Close();
        }

        private void SaveSettings()
        {
            //Save Timer Settings
            //Setting.Value.Timer_CurrentTaskColor = Timer_CurrentColor.BackColor;
            Setting.Value.Timer_StartLocation = new System.Drawing.Point(int.Parse(Timer_XPos.Text), int.Parse(Timer_YPos.Text));
            Setting.Value.Timer_MaxRecentIssues = (int)Timer_MaxRecentIssues.Value;
            //Setting.Value.Timer_Notes = Timer_Notes.Checked;
            Setting.Value.Timer_RoundUpMinutes = (int)Timer_RoundUpMinutes.Value;
            Setting.Value.Timer_Opacity = (Timer_Opacity.Value / 100);
            
            if (StaticHandler._Main != null)
            {
                StaticHandler._Main.AddExtraTaskTime(0.0f);
                StaticHandler._Main.UpdateRecentIssues();
            }
            if (StaticHandler._ThemedMain != null)
            {
                StaticHandler._ThemedMain.AddExtraTaskTime(0.0f);
                StaticHandler._ThemedMain.UpdateRecentIssues();
            }

            //Themes
            Setting.Value.Timer_Themes = Timer_Themes.Checked;
            for (int i = 0; i < TempThemes.Count; i++)
                TempThemes[i].ID = i;
            Setting.Value.Themes = TempThemes;
            Theme cur = Theme.LightTheme;
            foreach (ListViewItem l in themeListView.CheckedItems)
                if (l.Tag != null)
                    cur = (Theme)l.Tag;
            Setting.Value.CurrentTheme = cur;


            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(TextBox), typeof(ComboBox), typeof(CheckBox), typeof(TabPage), typeof(NumericUpDown), typeof(Panel) });

            //Save Notification settings
            Setting.Value.Notification_Screen = Notification_ScreenComboBox.SelectedIndex;
            Setting.Value.Notification_Corner = Notification_CornerComboBox.SelectedIndex;
            Setting.Value.Notification_Direction = Notification_DirectionComboBox.SelectedIndex;
            Setting.Value.Notification_Frequency = (int)Notification_Frequency.Value;
            Setting.Value.Notification_Scale = (int)Notification_Scale.Value;
            Setting.Value.Notification_Sound = Notification_SoundComboBox.SelectedItem.ToString();
            Setting.Value.Notification_WindowsNotification = (Jira_WindowsNotification.SelectedIndex == 1);
            Setting.Value.Notification_TextNotification = Notification_TextNotification.Checked;
            Setting.Value.Notification_PhoneNumber = Notification_PhoneNumber.Text;
            if (Notification_Carrier.SelectedItem != null)
                Setting.Value.Notification_Carrier = Notification_Carrier.SelectedItem.ToString();

            //Save Log Settings
            Setting.Value.Log_WriteXlsx = Log_ExportXlsx.Checked;
            Setting.Value.Log_XlsxDestination = Log_ExcelLocation.Text;

            //Save Jira Settings
            if (Jira_Username.Text != Setting.Value.Jira_Username)
                new JiraLogin(Jira_Username.Text);

            if (!Jira_Link.Text.EndsWith("/"))
                Jira_Link.Text += "/";
            Setting.Value.Jira_Link = Jira_Link.Text;
            Setting.Value.Jira_Username = Jira_Username.Text;
            Setting.Value.Jira_AutoCheck = Jira_AutoCheckBox.Checked;
            if (Setting.Value.Jira_AutoCheck)
                Setting.Value.General_JiraAccess = true;
            switch (Jira_Mode.SelectedIndex)
            {
                case 0:
                    Setting.Value.Jira_Mode = Classes.JiraMode.Nothing;
                    break;
                case 1:
                    Setting.Value.Jira_Mode = Classes.JiraMode.InApplication;
                    break;
                case 2:
                    Setting.Value.Jira_Mode = Classes.JiraMode.WebBrowser;
                    break;
            }
            Setting.Value.Jira_SLAs = new List<SLA>((BindingList<SLA>)jiraSLAGrid.DataSource);

            Setting.Save();

            SettingsHaveChanged = false;

            if (StaticHandler._Main != null)
                StaticHandler._Main.UpdateNewSettings();
            if (StaticHandler._ThemedMain != null)
                StaticHandler._ThemedMain.UpdateNewSettings();
            //TimeHandler._Main.RegisterHotkey(Setting.Value.Timer_QuickUse);
        }

        private void NewSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SettingsHaveChanged || TempThemes.Count != Setting.Value.Themes.Count || 
                (themeListView.SelectedItems != null && themeListView.SelectedItems.Count != 0 && ((Theme)themeListView.SelectedItems[0].Tag).ID != Setting.Value.CurrentTheme.ID))
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
            if(RestartRequired)
            {
                if (StaticHandler._Main != null)
                {
                    Process.Start(Application.ExecutablePath);
                    StaticHandler._Main.Close();
                }
                if (StaticHandler._ThemedMain != null)
                {
                    Process.Start(Application.ExecutablePath);
                    StaticHandler._ThemedMain.Close();
                }
            }
        }

        public void UpdateHotkey(HotKeyLayout hotkey)
        {
            if (FormLoaded)
            {
                Hotkey = hotkey;
                //hotKeyLabel.Text = (hotkey.Ctrl ? "Ctrl+" : "") + (hotkey.Shift ? "Shift+" : "") + (hotkey.Alt ? "Alt+" : "") + hotkey.Key.ToString();
                SettingsHaveChanged = true;
                RegisterHotkey = true;
            }
        }

        private void Timer_RoundUpMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Issue Time Tracker Backup|*.ittb";
            saveDialog.Title = "Create Backup";

            if (SettingsHaveChanged && MessageBox.Show("Would you like to save the settings before running the backup?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SaveSettings();


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

            files.Add(new FileInfo(Path.Combine(Program.DataPath, "Settings.xml")));
            files.Add(new FileInfo(Path.Combine(Program.DataPath, "Data.xml")));
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
                if(File.Exists(l))
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

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Issue Time Tracker Backup|*.ittb";
            openFile.Title = "Load Backup";
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LoadBackup(openFile.FileName);
            }
            Setting.Load();
        }

        private void LoadBackup(string loc)
        {
            int failCount = 0;
            using (ZipArchive archive = ZipFile.OpenRead(loc))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    try
                    {
                        string path = Path.Combine(Program.DataPath, entry.FullName);
                        if (!Directory.Exists(Path.GetDirectoryName(path)))
                            Directory.CreateDirectory(Path.GetDirectoryName(path));
                        entry.ExtractToFile(path, true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        failCount++;
                    }
                }
            }
            if (failCount == 0)
                MessageBox.Show("Successfully restored backup", "Success");
            else
                MessageBox.Show(failCount + " files failed to restore. ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the pin?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Setting.Value.Jira_EncryptedPassword = "";
                Setting.Value.Jira_SavePassword = false;
                if (!SettingsHaveChanged)
                    Setting.Save();
            }
        }

        private void Jira_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

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

        private void Jira_WindowsNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
                TestToast();
            }

            if (Jira_WindowsNotification.SelectedIndex == 0)
            {
                Notification_ScreenComboBox.Enabled = true;
                Notification_CornerComboBox.Enabled = true;
                Notification_DirectionComboBox.Enabled = true;
                Notification_SoundComboBox.Enabled = true;
                //Notification_Frequency.Enabled = true;
                Notification_Scale.Enabled = true;
            }
            else if (Jira_WindowsNotification.SelectedIndex == 1)
            {
                Notification_ScreenComboBox.Enabled = false;
                Notification_CornerComboBox.Enabled = false;
                Notification_DirectionComboBox.Enabled = false;
                Notification_SoundComboBox.Enabled = false;
                //Notification_Frequency.Enabled = false;
                Notification_Scale.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(Program.DataPath);
        }

        bool autoChange = false;

        private void Timer_Themes_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded && !autoChange)
            {
                if (MessageBox.Show("A restart is required to change this setting once you save and close this form. Do you want to continue to update this setting?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestartRequired = true;
                    SettingsHaveChanged = true;
                }
                else
                {
                    RestartRequired = false;
                    SettingsHaveChanged = false;
                    autoChange = true;
                    Timer_Themes.Checked = !Timer_Themes.Checked;
                }
            }
            autoChange = false;
        }

        private bool drag = false;
        private Point start_point = new Point(0, 0);

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Notification_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Notification_Carrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void Notification_TextNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                SettingsHaveChanged = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(Notification_PhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else if (Notification_Carrier.SelectedItem == null || Notification_Carrier.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Invalid Carrier");
            }

            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadString(MainData.Instance.Domain + string.Format("IssueTimeTracker/PostText.php?email={0}&subject={1}&msg={2}",
                    (Notification_PhoneNumber.Text + NotificationHandler.Carriers[Notification_Carrier.SelectedItem.ToString()]), "Notification", "This is a test Notification"));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Failed to process: " + ea.Message);
            }
            webClient.Dispose();
        }
    }
}
