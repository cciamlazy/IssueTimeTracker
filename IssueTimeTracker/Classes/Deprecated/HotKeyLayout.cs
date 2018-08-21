using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public class HotKeyLayout
    {
        public bool Ctrl { get; set; }
        public bool Shift { get; set; }
        public bool Alt { get; set; }
        public System.Windows.Forms.Keys Key { get; set; }
    }
}
