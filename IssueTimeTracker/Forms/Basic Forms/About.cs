using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(LinkLabel), typeof(TextBox), typeof(GroupBox) });
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void About_Load(object sender, EventArgs e)
        {
            CurVersion.Text = "Current Version: " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
        }

        private void sourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/cciamlazy/IssueTimeTracker");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://csmithut.net/IssueTimeTracker/User%20Guide.pdf");
        }
    }
}
