using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class IssuesListItem
    {
        //public string TimeToResolution { get; set; }
        public string Key { get; set; }
        public string Assignee { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Created { get; set; }
        public string Reporter { get; set; }
        public string Priority { get; set; }
    }
}
