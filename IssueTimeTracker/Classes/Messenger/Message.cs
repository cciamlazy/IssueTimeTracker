using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Messenger
{
    public class Message
    {
        public int MessageID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TimeSent { get; set; }
        public string LongMessage { get; set; }
        public bool DownloadData { get; set; }
        public MessageDataJiraData JiraData { get; set; }
    }
}
