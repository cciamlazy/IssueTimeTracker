using adobe_color_picker_clone_part_1;
using IssueTimeTracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms
{
    public partial class ThemeCreator : Form
    {
        private Theme _theme = new Theme();
        public Theme Theme { get { return _theme; } private set { _theme = value; } }

        frmColorPicker.eDrawStyle drawStyle = frmColorPicker.eDrawStyle.Hue;

        public ThemeCreator(Theme theme = null)
        {
            InitializeComponent();

            if (theme != null)
            {
                this.Text = "Theme Editor";
                Theme = theme;
                ThemeName.Text = theme.Name;
                ReloadColors();
            }

            ReloadColors();
            checkBox1.Checked = Setting.Value.PreviewTheme;

            this.Opacity = Convert.ToDouble(Setting.Value.Timer_Opacity);
            
        }

        ListViewItem i1;
        ListViewItem i2;
        ListViewItem i3;
        ListViewItem i4;
        ListViewItem i5;
        ListViewItem i6;
        ListViewItem i7;
        ListViewItem i8;

        private void ReloadColors()
        {
            if (Theme == null)
                return;

            if (themeList == null)
                themeList = new ImageList();
            themeList.Images.Clear();
            themeListView.Items.Clear();
            
            if (Theme.Background != null)
                themeList.Images.Add("Background", Color2Bitmap(Theme.Background, themeList.ImageSize));
            if (Theme.Foreground != null)
                themeList.Images.Add("Foreground (Text)", Color2Bitmap(Theme.Foreground, themeList.ImageSize));
            if (Theme.OtherForeground != null)
                themeList.Images.Add("Other Foreground", Color2Bitmap(Theme.OtherForeground, themeList.ImageSize));
            if (Theme.MouseDown != null)
                themeList.Images.Add("Mouse Down", Color2Bitmap(Theme.MouseDown, themeList.ImageSize));
            if (Theme.MouseOver != null)
                themeList.Images.Add("Mouse Over", Color2Bitmap(Theme.MouseOver, themeList.ImageSize));
            if (Theme.Selected != null)
                themeList.Images.Add("Progress", Color2Bitmap(Theme.Selected, themeList.ImageSize));
            if (Theme.SelectedBackground != null)
                themeList.Images.Add("Selected Background", Color2Bitmap(Theme.SelectedBackground, themeList.ImageSize));
            if (Theme.SelectedForeground != null)
                themeList.Images.Add("Selected Foreground", Color2Bitmap(Theme.SelectedForeground, themeList.ImageSize));


            themeListView.SmallImageList = themeList;
            themeListView.View = View.SmallIcon;
            themeListView.CheckBoxes = false;

            i1 = new ListViewItem("Background", "Background") { ImageIndex = 0 };
            i2 = new ListViewItem("Foreground (Text)", "Foreground") { ImageIndex = 1 };
            i3 = new ListViewItem("Other Foreground", "OtherForeground") { ImageIndex = 2 };
            i4 = new ListViewItem("Mouse Down", "MouseDown") { ImageIndex = 3 };
            i5 = new ListViewItem("Mouse Over", "MouseOver") { ImageIndex = 4 };
            i6 = new ListViewItem("Progress", "Selected") { ImageIndex = 5 };
            i7 = new ListViewItem("Selected Background", "SelectedBackground") { ImageIndex = 6 };
            i8 = new ListViewItem("Selected Foreground", "SelectedForeground") { ImageIndex = 7 };
            themeListView.Items.Add(i1);
            themeListView.Items.Add(i2);
            themeListView.Items.Add(i3);
            themeListView.Items.Add(i4);
            themeListView.Items.Add(i5);
            themeListView.Items.Add(i6);
            themeListView.Items.Add(i7);
            themeListView.Items.Add(i8);

            Theme.ApplyTheme(PreviewPanel, new Type[] { typeof(Label), typeof(Button), typeof(CircularProgressBar.CircularProgressBar), typeof(ComboBox), typeof(CheckBox) });
            Global_Hour.ForeColor = Theme.OtherForeground;
            Global_HourColon.ForeColor = Theme.OtherForeground;
            Task_Hour.ForeColor = Theme.OtherForeground;
            Task_HourColon.ForeColor = Theme.OtherForeground;
            Task_Minute.ForeColor = Theme.OtherForeground;
            Task_MinuteColon.ForeColor = Theme.OtherForeground;
        }

        public Bitmap Color2Bitmap(Color c, Size size)
        {
            Bitmap img = new Bitmap(size.Width, size.Height);
            using (Graphics gfx = Graphics.FromImage(img))
            {
                using (SolidBrush brush = new SolidBrush(c))
                {
                    gfx.FillRectangle(brush, 0, 0, size.Width, size.Height);
                }

                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    gfx.FillRectangle(brush, new Rectangle(0, 0, size.Width, 1));
                    gfx.FillRectangle(brush, new Rectangle(size.Width - 1, 0, 1, size.Height));
                    gfx.FillRectangle(brush, new Rectangle(0, size.Height - 1, size.Width, 1));
                    gfx.FillRectangle(brush, new Rectangle(0, 0, 1, size.Height));
                }
            }
            return img;
        }

        private Color ColorPicker(Color color)
        {
            Color newColor = Color.Transparent;
            using (frmColorPicker ColorDialog = new frmColorPicker(color))
            {
                ColorDialog.DrawStyle = drawStyle;
                if (ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    //	Display the color
                    newColor = ColorDialog.PrimaryColor;

                    drawStyle = ColorDialog.DrawStyle;
                }
            }

            return newColor;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ThemeName.Text == "")
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (ThemeName.Text.Contains(c))
                {
                    MessageBox.Show("Invalid character in name - " + c, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Theme.CreatedBy = (Setting.Value.Jira_Username != null && Setting.Value.Jira_Username != "" ? Setting.Value.Jira_Username : Environment.UserName);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Background_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.Background != null ? Theme.Background : Color.White));
            if(color != Color.Transparent)
                Theme.Background = color;
            ReloadColors();
        }

        private void Foreground_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.Foreground != null ? Theme.Foreground : Color.White));
            if (color != Color.Transparent)
                Theme.Foreground = color;
            ReloadColors();
        }

        private void ForegroundOther_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.OtherForeground != null ? Theme.OtherForeground : Color.White));
            if (color != Color.Transparent)
                Theme.OtherForeground = color;
            ReloadColors();
        }

        private void MouseOver_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.MouseOver != null ? Theme.MouseOver : Color.White));
            if (color != Color.Transparent)
                Theme.MouseOver = color;
            ReloadColors();
        }

        private void MouseDown_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.MouseDown != null ? Theme.MouseDown : Color.White));
            if (color != Color.Transparent)
                Theme.MouseDown = color;
            ReloadColors();
        }

        private void Selected_Click(object sender, EventArgs e)
        {
            Color color = ColorPicker((Theme.Selected != null ? Theme.Selected : Color.White));
            if (color != Color.Transparent)
                Theme.Selected = color;
            ReloadColors();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            Theme.Name = ThemeName.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.Size = new Size(225, 275);
                PreviewPanel.Visible = false;
            }
            else
            {
                this.Size = new Size(450, 275);
                PreviewPanel.Visible = true;
            }
            Setting.Value.PreviewTheme = checkBox1.Checked;
            Setting.Save();
        }

        private void ThemeCreator_Load(object sender, EventArgs e)
        {
        }

        private void themeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = themeListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                Color prev = Color.White;
                if (themeList != null && themeList.Images.Count > item.Index)
                {
                    Bitmap b = (Bitmap)themeList.Images[item.Index];
                    prev = b.GetPixel(b.Width / 2, b.Height / 2);
                }
                Color color = ColorPicker(prev);
                if (color != Color.Transparent)
                {
                    switch (item.Index)
                    {
                        case 0:
                            Theme.Background = color;
                            break;
                        case 1:
                            Theme.Foreground = color;
                            break;
                        case 2:
                            Theme.OtherForeground = color;
                            break;
                        case 3:
                            Theme.MouseDown = color;
                            break;
                        case 4:
                            Theme.MouseOver = color;
                            break;
                        case 5:
                            Theme.Selected = color;
                            break;
                        case 6:
                            Theme.SelectedBackground = color;
                            break;
                        case 7:
                            Theme.SelectedForeground = color;
                            break;
                    }
                }
                ReloadColors();
            }
            else
            {
                this.themeListView.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }
    }
}
