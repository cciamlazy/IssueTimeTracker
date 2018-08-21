using Atlassian.Jira;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace IssueTimeTracker
{
    public partial class Notification : Form
    {
        private static readonly List<Notification> OpenNotifications = new List<Notification>();
        private bool _allowFocus;
        private readonly FormAnimator _animator;
        private IntPtr _currentForegroundWindow;
        private FormAnimator.AnimationDirection Direction;
        private int AnimationSpeed = 250;
        private string Issue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="duration"></param>
        /// <param name="animation"></param>
        /// <param name="direction"></param>
        public Notification(string title, string body, int duration, FormAnimator.AnimationMethod animation, FormAnimator.AnimationDirection direction, int scale = -1, string issue = "")
        {
            InitializeComponent();

            if (duration < 0)
                duration = int.MaxValue;
            else
                duration = duration * 1000;

            lifeTimer.Interval = duration;
            labelTitle.Text = title;
            labelBody.Text = body;
            labelTime.Text = DateTime.Now.ToShortTimeString();

            if (scale == -1)
                scale = Setting.Value.Notification_Scale;
            this.Scale(new SizeF((float)(scale) / 100, (float)(scale) / 100));
            animation = FormAnimator.AnimationMethod.Slide;
            _animator = new FormAnimator(this, animation, direction, AnimationSpeed);

            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 2, 2));

            Direction = direction;

            Issue = issue;
            
        }

        FormAnimator.AnimationDirection[] Directions = { FormAnimator.AnimationDirection.Up, FormAnimator.AnimationDirection.Down, FormAnimator.AnimationDirection.Left, FormAnimator.AnimationDirection.Right };

        public Notification(IssueTimeTracker.Classes.Messenger.Message message)
        {
            InitializeComponent();

            lifeTimer.Interval = int.MaxValue;
            labelTitle.Text = "Message from " + JiraIssueBrowser.FixJiraName(message.From);
            labelBody.Text = message.LongMessage;
            labelTime.Text = message.TimeSent;
            
            this.Scale(new SizeF((float)(Setting.Value.Notification_Scale) / 100, (float)(Setting.Value.Notification_Scale) / 100));
            _animator = new FormAnimator(this, FormAnimator.AnimationMethod.Slide, Directions[Setting.Value.Notification_Direction], AnimationSpeed);

            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 2, 2));

            Direction = Directions[Setting.Value.Notification_Direction];
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        #region Methods

        /// <summary>
        /// Displays the form
        /// </summary>
        /// <remarks>
        /// Required to allow the form to determine the current foreground window before being displayed
        /// </remarks>
        public new void Show()
        {
            // Determine the current foreground window so it can be reactivated each time this form tries to get the focus
            _currentForegroundWindow = NativeMethods.GetForegroundWindow();

            base.Show();
        }

        #endregion // Methods

        #region Event Handlers

        private void Notification_Load(object sender, EventArgs e)
        {
            /*this.BackColor = Setting.Value.Notification_Color;
            this.labelTitle.ForeColor = Setting.Value.Notification_TextColor;
            this.labelBody.ForeColor = Setting.Value.Notification_TextColor;
            this.labelTime.ForeColor = Setting.Value.Notification_TextColor;*/
            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label) });

            Rectangle workingArea;
            if (Screen.AllScreens.Length > 1 && Setting.Value.Notification_Screen < Screen.AllScreens.Length)
                workingArea = Screen.AllScreens[Setting.Value.Notification_Screen].WorkingArea;
            else
                workingArea = Screen.PrimaryScreen.WorkingArea;

            //Determine the position of the notification
            switch (Setting.Value.Notification_Corner)
            {
                case 0:
                    this.Location = new Point(workingArea.X + 5, workingArea.Y + 5);
                    break;
                case 1:
                    this.Location = new Point(workingArea.X + workingArea.Width - Width, workingArea.Y + 5);
                    break;
                case 2:
                    this.Location = new Point(workingArea.X + workingArea.Width - Width, workingArea.Y + workingArea.Height - Height);
                    break;
                case 3:
                    this.Location = new Point(workingArea.X + 5, workingArea.Y + workingArea.Height - Height);
                    break;
            }

            // Move each open form upwards to make room for this one
            foreach (Notification openForm in OpenNotifications)
            {
                openForm.Top -= Height;
            }

            OpenNotifications.Add(this);
            lifeTimer.Start();
        }

        private void Notification_Activated(object sender, EventArgs e)
        {
            // Prevent the form taking focus when it is initially shown
            if (!_allowFocus)
            {
                // Activate the window that previously had focus
                NativeMethods.SetForegroundWindow(_currentForegroundWindow);
            }
        }

        private void Notification_Shown(object sender, EventArgs e)
        {
            // Once the animation has completed the form can receive focus
            _allowFocus = true;

            // Close the form by sliding down.
            _animator.Duration = AnimationSpeed;
            _animator.Direction = ReverseDirection(Direction);
        }

        private FormAnimator.AnimationDirection ReverseDirection(FormAnimator.AnimationDirection d)
        {
            if (d == FormAnimator.AnimationDirection.Down)
                return FormAnimator.AnimationDirection.Up;
            else if (d == FormAnimator.AnimationDirection.Up)
                return FormAnimator.AnimationDirection.Down;
            else if (d == FormAnimator.AnimationDirection.Right)
                return FormAnimator.AnimationDirection.Left;
            return FormAnimator.AnimationDirection.Right;
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Move down any open forms above this one
            foreach (Notification openForm in OpenNotifications)
            {
                if (openForm == this)
                {
                    // Remaining forms are below this one
                    break;
                }
                openForm.Top += Height;
            }

            OpenNotifications.Remove(this);
        }

        private void lifeTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            ClickToClose();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            ClickToClose();
        }

        private void labelRO_Click(object sender, EventArgs e)
        {
            ClickToClose();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            ClickToClose();
        }

        private async void ClickToClose()
        {
            if (Issue != null && Issue != "" && Setting.Value.Jira_Mode != Classes.JiraMode.Nothing)
            {
                if (Setting.Value.Jira_Mode == Classes.JiraMode.InApplication)
                {
                    if (StaticHandler._Main != null)
                    {
                        StaticHandler._Main.jiraTicket = new JiraIssueBrowser();
                        StaticHandler._Main.jiraTicket.Show();
                        await StaticHandler._Main.jiraTicket.NavigateToIssueByKey(Issue);
                        StaticHandler._Main.jiraTicket.AddPremadeResponse();
                    }
                    if (StaticHandler._ThemedMain != null)
                    {
                        StaticHandler._ThemedMain.jiraTicket = new JiraIssueBrowser();
                        StaticHandler._ThemedMain.jiraTicket.Show();
                        await StaticHandler._ThemedMain.jiraTicket.NavigateToIssueByKey(Issue);
                        StaticHandler._ThemedMain.jiraTicket.AddPremadeResponse();
                    }
                }
                else if (Setting.Value.Jira_Mode == Classes.JiraMode.WebBrowser)
                {
                    System.Diagnostics.Process.Start(Setting.Value.Jira_Link + @"projects/LAC/queues/custom/7/" + Issue);
                }
            }
            Close();
        }
        #endregion // Event Handlers

        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
