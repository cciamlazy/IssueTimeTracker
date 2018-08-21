using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Classes
{
    public class Theme
    {
        public static Theme LightTheme = new Theme() { ID = 0, Name = "Light", Background = Color.White, Foreground = Color.Black, OtherForeground = Color.Gray, MouseDown = Color.Silver, MouseOver = Color.FromArgb(224, 224, 224), Selected = Color.FromArgb(0, 122, 204), SelectedBackground = Color.FromArgb(0, 122, 204), SelectedForeground = Color.Black };
        public static Theme DarkTheme = new Theme() { ID = 1, Name = "Dark", Background = Color.FromArgb(45, 45, 48), Foreground = Color.White, OtherForeground = Color.Gray, MouseDown = Color.FromArgb(79, 79, 82), MouseOver = Color.FromArgb(62, 62, 65), Selected = Color.FromArgb(0, 122, 204), SelectedBackground = Color.FromArgb(0, 122, 204), SelectedForeground = Color.White };

        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public string UploadedBy { get; set; }
        public string Name { get; set; }
        public Color Background { get; set; }
        public Color Foreground { get; set; }
        public Color OtherForeground { get; set; }
        public Color MouseOver { get; set; }
        public Color MouseDown { get; set; }
        public Color Selected { get; set; }
        public Color SelectedBackground { get; set; }
        public Color SelectedForeground { get; set; }


        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public List<ToolStripMenuItem> GetMenuItems(MenuStrip menuStrip)
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip.Items)
            {
                allItems.Add(toolItem);
                //add sub items
                allItems.AddRange(GetItems(toolItem));
            }
            return allItems;
        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }

        public void ApplyTheme(Control control, Type[] types, MenuStrip menu = null)
        {
            control.SuspendLayout();

            List<Control> all = new List<Control>();

            foreach (Type t in types)
            {
                all.AddRange(GetAll(control, t).ToList());
            }
            
            if (menu != null)
            {
                List<ToolStripMenuItem> menuItems = GetMenuItems(menu);
                foreach (ToolStripMenuItem t in menuItems)
                {
                    t.BackColor = Background;
                    t.ForeColor = Foreground;
                    t.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    t.MouseLeave += T_MouseLeave;
                    t.MouseEnter += T_MouseEnter;
                }
            }

            foreach (Control c in all)
            {
                //if(c.BackColor != Color.Transparent)
                if (c.Tag != null && c.Tag.ToString() == "Foreground")
                    c.BackColor = Foreground;
                else
                    c.BackColor = Background;
                if (c.Tag != null && c.Tag.ToString() == "OtherForeground")
                    c.ForeColor = OtherForeground;
                else
                    c.ForeColor = Foreground;
                

                if (c.GetType() == typeof(Button) && (c.Tag == null || c.Tag.ToString() != "NoTheme"))
                {
                    Button b = (Button)c;
                    b.FlatAppearance.MouseDownBackColor = MouseDown;
                    b.FlatAppearance.MouseOverBackColor = MouseOver;
                }

                if (c.GetType() == typeof(CircularProgressBar.CircularProgressBar))
                {
                    CircularProgressBar.CircularProgressBar bar = (CircularProgressBar.CircularProgressBar)c;
                    bar.OuterColor = OtherForeground;
                    bar.ProgressColor = Selected;
                }
            }

            control.BackColor = Background;
            //control.ForeColor = Invert(Foreground);
            control.ResumeLayout();
        }

        private void T_MouseEnter(object sender, EventArgs e)
        {
            if (isColorGreater(Foreground, Color.FromArgb(127, 127, 127)))
            {
                ToolStripMenuItem t = (ToolStripMenuItem)sender;
                t.ForeColor = Background;
            }
        }

        private bool isColorGreater(Color c1, Color c2)
        {
            return (c1.R >= c2.R && c1.G >= c2.G && c1.B >= c2.B);
        }

        private void T_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            t.ForeColor = Foreground;
        }

        public static Bitmap RecolorImage(Bitmap orig, Color color)
        {
            Bitmap pic = orig;
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(inv.A, color.R, color.G, color.B);
                    pic.SetPixel(x, y, inv);
                }
            }
            return pic;
        }

        public static Color Invert(Color originalColor)
        {
            return Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
        }

        public Bitmap Theme2Image()
        {
            Bitmap img = new Bitmap(264, 44);
            int count = 8;
            using (Graphics gfx = Graphics.FromImage(img))
            {
                for (int i = 0; i < count; i++)
                {
                    Color c = Color.Black;
                    if (i == 0)
                        c = this.Background;
                    else if (i == 1)
                        c = this.Foreground;
                    else if (i == 2)
                        c = this.OtherForeground;
                    else if (i == 3)
                        c = this.MouseOver;
                    else if (i == 4)
                        c = this.MouseDown;
                    else if (i == 5)
                        c = this.Selected;
                    else if (i == 6)
                        c = this.SelectedBackground;
                    else if (i == 7)
                        c = this.SelectedForeground;
                    using (SolidBrush brush = new SolidBrush(c))
                    {
                        gfx.FillRectangle(brush, i * (img.Width / count), 0, img.Height, img.Height);
                    }
                }
            }
            return img;
        }
    }
}
