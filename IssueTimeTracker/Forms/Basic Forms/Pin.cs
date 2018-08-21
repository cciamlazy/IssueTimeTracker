using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Basic_Forms
{
    public partial class Pin : Form
    {
        private static Pin instance;

        private JiraLogin _jiraLogin;
        public Pin(JiraLogin jiraLogin)
        {
            if (instance == null || instance.IsDisposed)
                instance = this;
            else
                this.Close();
            _jiraLogin = jiraLogin;
            InitializeComponent();
            this.TopMost = true;

            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(TextBox), typeof(Button) });
        }


        private static int count = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text.Length == 4)
                {
                    if (count < 5)
                    {
                        try
                        {
                            if (StaticHandler._Main != null)
                            {
                                StaticHandler._Main.JiraPassword = GetPassword(textBox1.Text);
                                _jiraLogin.PassPin(StaticHandler._Main.JiraPassword);
                            }
                            if (StaticHandler._ThemedMain != null)
                            {
                                StaticHandler._ThemedMain.JiraPassword = GetPassword(textBox1.Text);
                                _jiraLogin.PassPin(StaticHandler._ThemedMain.JiraPassword);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Incorrect Pin " + ++count + "/5 times");
                            textBox1.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can not enter you pin right now");
                    }
                    this.Close();
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private SecureString GetPassword(string pin)
        {
            if (count > 5)
                throw new Exception("Too many failed attempts");

            SecureString pass = Encryption.Helper.ConvertToSecureString(Encryption.AESThenHMAC.SimpleDecryptWithPassword(Setting.Value.Jira_EncryptedPassword, pin));
            
            return pass;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pin_Load(object sender, EventArgs e)
        {
            this.Focus();
            textBox1.Focus();
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
    }
}
