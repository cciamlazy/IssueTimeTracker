using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Jira
{
    public partial class JiraNames : Form
    {
        public JiraNames()
        {
            InitializeComponent();
        }

        private void JiraNames_Load(object sender, EventArgs e)
        {
            BindingList<JiraName> blist = new BindingList<JiraName>(MainData.Instance.JiraNames);
            jiraNameGrid.DataSource = blist;
        }

        private void JiraNames_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<JiraName> list = new List<JiraName>((BindingList<JiraName>)jiraNameGrid.DataSource);
            MainData.Instance.JiraNames = list;
            MainData.Export();
        }
    }
}
