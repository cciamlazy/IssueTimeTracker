using Atlassian.Jira;
using IssueTimeTracker.Forms.Jira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class JiraIssueBrowser : Form
    {

        private Issue CurrentIssue { get { return GetIssueByKey(KeyLink.Text); } } //Get the current open issue

        List<Issue> Issues = new List<Issue>(); //A list of the currently loaded issues

        private readonly ContextMenuStrip RightClickAttachment; //Menu for when you right click an attachment

        public JiraIssueBrowser()
        {
            InitializeComponent();
            
            var DeleteAttachment = new ToolStripMenuItem { Text = "Delete" }; //Create a tool menu item called Delete
            DeleteAttachment.Click += DeleteAttachment_ClickAsync; //Add an event handler for the delete menu item
            RightClickAttachment = new ContextMenuStrip(); //Create a new menu strip for attachment
            RightClickAttachment.Items.AddRange(new ToolStripItem[] { DeleteAttachment }); //Add the delete button to the menu

            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(TextBox), typeof(ComboBox), typeof(Button), typeof(Panel), typeof(ListView), typeof(Button), typeof(ColumnHeader) });
        }

        #region Queue Buttons

        int ActiveQueue = 0;


        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadQueues(); //Load the queues
            if(IssueListPanel.Visible) //If the Issue List is visible
            {
                switch(ActiveQueue) //Determine which queue it's in and refresh the list for possible items (intentially left them to not await the async callback)
                {
                    case 0:
                        await GetIssues("project = LAC AND resolution = unresolved"); //All issues
                        break;
                    case 1:
                        await GetIssues("project = LAC AND resolution = unresolved AND assignee is empty"); //Unassigned issues
                        break;
                    case 2:
                        await GetIssues("project = LAC AND resolution = unresolved AND assignee = currentUser()"); //Assigned to me
                        break;
                    case 3:
                        await GetIssues("project = LAC AND resolution = unresolved AND status = 'waiting for customer'"); //Waiting on customer
                        break;
                    case 4:
                        string date = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"); //Get the day 6 days ago so that the jql can find all the issues that have been resolved between now and 6 days ago
                        await GetIssues("project = LAC AND status = resolved AND resolutiondate > " + date); //Recently resolved
                        break;
                }
            }
        }

        /// <summary>
        /// Focuses the form and set the current queue to the All Issues queue
        /// </summary>
        public void DefaultScreen()
        {
            this.Show(); //Shows the form
            this.Focus(); //Focus the form
            AllOpenButton_ClickAsync(new object(), new EventArgs()); //Call the All Open Issues button to load the All Open Queue properly
        }

        private async void AllOpenButton_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = 0; //Set the active queue to 0
            QueueLabel.Text = "All open"; //Update the queue header
            await GetIssues("project = LAC AND resolution = unresolved"); //Get issues that are open
            CalcButtons(); //Calculate the buttons
        }

        private async void UnassignedButton_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = 1; //Set the active queue to 1
            QueueLabel.Text = "Unassigned issues"; //Update the queue header
            await GetIssues("project = LAC AND resolution = unresolved AND assignee is empty"); //Get issues that are Unassigned issues
            CalcButtons(); //Calculate the buttons
        }

        private async void AssignedButton_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = 2; //Set the active queue to 2
            QueueLabel.Text = "Assigned to me"; //Update the queue header
            await GetIssues("project = LAC AND resolution = unresolved AND assignee = currentUser()"); //Get issues that are Recently resolved
            CalcButtons(); //Calculate the buttons
        }

        private async void WaitingButton_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = 3; //Set the active queue to 3
            QueueLabel.Text = "Waiting on customer"; //Update the queue header
            await GetIssues("project = LAC AND resolution = unresolved AND status = 'waiting for customer'"); //Get issues that are Waiting on customer
            CalcButtons(); //Calculate the buttons
        }

        private async void RecentButton_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = 4; //Set the active queue to 4
            QueueLabel.Text = "Recently resolved"; //Update the queue header
            string date = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"); //Get the day 6 days ago so that the jql can find all the issues that have been resolved between now and 6 days ago
            await GetIssues("project = LAC AND status = resolved AND resolutiondate > " + date); //Get issues that are Recently resolved
            CalcButtons(); //Calculate the buttons
        }

        /// <summary>
        /// Calculates the current font style of each of the queue buttons
        /// </summary>
        private void CalcButtons()
        {
            AllOpenButton.Font = new Font("Segoe UI", 8.25F, (ActiveQueue == 0 ? FontStyle.Bold : FontStyle.Regular), GraphicsUnit.Point, ((byte)(0))); //If the active queue is this one, set the font to bold, otherwise not bold
            UnassignedButton.Font = new Font("Segoe UI", 8.25F, (ActiveQueue == 1 ? FontStyle.Bold : FontStyle.Regular), GraphicsUnit.Point, ((byte)(0))); //If the active queue is this one, set the font to bold, otherwise not bold
            AssignedButton.Font = new Font("Segoe UI", 8.25F, (ActiveQueue == 2 ? FontStyle.Bold : FontStyle.Regular), GraphicsUnit.Point, ((byte)(0))); //If the active queue is this one, set the font to bold, otherwise not bold
            WaitingButton.Font = new Font("Segoe UI", 8.25F, (ActiveQueue == 3 ? FontStyle.Bold : FontStyle.Regular), GraphicsUnit.Point, ((byte)(0))); //If the active queue is this one, set the font to bold, otherwise not bold
            RecentButton.Font = new Font("Segoe UI", 8.25F, (ActiveQueue == 4 ? FontStyle.Bold : FontStyle.Regular), GraphicsUnit.Point, ((byte)(0))); //If the active queue is this one, set the font to bold, otherwise not bold

            TicketPanel.Visible = false; //Ticketpanel gone
            IssueListPanel.Visible = true; //IssueListPanel visible

            LoadQueues();
        }

        /// <summary>
        /// Loads the number to the right of each of the queue buttons
        /// </summary>
        private async void LoadQueues()
        {
            if (StaticHandler._Main != null)
            {
                StaticHandler._Main._Jira.Issues.MaxIssuesPerRequest = 25;
                var issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved");
                AllOpenNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND assignee is empty");
                UnassignedNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND assignee = currentUser()");
                AssignedNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND status = 'waiting for customer'");
                WaitingNumber.Text = issues.Count().ToString();
                string date = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd");
                issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND status = resolved AND resolutiondate > " + date);
                RecentNumber.Text = issues.Count().ToString();
            }
            if (StaticHandler._ThemedMain != null)
            {
                StaticHandler._ThemedMain._Jira.Issues.MaxIssuesPerRequest = 25;
                var issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved");
                AllOpenNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND assignee is empty");
                UnassignedNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND assignee = currentUser()");
                AssignedNumber.Text = issues.Count().ToString();
                issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND resolution = unresolved AND status = 'waiting for customer'");
                WaitingNumber.Text = issues.Count().ToString();
                string date = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd");
                issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync("project = LAC AND status = resolved AND resolutiondate > " + date);
                RecentNumber.Text = issues.Count().ToString();
            }
        }

        /// <summary>
        /// Load the issues that are found using the jql statement into the Issues list
        /// </summary>
        /// <param name="jql">The jql query for finding the issues</param>
        /// <returns>true</returns>
        private async Task<bool> GetIssues(string jql)
        {
            if (StaticHandler._Main != null)
                StaticHandler._Main._Jira.Issues.MaxIssuesPerRequest = 25; //Set the Max Issues per Request to 25
            if (StaticHandler._ThemedMain != null)
                StaticHandler._ThemedMain._Jira.Issues.MaxIssuesPerRequest = 25; //Set the Max Issues per Request to 25
            IPagedQueryResult<Issue> issues = null; //Creates a variable to store the issues in outside the try-catch statement
            try
            {
                if (StaticHandler._Main != null)
                    issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues
                if (StaticHandler._ThemedMain != null)
                    issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues
            }
            catch
            {
                try //Try again because we love double try catch statements... or I want to try something to fix it because I don't know the root cause or why the Jira api does this to me
                {
                    if (StaticHandler._Main != null)
                    {
                        StaticHandler._Main._Jira = Atlassian.Jira.Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(StaticHandler._Main.JiraPassword)); //Since it failed, try relogging in
                        issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues again
                    }
                    if (StaticHandler._ThemedMain != null)
                    {
                        StaticHandler._ThemedMain._Jira = Atlassian.Jira.Jira.CreateRestClient(Setting.Value.Jira_Link, Setting.Value.Jira_Username, Encryption.Helper.ConvertToUnsecureString(StaticHandler._ThemedMain.JiraPassword)); //Since it failed, try relogging in
                        issues = await StaticHandler._ThemedMain._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues again
                    }
                }
                catch (Exception e)
                {
                    ErrorLog log = new ErrorLog()
                    {
                        Date = DateTime.Now.ToString("M-d-yyyy"),
                        Time = DateTime.Now.ToString("h-mm-ss tt"),
                        Version = Program.GetUpdateFile(Path.Combine(Program.DataPath, "CurrentVersion.json")).Version,
                        StackTrace = e.StackTrace,
                        Source = e.Source,
                        Message = e.Message
                    };

                    Program.bugReporter = new BugReporter(log); //Open a new instance of the bug reporter
                }
            }
            if(issues == null)
            {
                MessageBox.Show("There was a problem connecting to Jira. Please attempt to log into the website and then try again later"); //warn the user
                this.Close(); //Close this form
            }
            Issues.Clear(); //Clear the issue list
            if(issues != null && issues.Count() > 0)
                Issues.AddRange(issues.ToArray()); //Add the newly loaded issues to the Issue list
            PopulateIssueList(); // Populate the Issue List
            if (Issues == null || Issues.Count == 0) //If there are no issues
            {
                NoIssuesLabel.Visible = true; //Make the NoIssuesLable visible
                IssuesList.Visible = false; //Make the IssuesList not visible
            }
            else
            {
                NoIssuesLabel.Visible = false; //Make the NoIssuesLable not visible
                IssuesList.Visible = true; //Make the IssuesList visible
            }
            return true; //return true
        }

        /// <summary>
        /// Populates the IssuesList element with all of the current issues
        /// </summary>
        private void PopulateIssueList()
        {
            List<IssuesListItem> list = new List<IssuesListItem>(); //Create a new list for holding temporary data
            if (Issues != null && Issues.Count > 0)
            {
                foreach (Issue i in Issues) //Loops through all the Issues
                {
                    string phone = i.Reporter; //Store the reporter's name here just in case we can't get the values from the Customer Phone Number
                    if (i.CustomFields != null && i.CustomFields.Count > 0)
                    {
                        foreach (CustomFieldValue c in i.CustomFields) //Gotta loop through all the customfields because the Jira API doesn't let me call it directly. Thanks Obama
                        {
                            if (c.Id == "customfield_10303") //If the field is the Customer Phone Number
                            {
                                phone = c.Values.First(); //Set the Phone value to the first item in the string
                            }
                        }
                    }
                    IssuesListItem l = new IssuesListItem //new item to store the values
                    {
                        Key = i.Key.Value, //bla
                        Assignee = FixJiraName(i.Assignee), //bla
                        Status = i.Status.Name, //bla
                        Summary = i.Summary, //bla
                        Created = i.Created.Value.ToShortDateString(), //Get the short date from the created date ie: 1/1/1970
                        Reporter = FixJiraName(i.Reporter), //bla
                        Priority = i.Priority.Name //bla
                    };
                    list.Add(l); //Add it to the list
                }
            }
            else
                return;
            ListViewItem[] listViewItems = new ListViewItem[list.Count]; //Make a new array of ListViewItems

            this.IssuesList.Items.Clear(); //Clear the list to make way for the new stuff

            //if (list == null || list.Count == 0 || listViewItems == null)
            //    return;

            
            //This next section is unfortunately my way of making the columns "AutoSize" because AutoSize columns weren't producing the results I wanted for this. Thanks Microsoft for forcing me to write this disaster
            int margin = 5;
            for (int i = 0; i < list.Count; i++) //Loop through all the the rows that will be part of this list from hell
            {
                string[] item = new string[] { list[i].Key, list[i].Status, list[i].Summary, list[i].Created, list[i].Reporter, list[i].Priority }; //I'm just upset at this point, but really, ListView makes you do this
                listViewItems[i] = new ListViewItem(item); //Let's create a new item here 

                Size size = TextRenderer.MeasureText(list[i].Key, IssuesList.Font); //Measure the text of the Issue's Key
                if (size.Width + margin > IssuesList.Columns[0].Width) //If this text is longer than all the others
                    IssuesList.Columns[0].Width = size.Width + margin; //Set the new column width to fit this text

                size = TextRenderer.MeasureText(list[i].Status, IssuesList.Font); //Measure the text of the Issue's Status
                if (size.Width + margin > IssuesList.Columns[1].Width) //If this text is longer than all the others
                    IssuesList.Columns[1].Width = size.Width + margin; //Set the new column width to fit this text

                /*size = TextRenderer.MeasureText(list[i].Summary, IssuesList.Font); //Measure the text of the Issue's Summary, but we will be changing this after this for loop exits anyway so this is practically useless. Yeah I'm just commenting this out
                if (size.Width + margin > IssuesList.Columns[2].Width) //If this text is longer than all the others
                    IssuesList.Columns[2].Width = size.Width + margin; //Set the new column width to fit this text*/

                size = TextRenderer.MeasureText(list[i].Created, IssuesList.Font); //Measure the text of the Issue's Created date
                if (size.Width + margin > IssuesList.Columns[3].Width) //If this text is longer than all the others
                    IssuesList.Columns[3].Width = size.Width + margin; //Set the new column width to fit this text

                size = TextRenderer.MeasureText(list[i].Reporter, IssuesList.Font); //Measure the text of the Issue's Reporter
                if (size.Width + margin > IssuesList.Columns[4].Width) //If this text is longer than all the others
                    IssuesList.Columns[4].Width = size.Width + margin; //Set the new column width to fit this text

                size = TextRenderer.MeasureText(list[i].Priority, IssuesList.Font); //Measure the text of the Issue's Priority
                if (size.Width + margin > IssuesList.Columns[5].Width) //If this text is longer than all the others
                    IssuesList.Columns[5].Width = size.Width + margin; //Set the new column width to fit this text

            } // ..|..
            int total = IssuesList.Columns[0].Width + IssuesList.Columns[1].Width + IssuesList.Columns[3].Width + IssuesList.Columns[4].Width + IssuesList.Columns[5].Width; //Add all the columns width's up
            if (IssuesList.Size.Width > total) //If the Width of the IssuesList is greater than the Total (which it always is)
                IssuesList.Columns[2].Width = IssuesList.Size.Width - total - margin; // Adjust the summary column to fill the rest of the width of the IssuesList (because I think it looks nice like that)

            if (listViewItems != null && listViewItems.Count() > 0)
                this.IssuesList.Items.AddRange(listViewItems); //Add all the new items to the ListView that I named IssuesList
                //Can you tell that I was upset about this section? Well I am because I had something that I couldn't get to work the way I wanted and had to change it.
                //Then it turns out that it doesn't work the same at all so I had to right this piece of crap to make it look the way that I wanted. It looks nice though
                //Thank you for reading my comments
        }

        #endregion

        // These are functions that help make the displaying data look cleaner
        #region Helper Functions

        /// <summary>
        /// Changes the name of the assignee/user: for example from 'csmith' to 'Chris Smith'
        /// </summary>
        /// <param name="assignee">The name of the assignee that you want to fix</param>
        /// <returns>Returns a fixed version of the name according to the data provided in Data.JiraNames</returns>
        public static string FixJiraName(string assignee = "")
        {
            if (assignee == null)
                return "";
            try
            {
                if (MainData.Instance.JiraNames != null) //Check if JiraNames is not null
                    foreach (JiraName j in MainData.Instance.JiraNames) //Go through a list of all of the JiraNames
                        if (assignee.ToLower().Trim() == j.From)
                            assignee = j.To;
                        //assignee = assignee.Replace(j.From, j.To); //Replace the From name (in the JiraName class) to the To name (also defined in the JiraName Class
            }
            catch { }
            return assignee; //Return assignee
        }
        
        #endregion

        private void JiraIssueBrowser_Load(object sender, EventArgs e)
        {
            LoadQueues(); //Load the queues
            this.Size = new Size(this.Size.Width + 1, this.Size.Height + 1); //This is to trigger the SizeChanged on the form and the Panels
            AllOpenButton_ClickAsync(sender, e); //Click the AllOpenButton
            if (Classes.Data.AdminControl.Control.View_Mode == Classes.Data.AdminControl.ViewMode.Advanced) //This is how I identify that I am the developer. Very secure
                button1.Visible = true; //Make the test jira ticket button visible
        }

        private void JiraIssueBrowser_SizeChanged(object sender, EventArgs e)
        {
            Splitter.Size = new Size(1, ClientSize.Height);
            TicketPanel.Size = new Size(ClientSize.Width - TicketPanel.Location.X, ClientSize.Height);
            IssueListPanel.Size = new Size(ClientSize.Width - IssueListPanel.Location.X, ClientSize.Height);
            MessageBuilderButton.Location = new Point(10, ClientSize.Height - MessageBuilderButton.Height - 10);
            JiraNamesButton.Location = new Point(10, MessageBuilderButton.Location.Y - JiraNamesButton.Height - 10);
            if (jiraComments != null)
                jiraComments.Size = new Size(TicketPanel.Size.Width - jiraComments.Location.X - 20, jiraComments.Size.Height);
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(Description.Text, Description.Font, new Size(TicketPanel.Width - Description.Location.X, 500), TextFormatFlags.TextBoxControl);
            //Description.Width = size.Width;
            Description.Height = size.Height;
        }

        private void TicketPanel_SizeChanged(object sender, EventArgs e)
        {
            TicketPanel.HorizontalScroll.Enabled = false;
            TicketPanel.HorizontalScroll.Visible = false;
            TicketPanel.AutoScrollPosition = Point.Empty;
            TicketPanel.AutoScroll = false;
            int margin = 20;
            CommentsSeperator.Size = new Size(TicketPanel.Size.Width - CommentsSeperator.Location.X - margin, 1);
            panel2.Size = new Size(TicketPanel.Size.Width - panel2.Location.X - margin, 1);
            RespondSeperator.Size = new Size(TicketPanel.Size.Width - RespondSeperator.Location.X - margin, 1);
            panel4.Size = new Size(TicketPanel.Size.Width - panel4.Location.X - margin, 1);
            Description.Size = new Size(TicketPanel.Size.Width - Description.Location.X - margin, Description.Size.Height);
            if(jiraComments != null)
                jiraComments.Size = new Size(TicketPanel.Size.Width - jiraComments.Location.X - margin, jiraComments.Height);

            AttachmentsPanel.AutoScrollPosition = Point.Empty;
            AttachmentsPanel.AutoScroll = false;
            AttachmentsPanel.Size = new Size(TicketPanel.Size.Width - AttachmentsPanel.Location.X - margin, AttachmentsPanel.Height);
            AttachmentsPanel.AutoScroll = true;

            RespondText.Size = new Size(TicketPanel.Size.Width - RespondText.Location.X - margin, RespondText.Height);

            label4.Location = new Point(TicketPanel.Size.Width / 2, label4.Location.Y);
            Status.Location = new Point(label4.Location.X + 74, Status.Location.Y);

            label6.Location = new Point(TicketPanel.Size.Width / 2, label6.Location.Y);
            Resolution.Location = new Point(label6.Location.X + 74, Resolution.Location.Y);

            label13.Location = new Point(TicketPanel.Size.Width / 2, label13.Location.Y);
            Assignee.Location = new Point(label13.Location.X + 74, Assignee.Location.Y);

            label14.Location = new Point(TicketPanel.Size.Width / 2, label14.Location.Y);
            Reporter.Location = new Point(label14.Location.X + 74, Reporter.Location.Y);

            label16.Location = new Point(TicketPanel.Size.Width / 2, label16.Location.Y);
            CreatedDate.Location = new Point(label16.Location.X + 74, CreatedDate.Location.Y);

            for(int i = 0; i < buttons.Count; i++)
            {
                if (i == 0)
                    buttons[i].Location = new Point(TicketPanel.Size.Width - buttons[i].Width - margin, buttons[i].Location.Y);
                else
                    buttons[i].Location = new Point(buttons[i - 1].Location.X - buttons[i].Width, buttons[i].Location.Y);
            }

            if(buttons.Count > 0)
                AssignButton.Location = new Point(buttons.Last().Location.X - AssignButton.Width, AssignButton.Location.Y);
            else
                AssignButton.Location = new Point(TicketPanel.Size.Width - AssignButton.Width, AssignButton.Location.Y);

            RespondButton.Location = new Point(TicketPanel.Size.Width - RespondButton.Width - margin, RespondButton.Location.Y);
            ResolveButton.Location = new Point(RespondButton.Location.X - ResolveButton.Width, ResolveButton.Location.Y);

            TicketPanel.AutoScroll = true;
        }

        bool isLoading = false;

        private async Task<bool> LoadData(Issue Issue)
        {
            this.SuspendLayout();
            this.Suspend();
            if (!Directory.Exists(Program.DataPath + "Jira\\" + Issue.Key.Value))
                Directory.CreateDirectory(Program.DataPath + "Jira\\" + Issue.Key.Value);

            TicketPanel.AutoScrollPosition = Point.Empty;
            KeyLink.Text = Issue.Key.Value;
            Title.Text = Issue.Summary;
            Type.Text = Issue.Type.Name;
            Priority.SelectedItem = Issue.Priority.Name;

            var fields = Issue.CustomFields;
            CustomerPhoneNumber.Text = "N/A";
            IssueID.Text = "N/A";
            JiraLocation.Text = "N/A";
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
                    /*case "customfield_10306":
                        ErrorCorrection.Text = c.Values.First();
                        break;*/
                    default:
                        break;
                }
            }

            Status.Text = Issue.Status.Name;
            Resolution.Text = "N/A";
            if (Issue.Resolution != null)
                Resolution.Text = Issue.Resolution.Name;
            if (Status.Text == "Resolved" || Status.Text == "Done")
                ResolveButton.Text = "Reopen Issue";
            else
                ResolveButton.Text = "Resolve this issue";
            if (Issue.Assignee != null)
            {
                if (Issue.Assignee.ToLower() == Setting.Value.Jira_Username.ToLower().Trim().Replace("@eccoviasolutions.com", ""))
                    AssignButton.Visible = false;
                else
                    AssignButton.Visible = true;
                Assignee.Text = FixJiraName(Issue.Assignee);
            }
            Reporter.Text = FixJiraName(Issue.Reporter);
            CreatedDate.Text = Issue.Created.Value.ToShortDateString() + " - " + Issue.Created.Value.ToShortTimeString();
            if (!isLoading)
            {
                RespondText.Text = "";
                isLoading = false;
            }
            Description.Text = Issue.Description;
            await AddComments(Issue);
            await AddAttachments(Issue);
            await AddButtons(Issue);
            UpdateLocations();
            this.Resume();
            this.ResumeLayout();
            return true;
        }

        public void UpdateLocations()
        {
            CommentsLabel.Location = new Point(CommentsLabel.Location.X, Description.Location.Y + Description.Size.Height + 2);
            CommentsSeperator.Location = new Point(CommentsSeperator.Location.X, CommentsLabel.Location.Y + (CommentsLabel.Size.Height / 2));

            if (jiraComments == null)
                return;
            jiraComments.Location = new Point(jiraComments.Location.X, CommentsLabel.Location.Y + CommentsLabel.Size.Height + 2);

            if (AttachmentsPanel == null)
                return;
            AttachmentsPanel.Location = new Point(AttachmentsPanel.Location.X, jiraComments.Location.Y + jiraComments.Size.Height + 5);

            RespondLabel.Location = new Point(RespondLabel.Location.X, AttachmentsPanel.Location.Y + AttachmentsPanel.Size.Height);
            RespondSeperator.Location = new Point(RespondSeperator.Location.X, RespondLabel.Location.Y + (RespondLabel.Size.Height / 2));

            RespondText.Location = new Point(RespondText.Location.X, RespondLabel.Location.Y + RespondLabel.Size.Height + 2);

            if (buttons == null || buttons.Count == 0)
            {
                AssignButton.Location = new Point(TicketPanel.Size.Width - AssignButton.Width - 20, RespondText.Location.Y + RespondText.Size.Height + 5);
                return;
            }
            AssignButton.Location = new Point(buttons.Last().Location.X - AssignButton.Width, RespondText.Location.Y + RespondText.Size.Height + 5);

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i > 0)
                    buttons[i].Location = new Point(buttons[buttons.Count - 1].Location.X - buttons[i].Size.Width, AssignButton.Location.Y);
                else
                    buttons[i].Location = new Point(TicketPanel.Width - buttons[i].Size.Width - 20, AssignButton.Location.Y);
            }
            TicketPanel_SizeChanged(null, null);
        }

        List<PictureBox> Attachments = new List<PictureBox>();
        List<Label> AttachmentNames = new List<Label>();

        private async Task<bool> AddAttachments(Issue issue)
        {
            for (int i = 0; i < Attachments.Count; i++)
            {
                AttachmentsPanel.Controls.Remove(Attachments[i]);
                Attachments[i].Image.Dispose();
                Attachments[i].Dispose();
                AttachmentsPanel.Controls.Remove(AttachmentNames[i]);
                AttachmentNames[i].Dispose();
            }
            Attachments.Clear();
            AttachmentNames.Clear();
            AttachmentsPanel.AutoScrollPosition = Point.Empty;
            AttachmentsPanel.AutoScroll = false;
            AttachmentsPanel.AutoScroll = true;

            int margin = 10;
            IEnumerable<Attachment> attachments = await issue.GetAttachmentsAsync();
            string[] files = Directory.GetFiles(Program.DataPath + "Jira\\" + issue.Key.Value);
            if(attachments.Count() < files.Length)
            {
                string[] a = new string[attachments.Count()];
                for (int i = 0; i < attachments.Count(); i++)
                    a[i] = Program.DataPath + "Jira\\" + issue.Key.Value + "\\" + attachments.ElementAt(i).FileName;

                var result = files.Except(a);
                for (int i = 0; i < result.Count(); i++)
                    if (File.Exists(result.ElementAt(i)))
                        File.Delete(result.ElementAt(i));
            }
            for (int i = 0; i < attachments.Count(); i++)
            {
                string file = Program.DataPath + "Jira\\" + issue.Key.Value + "\\" + attachments.ElementAt(i).FileName;
                if (!File.Exists(file))
                    await attachments.ElementAt(i).DownloadAsync(file);

                PictureBox picture = new PictureBox();
                picture.BorderStyle = BorderStyle.FixedSingle;
                try
                {
                    if (IsFileAnImage(file))
                        picture.Image = Image.FromFile(file);
                    else
                        picture.Image = Properties.Resources.Missing;
                }
                catch
                {
                    picture.Image = Properties.Resources.Missing;
                }
                picture.InitialImage = null;
                picture.Size = new Size(150, 100);
                picture.Location = new Point(i * picture.Size.Width + (margin * i) + (margin * 2), 22);
                picture.Name = "attachment" + i;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.TabStop = false;
                picture.Click += new EventHandler(attachment_Click);
                picture.MouseDown += new MouseEventHandler(Attachment_RightClick);
                Attachments.Add(picture);

                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                label.Name = "attachmentname" + i;
                label.Text = attachments.ElementAt(i).FileName;
                label.Size = new Size(TextRenderer.MeasureText(label.Text, label.Font).Width, 13);
                label.Location = new Point(picture.Location.X + (picture.Size.Width / 2) - (label.Size.Width / 2), 125);
                AttachmentNames.Add(label);
            }

            for(int i = 0; i < Attachments.Count; i++)
            {
                AttachmentsPanel.Controls.Add(Attachments[i]);
                AttachmentsPanel.Controls.Add(AttachmentNames[i]);
            }
            return true;
        }

        private bool IsFileAnImage(string file)
        {
            List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
            if (ImageExtensions.Contains(Path.GetExtension(file).ToUpperInvariant()))
            {
                return true;
            }
            return false;
        }

        private void attachment_Click(object sender, EventArgs e)
        {
            string file = Program.DataPath + "Jira\\" + CurrentIssue.Key.Value + "\\" + AttachmentNames[Attachments.IndexOf((PictureBox)sender)].Text;
            if(File.Exists(file))
                Process.Start(file);
        }

        int SelectedAttachment = -1;

        private void Attachment_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            PictureBox attachment = (PictureBox)sender;
            SelectedAttachment = Attachments.IndexOf(attachment);
            RightClickAttachment.Show(Cursor.Position);
            RightClickAttachment.Visible = true;
        }

        private async void DeleteAttachment_ClickAsync(object sender, EventArgs e)
        {
            await RemoveAttachment();
        }

        private async Task<bool> RemoveAttachment()
        {
            try
            {
                bool done = false;
                foreach (Attachment a in await CurrentIssue.GetAttachmentsAsync())
                {
                    if (!done && a.FileName == AttachmentNames[SelectedAttachment].Text)
                    {
                        await CurrentIssue.DeleteAttachmentAsync(a);
                        done = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete attachment - " + e.Message);
            }
            await AddAttachments(CurrentIssue);
            SelectedAttachment = -1;
            return true;
        }

        List<Button> buttons = new List<Button>();

        private async Task<bool> AddButtons(Issue issue)
        {
            IEnumerable<JiraNamedEntity> actions = await issue.GetAvailableActionsAsync();
            foreach (Button b in buttons)
            {
                TicketPanel.Controls.Remove(b);
                b.Dispose();
            }
            buttons.Clear();
            foreach (JiraNamedEntity j in actions)
            {
                Button button = new Button();
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
                button.FlatAppearance.MouseOverBackColor = Color.Silver;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                button.Size = new Size(TextRenderer.MeasureText(j.Name, button.Font).Width + 10, 27);
                if (buttons.Count > 0)
                    button.Location = new Point(buttons[buttons.Count - 1].Location.X - button.Size.Width, AssignButton.Location.Y);
                else
                    button.Location = new Point(TicketPanel.Width - button.Size.Width - 20, AssignButton.Location.Y);
                button.Name = j.Name.Replace(" ", "") + "Button";
                button.TabIndex = 172;
                button.Text = j.Name;
                button.UseVisualStyleBackColor = true;
                button.Click += new EventHandler(button_ClickAsync);
                buttons.Add(button);
            }
            foreach (Button b in buttons)
                TicketPanel.Controls.Add(b);

            AssignButton.Location = new Point(buttons.Last().Location.X - AssignButton.Width, AssignButton.Location.Y);
            return true;
        }

        private async void button_ClickAsync(object sender, EventArgs e)
        {
            if (CheckResponse())
            {
                await Transition((Button)sender);
            }
        }

        private async Task<bool> Transition(Button button)
        {
            if (button.Text == "Resolve this issue")
            {
                if (MessageBox.Show("Resolving tickets is currently disabled due to problems. Would you like to be redirected to the web version to resolve this ticket?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Setting.Value.Jira_Link + "browse/" + KeyLink.Text);
                }
                return true;
            }
            Issue issue = CurrentIssue;
            await Respond();
            await issue.WorkflowTransitionAsync(button.Text);
            if (button.Text == "Resolve this issue")
            {
                issue.Resolution = new IssueResolution("10000", "Done");
                await issue.SaveChangesAsync();
            }
            await LoadData(issue);
            return true;
        }

        JiraCommentController jiraComments;

        private async Task<bool> AddComments(Issue Issue)
        {
            if (jiraComments != null)
            {
                jiraComments.DisposeAll();
                TicketPanel.Controls.Remove(jiraComments);
                jiraComments.Dispose();
            }
            jiraComments = new JiraCommentController(this, CurrentIssue);
            IEnumerable <Comment> comments = await Issue.GetCommentsAsync();
            jiraComments.AutoScroll = true;
            jiraComments.HorizontalScroll.Enabled = false;
            jiraComments.HorizontalScroll.Visible = false;
            jiraComments.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jiraComments.BackColor = System.Drawing.Color.White;
            jiraComments.Location = new System.Drawing.Point(14, 410);
            jiraComments.Name = "JiraComments";
            jiraComments.Size = new System.Drawing.Size(TicketPanel.Size.Width - jiraComments.Location.X - 20, 175);
            jiraComments.CommentCollection = comments.ToList<Comment>();
            TicketPanel.Controls.Add(jiraComments);
            UpdateLocations();
            return true;
        }

        public string GetFirstLastName(string text)
        {
            string[] name = text.Split(' ');
            if (name != null && name.Length > 1)
                return name[0] + " " + name[1];
            else if (name != null && name.Length == 1)
                return name[0];
            return text;
        }

        public async Task<bool> NavigateToIssueByKey(string key)
        {
            if (Issues.Count == 0)
                await GetIssues("Project = LAC AND key = " + key);
            Issue issue = GetIssueByKey(key);
            if (issue != null)
            {
                await LoadData(issue);
                IssueListPanel.Visible = false;
                TicketPanel.Visible = true;
            }
            return true;
        }

        public void AddPremadeResponse()
        {
            if (Setting.Value.Jira_Responses == null)
            {
                isLoading = true;
                TicketPanel.ScrollControlIntoView(RespondText);
                return;
            }
            if (Setting.Value.Jira_Responses != null && Setting.Value.Jira_Responses.Count > 1)
            {
                Random r = new Random();
                int rand = r.Next(Setting.Value.Jira_Responses.Count);
                RespondText.Text = Setting.Value.Jira_Responses[rand].Replace("\r\n", "\n").Replace("\n", Environment.NewLine); ;
            }
            else if (Setting.Value.Jira_Responses.Count == 1)
            {
                RespondText.Text = Setting.Value.Jira_Responses[0].Replace("\r\n", "\n").Replace("\n", Environment.NewLine); ;
            }
            else if (Setting.Value.Jira_Response != null && Setting.Value.Jira_Response != "")
            {
                RespondText.Text = Setting.Value.Jira_Response.Replace("\r\n", "\n").Replace("\n", Environment.NewLine); ;
            }
            isLoading = true;
            TicketPanel.ScrollControlIntoView(RespondText);
        }

        private Issue GetIssueByKey(string key)
        {
            foreach (Issue i in Issues)
                if (i.Key.Value == key)
                    return i;
            return null;
        }

        private void KeyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Setting.Value.Jira_Link + "browse/" + KeyLink.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Setting.Value.Jira_Link + "browse/LAC");
        }

        private void IssueListPanel_Resize(object sender, EventArgs e)
        {
            IssuesList.Location = new Point(10, 30);
            IssuesList.Size = new Size(IssueListPanel.Size.Width - IssuesList.Location.X, IssueListPanel.Size.Height - IssuesList.Location.Y);
            int total = IssuesList.Columns[0].Width;
            total += IssuesList.Columns[1].Width;
            total += IssuesList.Columns[3].Width;
            total += IssuesList.Columns[4].Width;
            total += IssuesList.Columns[5].Width;
            if (IssuesList.Size.Width > total)
                IssuesList.Columns[2].Width = IssuesList.Size.Width - total - 5;
            NoIssuesLabel.Location = new Point((IssueListPanel.Size.Width / 2) - (NoIssuesLabel.Size.Width / 2), (IssueListPanel.Size.Height / 2) - (NoIssuesLabel.Size.Height / 2));
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            AssignButtonPress();
        }

        private async void AssignButtonPress()
        {
            if (CheckResponse())
                await AssignAndRespond();
            
            await LoadData(CurrentIssue);
        }

        private void RespondButton_Click(object sender, EventArgs e)
        {
            RespondButtonPress();
        }

        private async void RespondButtonPress()
        {
            if (CheckResponse())
            {
                await Respond();
            }

            await LoadData(CurrentIssue);
        }

        private bool CheckResponse()
        {
            if (RespondText.Text.Trim() == "")
                if (MessageBox.Show("Are you sure you want to submit without responding to the issue?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return false;
            return true;
        }

        private async Task<bool> AssignAndRespond()
        {
            bool respond = await Assign(CurrentIssue, Setting.Value.Jira_Username.Replace("@eccoviasolutions.com", ""));
            if(respond)
                return await Respond();
            return respond;
        }

        private async Task<bool> Respond()
        {
            if (RespondText.Text == null || RespondText.Text == "" || RespondText.Text.Length <= 0)
                return false;
            await CurrentIssue.AddCommentAsync(RespondText.Text.Trim());
            Setting.Value.Jira_Response = RespondText.Text;
            Setting.Save();
            RespondText.Text = "";
            await AddComments(CurrentIssue);
            return true;
        }

        private async Task<bool> Assign(Issue Issue, string assignee)
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
            {
                MessageBox.Show("This ticket has already been assigned to " + Issue.Assignee);
                ret = false;
            }
            Assignee.Text = Issue.Assignee;
            return ret;
        }

        MessageBuilder MessageBuilder = new MessageBuilder();

        private void MessageBuilderButton_Click(object sender, EventArgs e)
        {
            if (MessageBuilder.IsDisposed)
                MessageBuilder = new MessageBuilder();
            MessageBuilder.Show();
        }

        readonly string[] Commands = { "phone", "reporter", "champ" };

        private void RespondText_TextChanged(object sender, EventArgs e)
        {
            if(RespondText.Text.Contains('{') && RespondText.Text.Contains('}'))
            {
                Match match = Regex.Match(RespondText.Text, @"\{(.*?)(,?)(\d?)\}");
                if (match.Success)
                {
                    foreach (string s in Commands)
                    {
                        if (match.Value.Contains(s))
                        {
                            string command = "";
                            if (match.Value.IndexOf(',') > 0)
                                command = match.Value.Replace("{", "").Replace("}", "").Remove(match.Value.IndexOf(',') - 1);
                            else
                                command = match.Value.Replace("{", "").Replace("}", "");

                            string param = match.Value.Replace(command, "").Replace("{", "").Replace(",","").Replace("}", "");
                            HandleCommand(command, param);
                        }
                    }
                }
            }
        }

        private void HandleCommand(string command, string param = "")
        {
            string newText = "{" + command + (param != "" ? "," + param : "") + "}";
            string replace = newText;

            switch (command.ToLower())
            {
                case "phone":
                    if (param != "")
                    {
                        int i = -1;
                        bool isInt = int.TryParse(param, out i);
                        string[] split = CustomerPhoneNumber.Text.Split(' ');
                        if(isInt && i < split.Length && i >= 0)
                        {
                            newText = split[i].Replace(',', ' ');
                        }
                    }
                    else
                        newText = CustomerPhoneNumber.Text;
                    break;
                case "reporter":
                    newText = Reporter.Text;
                    break;
                case "champ":
                    newText = IssueID.Text;
                    break;
            }

            RespondText.Text = RespondText.Text.Replace(replace, newText).Trim();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            ActiveQueue = -1;
            QueueLabel.Text = "CT-3546 Test";
            await GetIssues("key = CT-3546");
            CalcButtons();
        }

        private void AttachmentsPanel_SizeChanged(object sender, EventArgs e)
        {
            if(Attachments.Count > 0 && Attachments.Last().Location.X + Attachments.Last().Width > AttachmentsPanel.Width)
                panel5.Size = new Size(Attachments.Last().Location.X + Attachments.Last().Width - panel5.Location.X, 1);
            else
                panel5.Size = new Size(AttachmentsPanel.Width - panel5.Location.X, 1);
            dropLabel.Location = new Point((AttachmentsPanel.Width / 2) - (dropLabel.Width / 2), (AttachmentsPanel.Height / 2) - (dropLabel.Height / 2));
        }

        private void AttachmentsPanel_DragEnter(object sender, DragEventArgs e)
        {
            AttachmentsPanel.BackColor = Color.Silver;
            dropLabel.Visible = true;
            e.Effect = DragDropEffects.Copy;
        }

        private void AttachmentsPanel_DragLeave(object sender, EventArgs e)
        {
            AttachmentsPanel.BackColor = Color.White;
            dropLabel.Visible = false;
        }

        private async void AttachmentsPanel_DragDropAsync(object sender, DragEventArgs e)
        {
            AttachmentsPanel.BackColor = Color.White;
            dropLabel.Visible = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            await UploadAttachments(files);
        }

        private async Task<bool> UploadAttachments(string[] files)
        {
            if (files != null && files.Length > 0)
            {
                List<UploadAttachmentInfo> list = new List<UploadAttachmentInfo>();
                foreach (string s in files)
                {
                    if (File.Exists(s))
                    {
                        FileInfo info = new FileInfo(s);
                        UploadAttachmentInfo upload = new UploadAttachmentInfo(info.Name, File.ReadAllBytes(s));
                        list.Add(upload);
                    }
                }
                if(list.Count > 0)
                    await CurrentIssue.AddAttachmentAsync(list.ToArray());
            }
            await AddAttachments(CurrentIssue);
            return true;
        }

        private async void Priority_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            await SetPriority();
        }

        /// <summary>
        /// Change the priority of the issue that they are currently on
        /// </summary>
        /// <returns></returns>
        private async Task<bool> SetPriority()
        {
            IssuePriority priority = new IssuePriority((Priority.SelectedIndex + 1).ToString(), Priority.SelectedText);
            CurrentIssue.Priority = priority;
            await CurrentIssue.SaveChangesAsync();
            await LoadData(CurrentIssue);
            return true;
        }

        /// <summary>
        /// When you double click on an item in the issue queue this even will trigger
        /// </summary>
        private async void IssuesList_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = IssuesList.HitTest(e.X, e.Y); //Get the HitTest info from where they double clicked
            ListViewItem item = info.Item; //Get the item that the user double clicked

            if (item != null) //If the item is not null/exists
            {
                await NavigateToIssueByKey(item.Text); //Call the function to navigate to an issue # using the item.Text which is set to LAC-# when the queue loads. The function handles the rest
            }
        }

        /// <summary>
        /// When you hit CTRL + A, it will select all the text in the repsonse textbox because it doesn't do it by default
        /// </summary>
        private void RespondText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) //Did the user hit CTRL + A
            {
                if (sender != null) //Check if the sender is not null
                    ((TextBox)sender).SelectAll(); //Select all the text from the sender object (in this case it is the RespondText element
            }
        }

        /// <summary>
        /// When the form is closing, dipose all of the memory intensive stuff like the attachment images
        /// </summary>
        private void JiraIssueBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < Attachments.Count; i++) //Loop through all of the attachments currently loaded
            {
                AttachmentsPanel.Controls.Remove(Attachments[i]); //Remove the attachment from the panel
                Attachments[i].Image.Dispose(); //Dispose the attachment images
                Attachments[i].Dispose(); //Dispose the attachment
                AttachmentsPanel.Controls.Remove(AttachmentNames[i]); //Remove the Picturebox from the control
                AttachmentNames[i].Dispose(); //Dispose the label
            }
        }

        private void JiraNamesButton_Click(object sender, EventArgs e)
        {
            new JiraNames().Show();
        }

        private void IssuesList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.Graphics == null)
                return;
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font(IssuesList.Font, FontStyle.Bold))
                {
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    e.Graphics.FillRectangle(new SolidBrush(Setting.Value.CurrentTheme.Background), e.Bounds);
                    e.Graphics.FillRectangle(new SolidBrush(Setting.Value.CurrentTheme.Foreground), new Rectangle(e.Bounds.X, e.Bounds.Y, 1, e.Bounds.Height));
                    e.Graphics.DrawString(e.Header.Text, headerFont, new SolidBrush(Setting.Value.CurrentTheme.Foreground), e.Bounds, sf);
                }
            }
        }

        private void IssuesList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (e.Graphics == null)
                return;
            ListView listView = (ListView)sender;

            // Check if e.Item is selected and the ListView has a focus.
            if (!listView.Focused && e.Item.Selected)
            {
                Rectangle rowBounds = e.Bounds;
                int leftMargin = e.Item.GetBounds(ItemBoundsPortion.Label).Left;
                Rectangle bounds = new Rectangle(leftMargin, rowBounds.Top, rowBounds.Width - leftMargin, rowBounds.Height);
                e.Graphics.FillRectangle(new SolidBrush(Setting.Value.CurrentTheme.SelectedBackground), bounds);
            }
            else
                e.DrawDefault = true;
        }

        private void IssuesList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Graphics == null)
                return;
            const int TEXT_OFFSET = 1;    // I don't know why the text is located at 1px to the right. Maybe it's only for me.

            ListView listView = (ListView)sender;

            // Check if e.Item is selected and the ListView has a focus.
            if (!listView.Focused && e.Item.Selected)
            {
                Rectangle rowBounds = e.SubItem.Bounds;
                Rectangle labelBounds = e.Item.GetBounds(ItemBoundsPortion.Label);
                int leftMargin = labelBounds.Left - TEXT_OFFSET;
                Rectangle bounds = new Rectangle(rowBounds.Left + leftMargin, rowBounds.Top, e.ColumnIndex == 0 ? labelBounds.Width : (rowBounds.Width - leftMargin - TEXT_OFFSET), rowBounds.Height);
                TextFormatFlags align;
                switch (listView.Columns[e.ColumnIndex].TextAlign)
                {
                    case HorizontalAlignment.Right:
                        align = TextFormatFlags.Right;
                        break;
                    case HorizontalAlignment.Center:
                        align = TextFormatFlags.HorizontalCenter;
                        break;
                    default:
                        align = TextFormatFlags.Left;
                        break;
                }
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, listView.Font, bounds, SystemColors.HighlightText,
                    align | TextFormatFlags.SingleLine | TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.WordEllipsis);
            }
            else
                e.DrawDefault = true;
        }
    }
}
