using Atlassian.Jira;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Jira
{
    public partial class JiraData : Form
    {
        public JiraData()
        {
            InitializeComponent();
        }

        private List<Issue> Issues = new List<Issue>();

        private JiraDataSave CurrentJiraDataSave
        {
            get
            {
                if (Setting.Value.JiraData_List.Count > 0 && savedQueries.SelectedIndex > -1)
                {
                    foreach (JiraDataSave j in Setting.Value.JiraData_List)
                    {
                        if (j.Name == savedQueries.SelectedItem.ToString())
                            return j;
                    }
                }
                return new JiraDataSave();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://confluence.atlassian.com/jiracore/blog/2015/07/search-jira-like-a-boss-with-jql");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadIssues(JQL.Text);
        }

        private async void LoadIssues(string jql)
        {
            infoLabel.ForeColor = Color.Black;
            infoLabel.Text = "Loading";
            IPagedQueryResult<Issue> issues = null;
            try
            {
                if (StaticHandler._Main != null)
                {
                    StaticHandler._Main._Jira.Issues.MaxIssuesPerRequest = (int)maxIssuesPerRequest.Value;
                    issues = await StaticHandler._Main._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues
                }
                if (StaticHandler._ThemedMain != null)
                {
                    JiraChecker._Jira.Issues.MaxIssuesPerRequest = (int)maxIssuesPerRequest.Value;
                    issues = await JiraChecker._Jira.Issues.GetIssuesFromJqlAsync(jql); //Attempt to pull the issues
                }
                infoLabel.Text = "Loaded " + issues.Count<Issue>() + " issues";
                infoLabel.ForeColor = Color.Black;
                Issues.Clear();
                Issues.AddRange(issues);
                PopulateLists();
            }
            catch (Exception e)
            {
                infoLabel.Text = "Failed to load";
                MessageBox.Show(e.Message);
                infoLabel.ForeColor = Color.Red;
            }

            this.Size = new Size(461, 433);
        }

        private void PopulateLists()
        {
            if(Issues.Count > 0)
            {
                List<string> baseList = "Project Name,Key,Assignee,Components,Created,Description,Fix Versions,Labels,Priority,Reporter,Creator,First Response,Resolution,Resolution Date,Status,Summary,Updated,Fix Versions Is Released,Fix Versions Release Date".Split(new char[] { ',' }).ToList();
                dataList.Items.Clear();
                foreach (string s in CurrentJiraDataSave.Columns)
                {
                    dataList.Items.Add(s);
                    if (CurrentJiraDataSave.SelectedColumns.Contains(s))
                        dataList.SetSelected(dataList.Items.Count - 1, true);
                }

                List<string> customFields = new List<string>();
                foreach(Issue issue in Issues)
                {
                    CustomFieldValueCollection labelCollection = issue.CustomFields;
                    foreach (var obj in labelCollection)
                    {
                        if (!customFields.Contains(obj.Name))
                            customFields.Add(obj.Name);
                    }

                }

                foreach(string s in baseList)
                {
                    if (!dataList.Items.Cast<string>().Contains(s))
                        dataList.Items.Add(s);
                }
                
                foreach(string s in customFields)
                {
                    if (!dataList.Items.Cast<string>().Contains(s))
                        dataList.Items.Add(s);
                }
                //dataList.Items.AddRange()

                ticketList.ClearSelected();
                ticketList.Items.Clear();
                if (ticketList.Items.Count > 0)
                    return;
                for (int i = 0; i < Issues.Count; i++)
                {
                    //if (!ticketList.Items.Cast<string>().Contains(Issues[i].Key.Value))
                        ticketList.Items.Add(Issues[i].Key.Value);
                    if(!CurrentJiraDataSave.DeSelectedIssues.Contains(Issues[i].Key.Value))
                        ticketList.SetSelected(i, true);
                }
            }
        }

        private async Task<string> GetValueFromIssue(Issue issue, string field)
        {
            string str = "";
            switch(field)
            {
                /*case "Affects Versions":
                    str = string.Join(", ", issue.AffectsVersions);
                    break;*/
                case "Project Name":
                    if (issue.Project == "LAC")
                        str = "LA County";
                    else if (issue.Project == "CT")
                        str = "ClientTrack";
                    break;
                case "Assignee":
                    str = issue.Assignee;
                    break;
                case "First Response":
                    IEnumerable<Comment> comments = await issue.GetCommentsAsync();
                    if (comments != null && comments.Count() > 0)
                    {
                        DateTime earliest = DateTime.MaxValue;
                        foreach(Comment c in comments)
                        {
                            if (c.CreatedDate.Value.CompareTo(earliest) < 0)
                                earliest = c.CreatedDate.Value;
                        }
                        if (earliest == DateTime.MaxValue)
                            str = "";
                        else
                            str = earliest.ToString(dateTimeFormat.Text);
                    }
                    else
                        str = "";
                    break;
                case "Components":
                    str = string.Join(", ", issue.Components.Select(a=>a.Name));
                    break;
                case "Created":
                    if (issue.Created != null)
                        str = issue.Created.Value.ToString(dateTimeFormat.Text);
                    break;
                case "Description":
                    str = issue.Description;
                    break;
                /*case "Due Date":
                    if(issue.DueDate != null)
                        str = issue.DueDate.Value.ToString("MM/dd/yyyy hh:mm:ss");
                    break;
                case "Environment":
                    str = issue.Environment;
                    break;*/
                case "Fix Versions":
                    str = string.Join(", ", issue.FixVersions.Select(a => a.Name));
                    break;
                case "Fix Versions Is Released":
                    str = string.Join(", ", issue.FixVersions.Select(a => a.IsReleased));
                    break;
                case "Fix Versions Release Date":
                    if (issue.FixVersions != null)
                        str = string.Join(", ", issue.FixVersions.Select(a => a.ReleasedDate.Value.ToString(dateTimeFormat.Text)));
                    break;
                case "Key":
                    if (issue.Key != null)
                        str = issue.Key.Value;
                    break;
                case "Labels":
                    str = string.Join(", ", issue.Labels);
                    break;
                /*case "Parent Issue Key":
                    str = issue.ParentIssueKey;
                    break;*/
                case "Priority":
                    if (issue.Priority != null)
                        str = issue.Priority.Name;
                    break;
                case "Reporter":
                    str = issue.Reporter;
                    break;
                case "Creator":
                    str = issue.Reporter;
                    break;
                case "Resolution":
                    if (issue.Resolution != null)
                        str = issue.Resolution.Name;
                    break;
                case "Resolution Date":
                    if (issue.ResolutionDate != null)
                        str = issue.ResolutionDate.Value.ToString(dateTimeFormat.Text);
                    break;
                case "Status":
                    if (issue.Status != null)
                        str = issue.Status.Name;
                    break;
                case "Summary":
                    str = issue.Summary;
                    break;
                case "Updated":
                    if (issue.Updated != null)
                        str = issue.Updated.Value.ToString(dateTimeFormat.Text);
                    break;
                case "Last Viewed":
                    //str = issue.Project
                    break;
                default:
                    foreach(CustomFieldValue s in issue.CustomFields)
                    {
                        if(field.Trim() == s.Name.Trim())
                        {
                            str = string.Join(", ", s.Values);
                        }
                    }
                    break;
            }

            if (str == null)
                str = "";

            return str;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (rememberSettings.Checked)
            {
                List<string> deselected = new List<string>();
                List<string> items = ticketList.Items.Cast<string>().ToList();
                List<string> selectedItems = ticketList.SelectedItems.Cast<string>().ToList();
                foreach (string s in items)
                    if (!selectedItems.Contains(s))
                        deselected.Add(s);
                JiraDataSave j = new JiraDataSave()
                {
                    JQLQuery = JQL.Text,
                    MaxIssuesPerRequest = (int)maxIssuesPerRequest.Value,
                    DateTimeFormat = dateTimeFormat.Text,
                    DeSelectedIssues = deselected,
                    Columns = dataList.Items.Cast<string>().ToList(),
                    SelectedColumns = dataList.SelectedItems.Cast<string>().ToList(),
                    Name = SaveName.Text
                };

                if (Setting.Value.JiraData_List.Select(l => l.Name).Contains(j.Name))
                    Setting.Value.JiraData_List[Setting.Value.JiraData_List.Select(l => l.Name).ToList().IndexOf(j.Name)] = j;
                else
                    Setting.Value.JiraData_List.Add(j);

                Setting.Save();

                JiraData_Load(sender, e);

                
            }

            Setting.Save();
            
            XSSFWorkbook wb = await BuildWorkBook();

            ExportData(wb);
        }

        private async Task<XSSFWorkbook> BuildWorkBook()
        {
            XSSFWorkbook wb = new XSSFWorkbook();

            wb.CreateSheet();
            
            List<string> columns = new List<string>();
            foreach(string s in dataList.SelectedItems.Cast<string>().ToList())
                columns.Add(s);

            List<Issue> issues = new List<Issue>();
            foreach (string s in ticketList.SelectedItems)
                issues.Add(GetIssueByKey(s));
            

            for (int i = 0; i < columns.Count; i++)
            {
                if (i == 0)
                {
                    wb.GetSheetAt(0).CreateRow(0).CreateCell(i).SetCellValue(columns[i]);
                }
                else
                {
                    wb.GetSheetAt(0).GetRow(0).CreateCell(i).SetCellValue(columns[i]);
                }
                for (int j = 0; j < issues.Count; j++)
                {
                    if (i == 0)
                    {
                        wb.GetSheetAt(0).CreateRow(j + 1).CreateCell(i).SetCellValue(await GetValueFromIssue(issues[j], columns[i]));
                    }
                    else
                    {
                        wb.GetSheetAt(0).GetRow(j + 1).CreateCell(i).SetCellValue(await GetValueFromIssue(issues[j], columns[i]));
                    }
                }

            }

            return wb;
        }

        private void ExportData(XSSFWorkbook wb)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Export an Excel File";

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                // Saves the Image in the appropriate ImageFormat based upon the  
                // File type selected in the dialog box.  
                // NOTE that the FilterIndex property is one-based.  
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        using (var file = fs)
                        {
                            wb.Write(file);
                            file.Close();
                        }
                        break;
                }
                fs.Close();
            }
        }

        private Issue GetIssueByKey(string key)
        {
            foreach (Issue i in Issues)
                if (i.Key.Value == key)
                    return i;
            return null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Deselect All")
            {
                for (int i = 0; i < dataList.Items.Count; i++)
                {
                    dataList.SetSelected(i, false);
                }
                button3.Text = "Select All";
            }
            else
            {
                for (int i = 0; i < dataList.Items.Count; i++)
                {
                    dataList.SetSelected(i, true);
                }
                button3.Text = "Deselect All";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Deselect All")
            {
                for (int i = 0; i < ticketList.Items.Count; i++)
                {
                    ticketList.SetSelected(i, false);
                }
                button4.Text = "Select All";
            }
            else
            {
                for (int i = 0; i < ticketList.Items.Count; i++)
                {
                    ticketList.SetSelected(i, true);
                }
                button4.Text = "Deselect All";
            }
        }

        bool isMovingItems = false;
        List<string> selectedItems = new List<string>();

        private void toggleUpDown_Click(object sender, EventArgs e)
        {
            isMovingItems = !isMovingItems;
            if(isMovingItems)
            {
                selectedItems.AddRange(dataList.SelectedItems.Cast<string>().ToList());
                dataList.SelectionMode = SelectionMode.One;
                dataList.SelectedIndex = -1;

                toggleUpDown.BackColor = Color.LightGray;
                up.Enabled = true;
                down.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                dataList.SelectedIndex = -1;
                dataList.SelectionMode = SelectionMode.MultiSimple;
                for (int i = 0; i < dataList.Items.Count; i++)
                {
                    foreach(string s in selectedItems)
                    {
                        if(dataList.Items[i].ToString() == s)
                            dataList.SetSelected(i, true);
                    }
                }

                toggleUpDown.BackColor = Color.White;
                up.Enabled = false;
                down.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataList.SelectedIndex;
            if (selectedIndex > 0)
            {
                dataList.Items.Insert(selectedIndex - 1, dataList.Items[selectedIndex]);
                dataList.Items.RemoveAt(selectedIndex + 1);
                dataList.SelectedIndex = selectedIndex - 1;
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataList.SelectedIndex;
            if (selectedIndex < dataList.Items.Count - 1 & selectedIndex != -1)
            {
                dataList.Items.Insert(selectedIndex + 2, dataList.Items[selectedIndex]);
                dataList.Items.RemoveAt(selectedIndex);
                dataList.SelectedIndex = selectedIndex + 1;

            }
        }

        private void JiraData_Load(object sender, EventArgs e)
        {
            if(Setting.Value.JiraData_List.Count > 0)
            {
                savedQueries.Items.Clear();
                savedQueries.Items.AddRange(Setting.Value.JiraData_List.Select(l => l.Name).ToArray());
            }
            else
            {
                savedQueries.Items.Clear();
                savedQueries.ResetText();
                SaveName.Text = "";
            }
        }

        private void JQL_TextChanged(object sender, EventArgs e)
        {
            JQL.Text = HttpUtility.UrlDecode(JQL.Text);
        }

        private void rememberSettings_CheckedChanged(object sender, EventArgs e)
        {
            SaveNameLabel.Visible = rememberSettings.Checked;
            SaveName.Visible = rememberSettings.Checked;
        }

        private void savedQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(savedQueries.SelectedIndex > -1)
            {
                button5.Enabled = true;
                rememberSettings.Checked = true;
                SaveName.Text = CurrentJiraDataSave.Name;
                JQL.Text = CurrentJiraDataSave.JQLQuery;
                dateTimeFormat.Text = CurrentJiraDataSave.DateTimeFormat;
                maxIssuesPerRequest.Value = CurrentJiraDataSave.MaxIssuesPerRequest;
                ticketList.Items.Clear();
                dataList.Items.Clear();
                this.Size = new Size(461, 157);
                infoLabel.Text = "";
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (savedQueries.SelectedIndex > -1)
            {
                int selected = savedQueries.SelectedIndex;
                Setting.Value.JiraData_List.RemoveAt(selected);
                Setting.Save();
                JiraData_Load(sender, e);
                savedQueries.SelectedText = "";
                if (savedQueries.Items.Count >= 0 && selected - 1 >= 0)
                    savedQueries.SelectedIndex = selected - 1;
                else
                {
                    savedQueries.SelectedIndex = -1;
                    //savedQueries.ResetText();
                }
            }
            else
            {
                button5.Enabled = false;
            }
        }
    }
}
