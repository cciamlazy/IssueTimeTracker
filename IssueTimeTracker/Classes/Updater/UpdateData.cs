using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class UpdateData
    {
        public string Type { get; set; }
        public string UpdateFrom { get; set; }
        public string UpdateTo { get; set; }
        public string Script { get; set; } // Not implemented
    }
}
