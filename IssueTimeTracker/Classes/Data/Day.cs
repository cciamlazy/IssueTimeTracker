using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class Day
    {
		public int DayID { get; set; }
        public string Date { get; set; }
        public string LongDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TotalTime { get; set; }
        public string TotalTimeOnTasks { get; set; }
        public string TotalUsedTime { get; set; }
        public List<Task> Tasks = new List<Task>();
    }
}
