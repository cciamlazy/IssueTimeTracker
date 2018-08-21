using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Be.Timvw.Framework.ComponentModel;

namespace IssueTimeTracker
{
    public static class TaskTracker
    {
        private static Day CurrentDay;
        private static Task CurrentTask;

        public static Day GetCurrentDay { get { return CurrentDay; } }

        public static bool isCurrentTaskNull { get { if (CurrentTask == null) return true; return false; } }
        public static void NullCurrentTask() { CurrentTask = null; }
        
        public static void StartNewDay()
        {
            if (CurrentDay != null)
                EndCurrentDay();
            
            var path = Program.DataPath + "\\TaskData\\" + DateTime.Today.ToShortDateString().Replace('/', '-') + ".json";
            if (File.Exists(path))
            {
                CurrentDay = LoadDay(path);
                if (CurrentDay.Date == null || CurrentDay.Date == "" || true)
                    CurrentDay.Date = DateTime.Today.ToShortDateString();
                if (CurrentDay.StartTime == null || CurrentDay.Date == "")
                    CurrentDay.StartTime = DateTime.Now.ToLongTimeString();
                if (CurrentDay.LongDate == null || CurrentDay.LongDate == "")
                    CurrentDay.LongDate = DateTime.Today.ToLongDateString();
                if (CurrentDay.TotalUsedTime == null || CurrentDay.TotalUsedTime == "")
                {
                    CurrentDay.TotalUsedTime = GetTotalTimeUsed(CurrentDay);
                }
            }
            else
            {
                CurrentDay = new Day();
                CurrentDay.Date = DateTime.Today.ToShortDateString();
                CurrentDay.StartTime = DateTime.Now.ToLongTimeString();
                CurrentDay.LongDate = DateTime.Today.ToLongDateString();
            }
            if(CurrentDay.DayID == 0)
                CurrentDay.DayID = Setting.Value.Log_CurrentDayID++;
            Setting.Save();
        }

        public static void EndCurrentDay()
        {
            if (CurrentDay == null)
                return;
            if (!isCurrentTaskNull)
                EndCurrentTask("", "", DateTime.Now.ToLongTimeString(), "", false);

            CurrentDay.TotalTimeOnTasks = "";
            CurrentDay.TotalTimeOnTasks = RecursionElapsedTime(CurrentDay, 0);
            CurrentDay.TotalUsedTime = GetTotalTimeUsed(CurrentDay);
            CurrentDay.EndTime = DateTime.Now.ToLongTimeString();
            if (StaticHandler._Main != null)
                CurrentDay.TotalTime = StaticHandler._Main.MainWatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            if (StaticHandler._ThemedMain != null)
                CurrentDay.TotalTime = StaticHandler._ThemedMain.MainWatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //CurrentDay.TotalTime = CalculateTotalTime(CurrentDay);
            ExportDay(CurrentDay);
            CurrentDay = null;
        }

        public static void ExportDay(Day day)
        {
            if (day == null)
                return;
            

            var path = Program.DataPath + "\\TaskData\\" + day.Date.Replace('/', '-') + ".json";
            
            if (File.Exists(path) && Setting.Value.Log_Backup)
            {
                string backupPath = path.Replace(".json", " - Backup");
                if (Directory.Exists(backupPath))
                {
                    File.Copy(path, backupPath + "\\" + Directory.GetFiles(backupPath).Length + ".json");
                }
                else
                {
                    Directory.CreateDirectory(backupPath);
                    File.Copy(path, backupPath + "\\" + Directory.GetFiles(backupPath).Length + ".json");
                }
            }

            Serializer<Day>.WriteToJSONFile(day, path);

            if (Setting.Value.Log_WriteXlsx)
                ExportXlxs(day);
        }

        public static Day LoadDay(string path)
        {
            if (path == null || path == "" || !File.Exists(path))
                return null;

            Day day = Serializer<Day>.LoadFromJSONFile(path);

            return day;
        }

        public static void AddTask(Task task)
        {
            CurrentDay.Tasks.Add(task);

            CurrentDay.TotalUsedTime = GetTotalTimeUsed(CurrentDay);
            CurrentDay.TotalTimeOnTasks = RecursionElapsedTime(CurrentDay, CurrentDay.Tasks.Count - 1);
            ExportDay(CurrentDay);
        }

        public static void StartNewTask()
        {
            if (CurrentDay == null)
                return;
            if (CurrentTask != null)
                EndCurrentTask("", "", DateTime.Now.ToLongTimeString(), "", false);

            CurrentTask = new Task();
            CurrentTask.StartTime = DateTime.Now.ToLongTimeString();
            CurrentTask.TaskID = Setting.Value.Log_CurrentTaskID++;
            CurrentTask.Date = DateTime.Today.ToLongDateString();
            Setting.Save();
        }

        public static List<string> GetAllIssues()
        {
            string[] files = Directory.GetFiles(Program.DataPath + "\\TaskData\\");
            List<string> issues = new List<string>();
            List<bool> toRemove = new List<bool>();

            foreach (String s in files)
            {
                issues.AddRange(TaskTracker.LoadDay(s).Tasks.Select(task=>task.IssueNumber));
            }

            foreach (string s in issues)
                toRemove.Add(false);

            for (int i = 0; i < issues.Count; i++)
            {
                if (i < issues.Count)
                {
                    for (int j = i + 1; j < issues.Count; j++)
                    {
                        if (issues[i] == issues[j] && i != j)
                            toRemove[i] = true;
                    }
                }
            }

            //Console.WriteLine(string.Join("\n", issues));
            for (int i = issues.Count - 1; i >= 0; i--)
                if (toRemove[i])
                    issues.RemoveAt(i);
            //Console.WriteLine(string.Join("\n", issues));
            return issues;
        }

        public static List<string> GetLatestIssuesNumbers(int amount)
        {
            List<string> list = new List<string>();

            List<Task> tasks = new List<Task>();
            string[] files = Directory.GetFiles(Program.DataPath + "\\TaskData\\");
            foreach (String s in files)
            {
                tasks.AddRange(TaskTracker.LoadDay(s).Tasks);
            }
            tasks = tasks.OrderBy(d=>d.TaskID).ToList();
            for(int i = tasks.Count - 1; i >= 0; i--)
            {
                bool dup = false;
                foreach (string s in list)
                    if (s.ToLower() == tasks[i].IssueNumber.ToLower())
                        dup = true;
                if (!dup)
                    list.Add(tasks[i].IssueNumber);
                if (list.Count == amount)
                    break;
            }

            return list;
        }

        public static void EndCurrentTask(string IssueNumber, string ElapsedTime, string EndTime, string TimeUsed, bool aps)
        {
            if (CurrentDay == null || CurrentTask == null)
                return;

            CurrentTask.IssueNumber = IssueNumber;
            CurrentTask.ElapsedTime = ElapsedTime;
            CurrentTask.EndTime = EndTime;
            CurrentTask.TimeUsed = TimeUsed;
            CurrentTask.APS = aps;

            CurrentDay.Tasks.Add(CurrentTask);
            CurrentTask = null;

            CurrentDay.TotalUsedTime = GetTotalTimeUsed(CurrentDay);
            CurrentDay.TotalTimeOnTasks = RecursionElapsedTime(CurrentDay, CurrentDay.Tasks.Count - 1);
            ExportDay(CurrentDay);
        }

        #region Day Helper Functions
        
        public static Day GetFirstDay(List<Day> days)
        {
            Day tempDay = null;
            foreach (Day d in days)
            {
                if (tempDay == null)
                    tempDay = d;
                else if (DateTime.Parse(d.Date).CompareTo(DateTime.Parse(tempDay.Date)) < 0)
                    tempDay = d;
            }
            return tempDay;
        }

        public static Day GetFirstDay(SortableBindingList<Day> days)
        {
            Day tempDay = null;
            foreach (Day d in days)
            {
                if (tempDay == null)
                    tempDay = d;
                else if (DateTime.Parse(d.Date).CompareTo(DateTime.Parse(tempDay.Date)) < 0)
                    tempDay = d;
            }
            return tempDay;
        }

        public static Day GetLastDay(List<Day> days)
        {
            Day tempDay = null;
            foreach (Day d in days)
            {
                if (tempDay == null)
                    tempDay = d;
                else if (DateTime.Parse(d.Date).CompareTo(DateTime.Parse(tempDay.Date)) > 0)
                    tempDay = d;
            }
            return tempDay;
        }

        public static Day GetLastDay(SortableBindingList<Day> days)
        {
            Day tempDay = null;
            foreach (Day d in days)
            {
                if (tempDay == null)
                    tempDay = d;
                else if (DateTime.Parse(d.Date).CompareTo(DateTime.Parse(tempDay.Date)) > 0)
                    tempDay = d;
            }
            return tempDay;
        }

        public static string CalculateTotalTime(Day day)
        {
            int[] start = ParseTime(day.StartTime.Replace(" AM", "").Replace(" PM", ""));
            int[] end = ParseTime(day.EndTime.Replace(" AM", "").Replace(" PM", ""));
            int[] total = new int[3];
            if (day.StartTime.Replace(" PM", "").Length != day.StartTime.Length)
                start[0] += 12;
            if (day.EndTime.Replace(" PM", "").Length != day.EndTime.Length)
                end[0] += 12;

            total[0] = end[0] - start[0];
            total[1] = end[1] - start[1];
            total[2] = end[2] - start[2];

            if (total[2] < 0)
            {
                total[1]--;
                total[2] += 60;
            }
            if (total[1] < 0)
            {
                total[0]--;
                total[1] += 60;
            }

            return ((total[0] < 10 ? "0" : "") + total[0] + ":" + (total[1] < 10 ? "0" : "") + total[1] + ":" + (total[2] < 10 ? "0" : "") + total[2] + ".00");
        }

        public static string RecursionElapsedTime(Day day, int i)
        {
            int[] old = ParseTime(day.TotalTimeOnTasks);
            if (i >= day.Tasks.Count)
                return day.TotalTimeOnTasks;
            int[] cur = ParseTime(day.Tasks[i].ElapsedTime);
            int[] newi = new int[cur.Length];

            newi[0] = old[0] + cur[0];
            newi[1] = old[1] + cur[1];
            newi[2] = old[2] + cur[2];
            newi[3] = old[3] + cur[3];

            if (newi[3] >= 100)
            {
                newi[3] -= 100;
                newi[2]++;
            }
            if (newi[2] >= 60)
            {
                newi[2] -= 60;
                newi[1]++;
            }
            if (newi[1] >= 60)
            {
                newi[1] -= 60;
                newi[0]++;
            }

            day.TotalTimeOnTasks = ((newi[0] < 10 ? "0" : "") + newi[0] + ":" + (newi[1] < 10 ? "0" : "") + newi[1] + ":" + (newi[2] < 10 ? "0" : "") + newi[2] + "." + (newi[3] < 10 ? "0" : "") + newi[3]);
            if (i + 1 == day.Tasks.Count)
                return day.TotalTimeOnTasks;
            return RecursionElapsedTime(day, i + 1);
        }

        public static int[] ParseTime(string time)
        {
            if (time == null || time == "" || time == "null")
                return new int[4] { 0, 0, 0, 0 };
            char[] separatingChars = { ':', '.' };

            string[] s = time.Split(separatingChars);
            int[] parsed = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                parsed[i] = int.Parse(s[i]);

            return parsed;
        }

        public static string GetTotalTimeUsed(Day day)
        {
            float total = 0;
            foreach (Task t in day.Tasks)
            {
                if (t.TimeUsed == null || t.TimeUsed == "")
                    continue;
                try
                {
                    total += float.Parse(t.TimeUsed);
                }
                catch (Exception e)
                {
                    Console.WriteLine(t.TimeUsed + "   " + e.Message);
                }
            }
            return total.ToString();
        }
        
        private static void ExportXlxs(Day day)
        {
            XSSFWorkbook wb = new XSSFWorkbook();

            wb.CreateSheet(day.LongDate);

            wb.GetSheetAt(0).CreateRow(0).CreateCell(0).SetCellValue("TaskID");
            wb.GetSheetAt(0).GetRow(0).CreateCell(1).SetCellValue("Date");
            wb.GetSheetAt(0).GetRow(0).CreateCell(2).SetCellValue("StartTime");
            wb.GetSheetAt(0).GetRow(0).CreateCell(3).SetCellValue("EndTime");
            wb.GetSheetAt(0).GetRow(0).CreateCell(4).SetCellValue("ElapsedTime");
            wb.GetSheetAt(0).GetRow(0).CreateCell(5).SetCellValue("IssueNumber");
            wb.GetSheetAt(0).GetRow(0).CreateCell(6).SetCellValue("TimeUsed");
            wb.GetSheetAt(0).GetRow(0).CreateCell(7).SetCellValue("APSHoursUtilized");

            for (int i = 0; i < day.Tasks.Count; i++)
            {
                wb.GetSheetAt(0).CreateRow(i + 1).CreateCell(0).SetCellValue(day.Tasks[i].TaskID);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(1).SetCellValue(day.Tasks[i].Date);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(2).SetCellValue(day.Tasks[i].StartTime);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(3).SetCellValue(day.Tasks[i].EndTime);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(4).SetCellValue(day.Tasks[i].ElapsedTime);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(5).SetCellValue(day.Tasks[i].IssueNumber);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(6).SetCellValue(day.Tasks[i].TimeUsed);
                wb.GetSheetAt(0).GetRow(i + 1).CreateCell(6).SetCellValue(day.Tasks[i].APS);
            }
            if (!Directory.Exists(Setting.Value.Log_XlsxDestination))
                Directory.CreateDirectory(Setting.Value.Log_XlsxDestination);
            using (var file = new FileStream(Setting.Value.Log_XlsxDestination + "\\" + day.Date.Replace('/', '-') + ".xlsx", FileMode.Create, FileAccess.ReadWrite))
            {
                wb.Write(file);
                file.Close();
            }
        }
        #endregion
    }
}
