using Atlassian.Jira;
using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Forms.Basic_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class JiraLogin : Form
    {
        private static JiraLogin open;
        Pin pinEntry;
        public JiraLogin(string username = "")
        {
            
            InitializeComponent();

            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(TextBox), typeof(CheckBox) });
        }

        private void JiraLogin_Load(object sender, EventArgs e)
        {
            pinEntry = new Pin(this);

            if (open != null && !open.IsDisposed)
            {
                open.Show();
                open.Focus();
                return;
            }
            else
                open = this;


            if (StaticHandler._Main == null && StaticHandler._ThemedMain == null)
            { 
                this.Location = new Point(this.Location.X - this.Width, this.Location.Y);
            }
            else
            {
                if (StaticHandler._Main != null) 
                    this.Location = new Point(StaticHandler._Main.Location.X - this.Width, StaticHandler._Main.Location.Y);
                if (StaticHandler._ThemedMain != null) 
                    this.Location = new Point(StaticHandler._ThemedMain.Location.X - this.Width, StaticHandler._ThemedMain.Location.Y);
            }
            this.TopMost = true;
            if (Setting.Value.Jira_SavePassword && Setting.Value.Jira_EncryptedPassword != null && Setting.Value.Jira_EncryptedPassword != "" && this.Visible)
            {
                if (pinEntry == null || pinEntry.IsDisposed)
                    pinEntry = new Pin(this);
                pinEntry.Show();
                pinEntry.Focus();
            }
            else
                this.Focus();
            /*if (username != "")
                Username.Text = username;*/
            open.Show();

            FillUsername();
            if (Setting.Value.Jira_SavePassword && Setting.Value.Jira_EncryptedPassword != null && Setting.Value.Jira_EncryptedPassword != "" && this.Visible)
            {
                if (pinEntry == null || pinEntry.IsDisposed)
                    pinEntry = new Pin(this);
                pinEntry.Show();
                pinEntry.Focus();
            }

            open.Show();
        }
        
        public void PassPin(SecureString secureString)
        {
            if(Setting.Value.Jira_Username != null && Setting.Value.Jira_Username != "")
                Username.Text = Setting.Value.Jira_Username;
            Password.Text = Encryption.Helper.ConvertToUnsecureString(secureString);
            button1_Click(new object(), new EventArgs());
        }

        public void AutoLogin(object sender, EventArgs e)
        {
            if (AdminControl.Control.JiraAutoLogin)
            {
                FillUsername();
                Password.Text = AdminControl.Control.JiraPassword;
                button1_Click(sender, e);
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private async  void button1_Click(object sender, EventArgs e)
        {
            bool pass = await TestLogin();

            if(!pass)
            {
                MessageBox.Show("Failed to login. Incorrect Username or Password. If you believe it is correct, check your internet connection.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Text = "";
                return;
            }

            if(checkBox1.Checked && pin.Text.Length == 4 && Password.Text != "")
            {
                Setting.Value.Jira_SavePassword = true;
                Setting.Value.Jira_EncryptedPassword = Encryption.AESThenHMAC.SimpleEncryptWithPassword(Password.Text, pin.Text);
            }
            else if (checkBox1.Checked && pin.Text.Length != 4)
            {
                MessageBox.Show("Please enter a 4 digit pin");
                return;
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            if (StaticHandler._Main != null)
            {
                StaticHandler._Main.JiraPassword = Encryption.Helper.ConvertToSecureString(Password.Text);
                StaticHandler._Main._Jira = Atlassian.Jira.Jira.CreateRestClient(Setting.Value.Jira_Link, Username.Text, Password.Text, new JiraRestClientSettings() { EnableRequestTrace = true });
                StaticHandler._Main._Jira.Issues.MaxIssuesPerRequest = 5;
                StaticHandler._Main.jiraBrowserToolStripMenuItem.Enabled = true;
                StaticHandler._Main.jiraDataToolStripMenuItem.Enabled = true;
                StaticHandler._Main.JiraChecker.Enabled = true;
                StaticHandler._Main.jiraCheckingState = JiraCheckingState.Checking;
            }
            if (StaticHandler._ThemedMain != null)
            {
                StaticHandler._ThemedMain.JiraPassword = Encryption.Helper.ConvertToSecureString(Password.Text);
                StaticHandler._ThemedMain._Jira = Atlassian.Jira.Jira.CreateRestClient(Setting.Value.Jira_Link, Username.Text, Password.Text, new JiraRestClientSettings() { EnableRequestTrace = true });
                StaticHandler._ThemedMain._Jira.Issues.MaxIssuesPerRequest = 5;
                StaticHandler._ThemedMain.jiraBrowserToolStripMenuItem.Enabled = true;
                StaticHandler._ThemedMain.jiraDataToolStripMenuItem.Enabled = true;
                StaticHandler._ThemedMain.JiraChecker.Enabled = true;
                StaticHandler._ThemedMain.jiraCheckingState = JiraCheckingState.Checking;
            }
            Setting.Value.Jira_Username = Username.Text;
            Setting.Save();
            StaticHandler.JiraFailCount = 0;
            this.Hide();
        }

        private async Task<bool> TestLogin()
        {
            Atlassian.Jira.Jira tempJira = Atlassian.Jira.Jira.CreateRestClient(Setting.Value.Jira_Link, Username.Text, Password.Text, new JiraRestClientSettings() { EnableRequestTrace = true });

            bool pass = false;
            tempJira.MaxIssuesPerRequest = 5; //Set the Max Issues per Request to 25
            IPagedQueryResult<Issue> issues = null; //Creates a variable to store the issues in outside the try-catch statement
            try
            {
                issues = await tempJira.Issues.GetIssuesFromJqlAsync("project = LAC"); //Attempt to pull the issues
                if (issues.Count() == 5)
                    pass = true;
            }
            catch
            {
                pass = false;
            }
            
            return pass;
        }

        private void JiraLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void JiraLogin_Shown(object sender, EventArgs e)
        {
            FillUsername();
            if (Setting.Value.Jira_SavePassword && Setting.Value.Jira_EncryptedPassword != null && Setting.Value.Jira_EncryptedPassword != "")
            {
                if (pinEntry == null || pinEntry.IsDisposed)
                    pinEntry = new Pin(this);
                pinEntry.Show();
                pinEntry.Focus();
            }
            if (StaticHandler._Main == null && StaticHandler._ThemedMain == null)
            {
                this.Location = new Point(this.Location.X - this.Width, this.Location.Y);
            }
            else
            {
                if (StaticHandler._Main != null)
                    this.Location = new Point(StaticHandler._Main.Location.X - this.Width, StaticHandler._Main.Location.Y);
                if (StaticHandler._ThemedMain != null)
                    this.Location = new Point(StaticHandler._ThemedMain.Location.X - this.Width, StaticHandler._ThemedMain.Location.Y);
            }
        }

        private void FillUsername()
        {
            if (Setting.Value.Jira_Username != "!" && Username.Text == "")
            {
                Username.Text = Setting.Value.Jira_Username;
                Password.Focus();
            }
            else
                Username.Focus();
            if (Setting.Value.Jira_SavePassword && Setting.Value.Jira_EncryptedPassword != null && Setting.Value.Jira_EncryptedPassword != "" && pinEntry != null && !pinEntry.IsDisposed)
            {
                if (pinEntry == null || pinEntry.IsDisposed)
                    pinEntry = new Pin(this);
                pinEntry.Show();
                pinEntry.Focus();
            }
        }

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pin.Visible = checkBox1.Checked;
            label2.Visible = checkBox1.Checked;
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(checkBox1, "Your password is stored encrypted and can only be unencrypted with your pin");
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
    }
}
