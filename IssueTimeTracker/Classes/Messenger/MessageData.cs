using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Messenger
{
    public class MessageData
    {
        public virtual string Type { get; set; }
        public virtual string Data { get; set; }

        public virtual void HandleData()
        {
            
        }
    }
}
