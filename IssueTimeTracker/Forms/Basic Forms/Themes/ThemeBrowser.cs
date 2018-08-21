using IssueTimeTracker.Classes;
using IssueTimeTracker.Classes.Data;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms.Themes
{
    public partial class ThemeBrowser : Form
    {
        public ThemeBrowser()
        {
            InitializeComponent();
            InitMenuStrip();
            LoadThemeImages(GetOnlineThemes());
            this.Opacity = Convert.ToDouble(Setting.Value.Timer_Opacity);
        }

        public List<Theme> GetOnlineThemes()
        {
            var url = MainData.Instance.Domain + "IssueTimeTracker/Themes/";
            WebClient webClient = new WebClient();
            string s = webClient.DownloadString(url);
            string[] files = s.Split(new string[] { "<br />" }, StringSplitOptions.RemoveEmptyEntries);

            List<Theme> themes = new List<Theme>();
            foreach(string f in files)
            {

                themes.Add(Serializer<Theme>.JSONStringToObject(webClient.DownloadString(url + f)));
            }
            return themes;
        }

        private ContextMenuStrip ThemeMenuOptions;

        private void InitMenuStrip()
        {
            
            var DeleteMenuItem = new ToolStripMenuItem { Text = "Delete", BackColor = Color.White };
            DeleteMenuItem.Click += DeleteMenuItem_Click;
            ThemeMenuOptions = new ContextMenuStrip();
            ThemeMenuOptions.Items.AddRange(new ToolStripItem[] { DeleteMenuItem });
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            Theme t = (Theme)SelectedItem.Tag;
            try
            {
                using (SftpClient client = new SftpClient("server237.web-hosting.com", 21098, AdminControl.Control.Domain_Username, AdminControl.Control.Domain_Password))
                {
                    client.Connect();
                    client.ChangeDirectory("/home/csmioyik/public_html/IssueTimeTracker/Themes/");
                    client.DeleteFile(t.Name + ".json");
                }
                MessageBox.Show("Delete completed");
            }
            catch (Exception ae)
            {
                MessageBox.Show("Delete failed - " + ae.Message);
            }

            LoadThemeImages(GetOnlineThemes());
        }

        private List<Theme> onlineThemes = new List<Theme>();
        public List<Theme> SelectedThemes { get; private set; } = new List<Theme>();

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
                ListViewItem lv = new ListViewItem(t.Name, t.Name) { Tag = t };
                themeListView.Items.Add(lv);
            }
        }

        private void CancelThemeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (themeListView.CheckedItems == null || themeListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("No themes are checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ListViewItem v in themeListView.CheckedItems)
            {
                SelectedThemes.Add((Theme)v.Tag);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void themeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themeListView.FocusedItem == null)
                return;
            Theme theme = (Theme)themeListView.FocusedItem.Tag;
            theme.ApplyTheme(PreviewPanel, new Type[] { typeof(Label), typeof(Button), typeof(CircularProgressBar.CircularProgressBar), typeof(ComboBox), typeof(CheckBox) });
            Global_Hour.ForeColor = theme.OtherForeground;
            Global_HourColon.ForeColor = theme.OtherForeground;
            Task_Hour.ForeColor = theme.OtherForeground;
            Task_HourColon.ForeColor = theme.OtherForeground;
            Task_Minute.ForeColor = theme.OtherForeground;
            Task_MinuteColon.ForeColor = theme.OtherForeground;
        }

        private ListViewItem SelectedItem;

        private void themeListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (AdminControl.Control.View_Mode == AdminControl.ViewMode.Advanced && ((themeListView.FocusedItem != null && themeListView.FocusedItem.Bounds.Contains(e.Location)) || (themeListView.SelectedItems != null && themeListView.SelectedItems.Count == 1 && themeListView.SelectedItems[0].Bounds.Contains(e.Location))))
                {
                    ThemeMenuOptions.Show(Cursor.Position);
                    SelectedItem = themeListView.FocusedItem;
                }
                else
                {
                    SelectedItem = null;
                }
            }
        }
    }
}
