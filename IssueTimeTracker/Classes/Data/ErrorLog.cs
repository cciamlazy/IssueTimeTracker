using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class ErrorLog
    {
        public string Name { get; set; } = Environment.UserName;
        public string Date { get; set; }
        public string Time { get; set; }
        public string Version { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string Sender { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}
