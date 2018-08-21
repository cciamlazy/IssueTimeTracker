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
    public partial class TaskFilter : Form
    {
        private LogBrowser _logBrowser;
        private DateTime MonthMin = new DateTime();
        private DateTime MonthMax = new DateTime();
        public TaskFilter(LogBrowser logBrowser, string minDate, string maxDate, List<Task> allTasks)
        {
            InitializeComponent();
            _logBrowser = logBrowser;
            MonthMin = DateTime.Parse(minDate);
            MonthMax = DateTime.Parse(maxDate);
            DateFrom.MinDate = MonthMin;
            DateFrom.MaxDate = MonthMax;
            DateTo.MinDate = MonthMin;
            DateTo.MaxDate = MonthMax;
            foreach (Task t in allTasks)
            {
                string temp = t.IssueNumber.Split('-')[0];
                int c = 0;
                foreach (string check in OrgListBox.Items)
                    if (check.Trim().Equals(temp.Trim()))
                        c++;
                if(c == 0 && temp != null && temp != "" && temp != "null")
                    OrgListBox.Items.Add(t.IssueNumber.Split('-')[0].Trim());

                bool add = true;
                foreach (string s in UsedTimeList.Items)
                    if (s == t.TimeUsed)
                        add = false;
                if (add)
                    UsedTimeList.Items.Add(t.TimeUsed);
            }
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateCheckBox();
        }

        private void UpdateDateCheckBox()
        {
            if (DateCheckBox.Checked)
            {
                DatePanel.Size = new Size(300, 30);
                DatePanel.Visible = true;
            }
            else
            {
                DatePanel.Size = new Size(0, 0);
                DatePanel.Visible = false;
            }
            DatePanel.Location = new Point(DateCheckBox.Location.X, DateCheckBox.Location.Y + DateCheckBox.Size.Height);
            UpdateOrgCheckBox();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateCheckBox();
        }

        private void UpdateOrgCheckBox()
        {
            OrgCheckBox.Location = new Point(OrgCheckBox.Location.X, DatePanel.Location.Y + DatePanel.Size.Height); ;
            if(OrgCheckBox.Checked)
            {
                OrgPanel.Size = new Size(300, 99);
                OrgPanel.Visible = true;
            }
            else
            {
                OrgPanel.Size = new Size(0, 0);
                OrgPanel.Visible = false;
            }
            OrgPanel.Location = new Point(OrgCheckBox.Location.X, OrgCheckBox.Location.Y + OrgCheckBox.Size.Height);
            UpdateElapsedCheckBox();
        }

        private void ElapsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateCheckBox();
        }

        private void UpdateElapsedCheckBox()
        {
            ElapsedCheckBox.Location = new Point(ElapsedCheckBox.Location.X, OrgPanel.Location.Y + OrgPanel.Size.Height); ;
            if (ElapsedCheckBox.Checked)
            {
                ElapsedPanel.Size = new Size(300, 30);
                ElapsedPanel.Visible = true;
            }
            else
            {
                ElapsedPanel.Size = new Size(0, 0);
                ElapsedPanel.Visible = false;
            }
            ElapsedPanel.Location = new Point(ElapsedCheckBox.Location.X, ElapsedCheckBox.Location.Y + ElapsedCheckBox.Size.Height);
            UpdateUsedCheckBox();
        }

        private void UsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateCheckBox();
        }

        private void UpdateUsedCheckBox()
        {
            UsedCheckBox.Location = new Point(UsedCheckBox.Location.X, ElapsedPanel.Location.Y + ElapsedPanel.Size.Height);
            if (UsedCheckBox.Checked)
            {
                UsedPanel.Size = new Size(300, 104);
                UsedPanel.Visible = true;
            }
            else
            {
                UsedPanel.Size = new Size(0, 0);
                UsedPanel.Visible = false;
            }
            UsedPanel.Location = new Point(UsedCheckBox.Location.X, UsedCheckBox.Location.Y + UsedCheckBox.Size.Height);
            APSCheckbox.Location = new Point(APSCheckbox.Location.X, UsedPanel.Location.Y + UsedPanel.Size.Height);
            searchButton.Location = new Point(searchButton.Location.X, APSCheckbox.Location.Y + APSCheckbox.Size.Height);
            this.ClientSize = new Size(this.ClientSize.Width, searchButton.Location.Y + searchButton.Size.Height + 10);
        }

        private void TaskFilter_Load(object sender, EventArgs e)
        {
            UpdateDateCheckBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> organizations = new List<string>();
            if (OrgCheckBox.Checked)
                foreach (string s in OrgListBox.SelectedItems)
                    organizations.Add(s);
            List<string> usedTimes = new List<string>();
            if (UsedCheckBox.Checked)
                foreach (string s in UsedTimeList.SelectedItems)
                    usedTimes.Add(s);

            _logBrowser.TaskFilter_Query(
                (DateCheckBox.Checked ? DateFrom.Value.ToShortDateString() : ""), 
                (DateCheckBox.Checked ? DateTo.Value.ToShortDateString() : ""), 
                organizations, 
                (ElapsedCheckBox.Checked ? FromElapsedTime.Value : DateTime.MinValue), 
                (ElapsedCheckBox.Checked ? toElapsedTime.Value : DateTime.MinValue), 
                usedTimes, APSCheckbox.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string s in OrgListBox.Items)
            {
                if(customOrgTextBox.Text.Trim().ToLower().Equals(s.ToLower()))
                {
                    customOrgTextBox.Text = "";
                    return;
                }
            }
            OrgListBox.Items.Add(customOrgTextBox.Text.Trim());
            customOrgTextBox.Text = "";
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTo.MinDate = DateFrom.Value;
            UpdateDateCheckBox();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            DateFrom.MaxDate = DateTo.Value;
            UpdateDateCheckBox();
        }
    }
}
