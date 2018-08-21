using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using IssueTimeTracker.Classes.Helper;
using IssueTimeTracker.Classes;

namespace IssueTimeTracker.Forms.Basic_Forms
{
    public partial class ColorDropper : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);


        public DialogResult DialogResult = DialogResult.None;
        private Color _pickedColor = Color.White;
        private bool noReturn = false;
        MouseHook mh;

        public ColorDropper()
        {
            InitializeComponent();
            mh = new MouseHook();
            mh.SetHook();
            mh.MouseClickEvent += mh_MouseClickEvent;
            mh.MouseMoveEvent += mh_MouseMoveEvent;
            this.TopMost = true;
        }

        private void mh_MouseClickEvent(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X + "-" + e.Y);
            if (e.Button == MouseButtons.Left)
            {
                _pickedColor = this.BackColor;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.Button == MouseButtons.Right)
            {
                noReturn = true;
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        
        private void mh_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            Rectangle mouse = new Rectangle(e.X, e.Y, 1, 1);
            foreach (Screen screen in Screen.AllScreens)
            {
                if(screen.Bounds.IntersectsWith(mouse))
                {
                    Rectangle left = new Rectangle(0, 0, screen.Bounds.Width / 2, screen.Bounds.Height);
                    Rectangle right = new Rectangle(screen.Bounds.Width / 2, 0, screen.Bounds.Width / 2, screen.Bounds.Height);

                    if (left.IntersectsWith(mouse))
                        this.Location = new Point(screen.Bounds.Width - this.Width - 100, 100);
                    else if (right.IntersectsWith(mouse))
                        this.Location = new Point(screen.Bounds.X + 100, 100);
                }
            }
        }

        public Color PickedColor()
        {
            return (!noReturn ? _pickedColor : Color.Transparent);
        }

        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            this.BackColor = c;
            label1.ForeColor = Theme.Invert(c);
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void ColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            mh.UnHook();
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {

        }
    }
}
