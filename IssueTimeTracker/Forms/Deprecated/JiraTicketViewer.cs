using Atlassian.Jira;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class JiraTicketViewer : Form
    {
        Issue Issue;
        bool Responded = false;

        public JiraTicketViewer(Issue issue)
        {
            InitializeComponent();
            Issue = issue;
        }

        private void JiraTicketViewer_Load(object sender, EventArgs e)
        {
            RespondText.Text = Setting.Value.Jira_Response;
            LoadData();
        }

        private void LoadData()
        {
            Title.Text = "LA County / " + Issue.Key;
            Type.Text = Issue.Type.Name;
            Priority.Text = Issue.Priority.Name;

            var fields = Issue.CustomFields;

            foreach (CustomFieldValue c in fields)
            {
                switch (c.Id)
                {
                    case "customfield_10303":
                        CustomerPhoneNumber.Text = c.Values.First();
                        break;
                    case "customfield_10304":
                        IssueID.Text = c.Values.First();
                        break;
                    case "customfield_10305":
                        JiraLocation.Text = c.Values.First();
                        break;
                    case "customfield_10306":
                        ErrorCorrection.Text = c.Values.First();
                        break;
                    default:
                        break;
                }
            }

            Status.Text = Issue.Status.Name;
            if (Issue.Resolution != null)
                Resolution.Text = Issue.Resolution.Name;
            if (Issue.Assignee != null)
                Assignee.Text = Issue.Assignee;
            Reporter.Text = Issue.Reporter;
            CreatedDate.Text = Issue.Created.Value.ToShortDateString() + " - " + Issue.Created.Value.ToShortTimeString();
            Description.Text = Issue.Description;
        }

        private async void AddComments()
        {
            IEnumerable<Comment> comments = await Issue.GetCommentsAsync();
            Description.Text += "\n\n--Comments--";
            foreach(Comment c in comments)
            {
                Description.Text += c.Author + " - " + c.CreatedDate + "\n" + c.Body + "\n\n";
            }
        }

        private void JiraTicketViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Responded)
                if (MessageBox.Show("Are you sure you want to exit without responding to the issue?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) != DialogResult.Yes)
                    e.Cancel = true;
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            AssignAndRespond();
            LoadData();
            
        }

        private void Respond_Click(object sender, EventArgs e)
        {
            Respond(RespondText.Text);
        }

        private async void AssignAndRespond()
        {
            bool alreadyAssigned = await Assign(Setting.Value.Jira_Username);
            if (!alreadyAssigned)
                Respond(RespondText.Text);
        }

        private async void Respond(string response)
        {
            await Issue.AddCommentAsync(response);
            Setting.Value.Jira_Response = response;
            Setting.Save();
            Responded = true;
        }

        private async Task<bool> Assign(string assignee)
        {
            bool ret = false;
            string before = Issue.Assignee;
            await Issue.RefreshAsync();
            string after = Issue.Assignee;
            if (before == after)
            {
                Issue.Assignee = assignee;
                await Issue.SaveChangesAsync();
                await Issue.RefreshAsync();
                ret = true;
            }
            else
                MessageBox.Show("This ticket has already been assigned to " + Issue.Assignee);
            Assignee.Text = Issue.Assignee;
            return ret;
        }

        private void RespondText_TextChanged(object sender, EventArgs e)
        {
            if (Responded)
                Responded = false;
        }
    }
}
