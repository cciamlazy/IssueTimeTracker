using Be.Timvw.Framework.ComponentModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class LogBrowser : Form
    {
        public LogBrowser()
        {
            InitializeComponent();
        }

        SortableBindingList<Day> days = new SortableBindingList<Day>();

        bool isInDays = true;
        bool isInDay = false;
        bool isInIssueNumber = false;
        bool isUsingDayFilter = false;
        bool isUsingTaskFilter = false;
        int selectedDayIndex;

        private void LogBrowser_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(this.ClientSize.Width + 1, this.ClientSize.Height + 1);
            this.dataGrid.AutoGenerateColumns = true;

            string[] files = Directory.GetFiles(Program.DataPath + "\\TaskData\\");
            
            foreach(String s in files)
            {
                days.Add(TaskTracker.LoadDay(s));
            }
            
            dataGrid.DataSource = days;
            dataGrid.Sort(this.dataGrid.Columns["DayID"], ListSortDirection.Descending);
            //dataGrid.Columns["DayID"].Visible = false;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (isInDays)
                {
                    if (e.RowIndex < days.Count)
                    {
                        dataGrid.DataSource = ToSortableList(days[e.RowIndex].Tasks);
                        dataGrid.Sort(this.dataGrid.Columns["TaskID"], ListSortDirection.Ascending);
                        //dataGrid.Columns["TaskID"].Visible = false;
                        selectedDayIndex = e.RowIndex;
                        isInDays = false;
                        isInDay = true;
                        isInIssueNumber = false;
                        isUsingDayFilter = false;
                        isUsingTaskFilter = false;
                        dataGrid.Columns[0].ToolTipText = "View all the tasks with the same issue";
                        dataGrid.Columns[0].HeaderText = "View Issue";
                        backButton.Enabled = true;
                        toTopButton.Enabled = true;
                        if (!isUsingDayFilter)
                            TaskFilterButton.Enabled = true;
                        this.Text = "Log Browser - " + days[selectedDayIndex].LongDate;
                    }
                }
                else if (isInDay)
                {
                    this.Text = "Log Browser - " + days[selectedDayIndex].Tasks[e.RowIndex].IssueNumber;
                    dataGrid.DataSource = ToSortableList(BuildIssueList(days[selectedDayIndex].Tasks[e.RowIndex].IssueNumber));
                    dataGrid.Sort(this.dataGrid.Columns["TaskID"], ListSortDirection.Ascending);
                    //dataGrid.Columns["TaskID"].Visible = false;
                    isInDays = false;
                    isInDay = false;
                    isInIssueNumber = true;
                    isUsingDayFilter = false;
                    isUsingTaskFilter = false;
                    dataGrid.Columns[0].Visible = false;
                    if (!isUsingDayFilter)
                        TaskFilterButton.Enabled = true;
                }
            }
        }

        private List<Task> BuildIssueList(string issue)
        {
            List<Task> tasks = new List<Task>();
            foreach(Day d in days)
            {
                foreach(Task t in d.Tasks)
                {
                    if (t.IssueNumber.Equals(issue))
                        tasks.Add(t);
                }
            }
            return tasks;
        }

        private SortableBindingList<Task> ToSortableList(List<Task> tasks)
        {
            SortableBindingList<Task> sortTasks = new SortableBindingList<Task>();
            foreach(Task t in tasks)
            {
                sortTasks.Add(t);
            }
            return sortTasks;
        }

        private void LogBrowser_SizeChanged(object sender, EventArgs e)
        {
            dataGrid.Size = this.ClientSize - new Size(0, 24);
            if (this.ClientSize.Width - exportButton.Width - exportSelectedButton.Width > TaskFilterButton.Location.X + TaskFilterButton.Size.Width)
            {
                exportButton.Location = new Point(this.ClientSize.Width - exportButton.Width, 1);
                exportSelectedButton.Location = new Point(this.ClientSize.Width - exportButton.Width - exportSelectedButton.Width, 1);
            }
            else
            {
                exportButton.Location = new Point(TaskFilterButton.Location.X + TaskFilterButton.Size.Width + exportSelectedButton.Width, 1);
                exportSelectedButton.Location = new Point(TaskFilterButton.Location.X + TaskFilterButton.Size.Width, 1);
                this.MinimumSize = new Size(TaskFilterButton.Location.X + TaskFilterButton.Size.Width + exportSelectedButton.Width + exportButton.Size.Width + 10, 100);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(isInDay || isUsingDayFilter)
            {
                button1_Click(sender, e);
            }
            else if (isInIssueNumber || isUsingTaskFilter)
            {
                dataGrid.DataSource = ToSortableList(days[selectedDayIndex].Tasks);
                dataGrid.Sort(this.dataGrid.Columns["TaskID"], ListSortDirection.Ascending);
                //dataGrid.Columns["TaskID"].Visible = false;
                isInDays = false;
                isInDay = true;
                isInIssueNumber = false;
                isUsingDayFilter = false;
                isUsingTaskFilter = false;
                dataGrid.Columns[0].ToolTipText = "View all the tasks with the same issue";
                dataGrid.Columns[0].HeaderText = "View Issue";
                dataGrid.Columns[0].Visible = true;
                this.Text = "Log Browser - " + days[selectedDayIndex].LongDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Log Browser";
            dataGrid.Columns[0].ToolTipText = "View this day's tasks";
            dataGrid.Columns[0].HeaderText = "View Day";
            dataGrid.Columns[0].Visible = true;
            dataGrid.DataSource = days;
            dataGrid.Sort(this.dataGrid.Columns["DayID"], ListSortDirection.Descending);
            dataGrid.Columns["DayID"].Visible = true;
            isInDays = true;
            isInDay = false;
            isInIssueNumber = false;
            isUsingDayFilter = false;
            isUsingTaskFilter = false;
            backButton.Enabled = false;
            toTopButton.Enabled = false;
            //TaskFilterButton.Enabled = false;
            //if (taskFilter != null && !taskFilter.IsDisposed)
            //    taskFilter.Dispose();
        }

        #region Filter

        TaskFilter taskFilter;

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Task> issues = new List<Task>();
            foreach (Day d in days)
            {
                issues.AddRange(d.Tasks);
            }
            if (taskFilter == null || taskFilter.IsDisposed)
                taskFilter = new TaskFilter(this, TaskTracker.GetFirstDay(days).Date, TaskTracker.GetLastDay(days).Date, issues);
            taskFilter.Show();
            taskFilter.Focus();
        }

        public void TaskFilter_Query(string FromDate, string ToDate, List<string> Organizations, DateTime fromElapsedTime, DateTime toElapsedTime, List<string> usedTimes, bool APSHours)
        {
            List<Task> tasks = new List<Task>();
            foreach (Day d in days)
            {
                tasks.AddRange(d.Tasks);
            }
            dataGrid.DataSource = ToSortableList(QueryTasks(tasks, FromDate, ToDate, Organizations, fromElapsedTime, toElapsedTime, usedTimes, APSHours));
            dataGrid.Sort(this.dataGrid.Columns["TaskID"], ListSortDirection.Ascending);
            //dataGrid.Columns["TaskID"].Visible = false;
            isInDays = false;
            isInDay = false;
            isInIssueNumber = false;
            isUsingDayFilter = false;
            isUsingTaskFilter = true;
            dataGrid.Columns[0].Visible = false;
            backButton.Enabled = true;
            toTopButton.Enabled = true;
        }

        private List<Task> QueryTasks(List<Task> allData, string FromDate, string ToDate, List<string> Organizations, DateTime fromElapsedTime, DateTime toElapsedTime, List<string> usedTimes, bool APSHours)
        {
            List<Task> queriedData = allData;
            List<bool> toRemove = new List<bool>();
            foreach(Task t in allData)
                toRemove.Add(false);

            //Filter by APS Hours
            #region APS Hours Utilized
            if (APSHours)
            {
                for (int i = 0; i < queriedData.Count; i++)
                {
                    if (!toRemove[i])
                    {
                        if(!queriedData[i].APS)
                            toRemove[i] = true;
                    }
                }
            }
            #endregion

            //Filter by Date
            #region Date Filter

            if (FromDate != "" && ToDate != "")
            {
                for (int i = 0; i < queriedData.Count; i++)
                {
                    if (queriedData[i].Date == null || queriedData[i].Date.Trim() == "")
                    {
                        toRemove[i] = true;
                    }
                }
            }

            if (FromDate == "")
                FromDate = TaskTracker.GetFirstDay(days).Date;
            if (ToDate == "")
                ToDate = TaskTracker.GetLastDay(days).Date;

            bool sameDate = (FromDate == ToDate ? true : false);
            
            if(sameDate)
            {
                for (int i = 0; i < queriedData.Count; i++)
                    if(!toRemove[i] && queriedData[i].Date != null && queriedData[i].Date != "")
                        if (DateTime.Parse(FromDate).CompareTo(DateTime.Parse(DateTime.Parse(queriedData[i].Date).ToShortDateString())) != 0)
                            toRemove[i] = true;
            }
            else
            {
                for (int i = 0; i < queriedData.Count; i++)
                    if (!toRemove[i] && queriedData[i].Date != null && queriedData[i].Date != "")
                    {
                        DateTime taskDate = DateTime.Parse(DateTime.Parse(queriedData[i].Date).ToShortDateString());
                        if (DateTime.Parse(FromDate).CompareTo(taskDate) > 0 || DateTime.Parse(ToDate).CompareTo(taskDate) < 0)
                            toRemove[i] = true;
                    }
            }
            #endregion

            //Filter by Organization
            #region Org Filter
            if(Organizations.Count > 0)
            {
                for (int i = 0; i < queriedData.Count; i++)
                {
                    if (!toRemove[i])
                    {
                        bool remove = true;
                        foreach (string s in Organizations)
                        {
                            if (!queriedData[i].IssueNumber.ToLower().Replace(s.ToLower(), "").Equals(queriedData[i].IssueNumber.ToLower()))
                                remove = false;
                        }
                        if (remove)
                            toRemove[i] = true;
                    }
                }
            }
            #endregion

            //Filter by Elapsed Time
            #region Elapsed Filter
            if (fromElapsedTime != DateTime.MinValue && toElapsedTime != DateTime.MinValue)
            {
                for (int i = 0; i < queriedData.Count; i++)
                {
                    if (queriedData[i].ElapsedTime == null || queriedData[i].ElapsedTime == "")
                    {
                        toRemove[i] = true;
                    }

                    if (!toRemove[i] && queriedData[i].ElapsedTime != null && queriedData[i].ElapsedTime != "")
                    {
                        int[] elapsed = TaskTracker.ParseTime(queriedData[i].ElapsedTime);

                        int[] from = TaskTracker.ParseTime(fromElapsedTime.ToLongTimeString().Replace(" AM", "").Replace(" PM", ""));
                        if (!fromElapsedTime.ToLongTimeString().Replace(" AM", "").Equals(fromElapsedTime.ToLongDateString()) && from[0] == 12)
                            from[0] = 0;

                        if (elapsed[0] < from[0])
                            toRemove[i] = true;
                        else if (elapsed[0] == from[0])
                        {
                            if (elapsed[1] < from[1])
                                toRemove[i] = true;
                            else if (elapsed[1] == from[1])
                            {
                                if (elapsed[2] < from[2])
                                    toRemove[i] = true;
                            }
                        }

                        if (!toRemove[i])
                        {
                            int[] to = TaskTracker.ParseTime(toElapsedTime.ToLongTimeString().Replace(" AM", "").Replace(" PM", ""));
                            if (!toElapsedTime.ToLongTimeString().Replace(" AM", "").Equals(toElapsedTime.ToLongDateString()) && to[0] == 12)
                                to[0] = 0;
                            if (elapsed[0] > to[0])
                                toRemove[i] = true;
                            else if (elapsed[0] == to[0])
                            {
                                if (elapsed[1] > to[1])
                                    toRemove[i] = true;
                                else if (elapsed[1] == to[1])
                                {
                                    if (elapsed[2] > to[2])
                                        toRemove[i] = true;
                                    else if (elapsed[2] == to[2] && elapsed[3] > 0)
                                        toRemove[i] = true;
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            
            //Filter by Used Time
            #region Used Time Filter
            if (usedTimes.Count > 0)
            {
                for (int i = 0; i < queriedData.Count; i++)
                {
                    if (!toRemove[i])
                    {
                        bool remove = true;
                        foreach (string s in usedTimes)
                        {
                            if (queriedData[i].TimeUsed.Trim().Equals(s.Trim()))
                                remove = false;
                        }
                        if (remove)
                            toRemove[i] = true;
                    }
                }
            }
            #endregion

            for(int i = queriedData.Count - 1; i >= 0; i--)
            {
                if(toRemove[i])
                    queriedData.RemoveAt(i);
            }
            return queriedData;
        }
        #endregion

        #region Export

        private void button2_Click(object sender, EventArgs e)
        {
            XSSFWorkbook wb = new XSSFWorkbook();

            wb.CreateSheet();

            if (isInDays || isUsingDayFilter)
            {
                SortableBindingList<Day> data = (SortableBindingList<Day>)dataGrid.DataSource;

                wb.GetSheetAt(0).CreateRow(0).CreateCell(0).SetCellValue("Date");
                wb.GetSheetAt(0).GetRow(0).CreateCell(1).SetCellValue("LongDate");
                wb.GetSheetAt(0).GetRow(0).CreateCell(2).SetCellValue("StartTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(3).SetCellValue("EndTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(4).SetCellValue("TotalTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(5).SetCellValue("TotalTimeOnTasks");
                wb.GetSheetAt(0).GetRow(0).CreateCell(6).SetCellValue("TotalUsedTime");

                for (int i = 0; i < data.Count; i++)
                {
                    wb.GetSheetAt(0).CreateRow(i + 1).CreateCell(0).SetCellValue(data[i].Date);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(1).SetCellValue(data[i].LongDate);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(2).SetCellValue(data[i].StartTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(3).SetCellValue(data[i].EndTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(4).SetCellValue(data[i].TotalTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(5).SetCellValue(data[i].TotalTimeOnTasks);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(6).SetCellValue(data[i].TotalUsedTime);
                }

                ExportData(wb);
            }
            else if (isInDay || isInIssueNumber || isUsingTaskFilter)
            {
                SortableBindingList<Task> data = (SortableBindingList<Task>)dataGrid.DataSource;

                wb.GetSheetAt(0).CreateRow(0).CreateCell(0).SetCellValue("Date");
                wb.GetSheetAt(0).GetRow(0).CreateCell(1).SetCellValue("StartTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(2).SetCellValue("EndTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(3).SetCellValue("ElapsedTime");
                wb.GetSheetAt(0).GetRow(0).CreateCell(4).SetCellValue("IssueNumber");
                wb.GetSheetAt(0).GetRow(0).CreateCell(5).SetCellValue("TimeUsed");
                wb.GetSheetAt(0).GetRow(0).CreateCell(6).SetCellValue("APSHoursUtilized");

                for (int i = 0; i < data.Count; i++)
                {
                    wb.GetSheetAt(0).CreateRow(i + 1).CreateCell(0).SetCellValue(data[i].Date);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(1).SetCellValue(data[i].StartTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(2).SetCellValue(data[i].EndTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(3).SetCellValue(data[i].ElapsedTime);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(4).SetCellValue(data[i].IssueNumber);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(5).SetCellValue(data[i].TimeUsed);
                    wb.GetSheetAt(0).GetRow(i + 1).CreateCell(6).SetCellValue(data[i].APS);
                }

                ExportData(wb);
            }
        }

        private void ExportData(XSSFWorkbook wb)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Export an Excel File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
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

        #endregion

        private void dataGrid_DataSourceChanged(object sender, EventArgs e)
        {
            /*if (isInDay || isInIssueNumber || isUsingDayFilter || isUsingTaskFilter)
            {
                backButton.Enabled = true;
                toTopButton.Enabled = true;
                if (!isUsingDayFilter)
                    TaskFilterButton.Enabled = true;
            }
            else
            {
                backButton.Enabled = false;
                toTopButton.Enabled = false;
                //TaskFilterButton.Enabled = false;
                if (taskFilter != null && !taskFilter.IsDisposed)
                    taskFilter.Dispose();
            }*/
        }

        private void LogBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (taskFilter != null && !taskFilter.IsDisposed)
            {
                taskFilter.Close();
                taskFilter.Dispose();
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 1)
                exportSelectedButton.Enabled = true;
            else
                exportSelectedButton.Enabled = false;
        }

        private void exportSelectedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
