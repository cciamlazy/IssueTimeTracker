using Atlassian.Jira;
using IssueTimeTracker.Classes;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ToastNotifications;

namespace IssueTimeTracker
{
    public static class StaticHandler
    {
        #region Variables
        public static Main _Main;
        public static ThemedMain _ThemedMain;
        public static Notes Notes = new Notes();
        #endregion
    }
}
