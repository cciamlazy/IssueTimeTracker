using IssueTimeTracker.Classes.Data.Reminders;
using IssueTimeTracker.Forms.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace IssueTimeTracker.Classes.Data
{
    public static class ReminderHandler
    {
        private static readonly string SaveFile = Path.Combine(Program.DataPath, "Reminders.json");

        private static List<Reminder> allReminders = new List<Reminder>();

        private static List<Reminder> toDisplay = new List<Reminder>();

        private static bool loaded = false;

        public static void AddReminder(Reminder reminder)
        {
            if (reminder.ReminderID < 0)
            {
                int id = allReminders.Count;
                foreach (Reminder r in allReminders)
                    if (r.ReminderID > id)
                        id = r.ReminderID;
                reminder.ReminderID = id;
            }
            allReminders.Add(reminder);
            Save();
            Tasks.ReloadList();
        }

        public static void UpdateReminder(Reminder reminder)
        {
            bool updated = false;
            for (int i = 0; i < allReminders.Count; i++)
            {
                if (allReminders[i].ReminderID == reminder.ReminderID)
                {
                    allReminders[i] = reminder;
                    updated = true;
                }
            }
            if (!updated)
                AddReminder(reminder);
            Save();
            Tasks.ReloadList();
        }

        public static void GenerateList(ListView owner, bool showCompleted = false)
        {
            if (!loaded)
                Load();
            ListViewItemCollection temp = new ListViewItemCollection(owner);
            foreach(Reminder r in allReminders)
            {
                // Expand this area with more logic around setting groups depending on all of the factors
                ListViewItem item = new ListViewItem(new string[] {
                    r.Title,
                    (r.CompleteBefore != new DateTime() ? r.CompleteBefore.ToShortDateString() : "")}, -1);
                int group = DetermineGroup(r);
                if(group >= 0)
                    item.Group = owner.Groups[0];
                item.Tag = r;
                item.Checked = r.Completed;
                if(showCompleted || !r.Completed)
                    temp.Add(item);
            }
        }

        // Still a work in progress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <returns>0 = Today, 1 = Tomorrow, 2 = This Week, 3 = Later, 4 = Previous</returns>
        private static int DetermineGroup(Reminder r)
        {
            if (isToday(r))
                return 0;
            else if (isTomorrow(r))
                return 1;
            else if (isThisWeek(r))
                return 2;
            return 4;
        }

        private static bool isToday(Reminder r)
        {
            //Fun stuff right here
            if (r.RemindState == RemindState.None || 
                (r.RemindState == RemindState.SpecificDateTime && r.RemindDateTime.Date == DateTime.Today) || 
                (isBetweenTimes(DateTime.Now, r.RemindStartTime, r.RemindEndTime) && 
                    ((r.RemindState == RemindState.Between) || 
                    (r.RemindState == RemindState.BetweenDaySpecific && r.RemindDays.IsDayIncluded(DateTime.Today)))))
                return true;
            return false;
        }

        private static bool isTomorrow(Reminder r)
        {
            if (r.RemindState == RemindState.None ||
                (r.RemindState == RemindState.SpecificDateTime && r.RemindDateTime.Date == DateTime.Today.AddDays(1)) ||
                (isBetweenTimes(DateTime.Today.AddDays(1), r.RemindStartTime, r.RemindEndTime) &&
                    ((r.RemindState == RemindState.Between) ||
                    (r.RemindState == RemindState.BetweenDaySpecific && r.RemindDays.IsDayIncluded(DateTime.Today.AddDays(1))))))
                return true;
            return false;
        }

        private static bool isThisWeek(Reminder r)
        {
            if (r.RemindState == RemindState.None ||
                (r.RemindState == RemindState.SpecificDateTime && DatesAreInTheSameWeek(r.RemindDateTime.Date, DateTime.Today))/* || //Not finished
                (isBetweenTimes(DateTime.Today.AddDays(1), r.RemindStartTime, r.RemindEndTime) &&
                    ((r.RemindState == RemindState.Between) ||
                    (r.RemindState == RemindState.BetweenDaySpecific && r.RemindDays.IsDayIncluded(DateTime.Today.AddDays(1)))))*/)
                return true;
            return false;
        }

        private static bool isBetweenTimes(DateTime cur, DateTime start, DateTime end)
        {
            if ((start == new DateTime() || cur.Ticks > start.Ticks) && (end == new DateTime() || DateTime.Now.Ticks < end.Ticks))
                return true;
            return false;
        }

        private static bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }

        public static void NotifyReminders(bool enteredTask)
        {
            
        }

        public static void Save()
        {
            Serializer<List<Reminder>>.WriteToJSONFile(allReminders, SaveFile);
        }

        public static void Load()
        {
            if (File.Exists(SaveFile))
                allReminders = Serializer<List<Reminder>>.LoadFromJSONFile(SaveFile);
            else
                Save();
            loaded = true;
            Tasks.ReloadList();
        }
    }
}
