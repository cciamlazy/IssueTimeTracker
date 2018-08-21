using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Data.Reminders
{
    public enum RemindState
    {
        None,
        SpecificDateTime,
        Between,
        BetweenDaySpecific
    }
    public class Reminder
    {
        // Basic info
        public int ReminderID { get; set; } = -1;
        public string Title { get; set; } = "Untitled";
        public string Description { get; set; } = "";
        public bool Completed { get; set; } = false;
        public int SortOrder { get; set; } = -1; //-1 = Auto
        public bool AdvancedTask { get; set; } = false;

        public bool Notification { get; set; } = false;
        public List<DateTime> NotifiedDates { get; set; } = new List<DateTime>();

        public string IssueNumber { get; set; } = "";

        public bool RemindAfterTaskComplete { get; set; } = false;

        public RemindState RemindState { get; set; } = RemindState.None;
        public DateTime RemindDateTime { get; set; } = new DateTime();
        public DateTime RemindStartTime { get; set; } = new DateTime();
        public DateTime RemindEndTime { get; set; } = new DateTime();
        public Week RemindDays { get; set; } = new Week() { Friday = false, Monday = false, Saturday = false, Sunday = false, Thursday = false, Tuesday = false, Wednesday = false };
        public DateTime CompleteBefore { get; set; } = new DateTime();

    }
}
