using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker
{
    public partial class TestIssueTimeTracker : Form
    {
        public TestIssueTimeTracker()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        #region Variables
        private bool drag = false;
        private Point start_point = new Point(0, 0);

        //If true it will be the time progressbar and false will be the task progressbar
        bool TimeProgressBar = true;

        #endregion
        
        #region Events

        private void TestIssueTimeTracker_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, this.Width, this.Height));
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

        #region ProgressBar

        private void ProgressBarSwitcher_Tick(object sender, EventArgs e)
        {
            SwitchProgressBar();
            ProgressBarSwitcher.Enabled = false;
        }

        private void SwitchProgressBar()
        {
            //if (TimeProgressBar && Quarters > 0f)
            //    TimeProgressBar = false;
            //else
             //   TimeProgressBar = true;
        }

        private void ProgressbarRegulator_Tick(object sender, EventArgs e)
        {
            if(TimeProgressBar)
            {
                DayProgress.ProgressColor = Setting.Value.Timer_CurrentTaskColor;
                DayProgress.Maximum = 900000;
                //DayProgress.Value = ((int)Task.Elapsed.TotalMilliseconds % 900000);
            }
            else
            {
                DayProgress.ProgressColor = Setting.Value.Timer_TotalProgressColor;
                //int total = (int)Math.Round((double)(Quarters * 12.5));
                DayProgress.Maximum = 800;
                //DayProgress.Value = (int)((Quarters * 100) <= DayProgress.Maximum ? (Quarters * 100) : DayProgress.Maximum);
            }
        }

        #endregion
    }
}
