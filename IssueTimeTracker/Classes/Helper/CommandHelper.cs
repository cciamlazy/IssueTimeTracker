using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Helper
{
    public class CommandHelper
    {
        public CommandHelper()
        {

        }

        public string HandleCommand(string command, string[] param)
        {
            if (command.Length == 0)
                return "No Command Specified";

            bool messageadded = false;
            string str = "";

            try
            {
                Type type = command.GetType();
                MethodInfo theMethod = type.GetMethod(command);
                object o = theMethod.Invoke(command, param);
                str = o.ToString();
                if (o.ToString() != "")
                    messageadded = true;
            }
            catch (Exception e)
            {
                str = e.Message;
                messageadded = true;
            }

            if (!messageadded)
                str = "Nothing happened";

            return str;
        }

        public string Commands()
        {
            Type thisType = this.GetType();
            MethodInfo[] methods = thisType.GetMethods();
            string returnStr = "";
            foreach (MethodInfo m in methods)
            {
                returnStr += " | " + m.Name + " " + string.Join(" ", m.GetParameters().Select(p => p.Name));
            }
            return returnStr;
        }

        public string SetGlobalTimer(string test)
        {
            return "";
        }
    }
}
