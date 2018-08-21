using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Data
{
    public class AdminControl
    {
        public enum ViewMode
        {
            None,
            Basic,
            Advanced
        }

        public string Domain_Username { get; set; } = "";
        public string Domain_Password { get; set; } = "";
        public ViewMode View_Mode { get; set; } = ViewMode.None;
        public bool JiraAutoLogin { get; set; } = false;
        public string JiraPassword { get; set; } = "";

        public static AdminControl Control;

        public AdminControl()
        {
            Control = this;
        }

        /*public static void Generate()
        {
            if (Control == null)
                new AdminControl();
            Serial<AdminControl>.WriteToFile(Control, Path.Combine(Program.DataPath, "AdminControl.xml"));
        }*/

        public static void Load()
        {
            string path = Path.Combine(Program.DataPath, "AdminControl.json");
            string path2 = Path.Combine(Program.DataPath, "AdminControl.xml");
            if (File.Exists(path))
                Control = Serializer<AdminControl>.LoadFromJSONFile(path);
            else if (File.Exists(path2))
            {
                Control = Serializer<AdminControl>.LoadFromXMLFile(path2);
                Serializer<AdminControl>.WriteToJSONFile(Control, path);
                File.Delete(path2);
            }
            else
                new AdminControl();
        }
    }
}
