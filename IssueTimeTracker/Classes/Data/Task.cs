using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Date { get; set; }
        public string IssueNumber { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ElapsedTime { get; set; }
        public string TimeUsed { get; set; }
        public bool APS { get; set; }
    }
}
