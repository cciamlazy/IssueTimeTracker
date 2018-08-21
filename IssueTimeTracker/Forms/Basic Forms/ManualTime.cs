using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class ManualTime : Form
    {
        List<Day> days = new List<Day>();
        public ManualTime()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles(Program.DataPath + "\\TaskData\\");

            foreach (String s in files)
            {
                days.Add(TaskTracker.LoadDay(s));
            }

            Default();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
            Default();
            MessageBox.Show("Successfully created");
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void Default()
        {
            Date.MinDate = DateTime.Parse(TaskTracker.GetFirstDay(days).Date);
            Date.MaxDate = DateTime.Today;

            IssueNumber.Text = "";
        }

        private void Save()
        {
            Task task = new Task()
            {
                APS = APSHours.Checked,
                Date = Date.Value.ToLongDateString(),
                ElapsedTime = ElapsedTime.Value.ToString("HH:mm:ss") + ".00",
                StartTime = StartTime.Value.ToLongTimeString(),
                EndTime = EndTime.Value.ToLongTimeString(),
                IssueNumber = IssueNumber.Text,
                TimeUsed = TimeUsed.Value.ToString(),
                TaskID = Setting.Value.Log_CurrentTaskID++
            };
            Setting.Save();
            bool isToday = false;
            if (task.Date == DateTime.Today.ToShortDateString())
                isToday = true;
            if (isToday)
            {
                TaskTracker.AddTask(task);
            }
            else
            {
                var path = Program.DataPath + "\\TaskData\\" + task.Date.Replace('/', '-') + ".json";
                Day day;
                if (!File.Exists(path))
                {
                    day = new Day()
                    {
                        Date = task.Date,
                        DayID = Setting.Value.Log_CurrentDayID++,
                        EndTime = task.EndTime,
                        LongDate = DateTime.Parse(task.Date).ToLongDateString(),
                        StartTime = task.StartTime,
                        Tasks = new List<Task>(),
                        TotalTime = task.ElapsedTime,
                        TotalTimeOnTasks = task.ElapsedTime,
                        TotalUsedTime = task.TimeUsed
                    };
                    day.Tasks.Add(task);
                }
                else
                {
                    day = Serializer<Day>.LoadFromJSONFile(path);
                    day.Tasks.Add(task);
                    day.TotalTimeOnTasks = TaskTracker.RecursionElapsedTime(day, 0);
                    day.TotalUsedTime = TaskTracker.GetTotalTimeUsed(day);
                }
                TaskTracker.ExportDay(day);
            }
        }

        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
            CalculateElapsedTime();
        }

        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
            CalculateElapsedTime();
        }

        private void CalculateElapsedTime()
        {
            TimeSpan endTime = TimeSpan.FromHours(EndTime.Value.Hour).Add(TimeSpan.FromMinutes(EndTime.Value.Minute).Add(TimeSpan.FromSeconds(EndTime.Value.Second)));
            TimeSpan startTime = TimeSpan.FromHours(StartTime.Value.Hour).Add(TimeSpan.FromMinutes(StartTime.Value.Minute).Add(TimeSpan.FromSeconds(StartTime.Value.Second)));
            TimeSpan dif = endTime.Subtract(startTime);
            if (dif.TotalSeconds > 0)
                ElapsedTime.Value = new DateTime(1970, 1, 1, dif.Hours, dif.Minutes, dif.Seconds);
            else
                ElapsedTime.Value = new DateTime(1970, 1, 1, 0, 0, 0);
        }
    }
}
