using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class Suggestion : Form
    {
        public Suggestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BugReporter.SendMail(MainData.Instance.SmtpAuth.Recipient, "Suggestion from " + Setting.Value.Jira_Username, textBox1.Text);
            MessageBox.Show("Input received");
            this.Close();
        }
    }
}
