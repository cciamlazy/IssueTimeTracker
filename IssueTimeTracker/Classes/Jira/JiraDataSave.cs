using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class JiraDataSave
    {
        public string Name { get; set; } = "Not Named";
        public string JQLQuery { get; set; } = "project = CT AND reporter = currentUser()";
        public int MaxIssuesPerRequest { get; set; } = 25;
        public string DateTimeFormat { get; set; } = "MM/dd/yyyy hh:mm:ss";
        public List<string> Columns { get; set; } = new List<string>();
        public List<string> SelectedColumns { get; set; } = new List<string>();
        public List<string> DeSelectedIssues { get; set; } = new List<string>();
    }
}
