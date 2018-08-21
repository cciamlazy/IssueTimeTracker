using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IssueTimeTracker.Classes.Data
{
    public static class CleanData
    {
        public static bool CleanAllData()
        {
            try
            {
                List<string> files = new List<string>();
                List<string> directories = new List<string>();
                files.AddRange(Directory.GetFiles(Program.DataPath + "ErrorLog").ToList());
                if (File.Exists(Program.DataPath + "OldVersion.xml"))
                    files.Add(Program.DataPath + "OldVersion.xml");
                if (File.Exists(Program.DataPath + "NewVersion.xml"))
                    files.Add(Program.DataPath + "NewVersion.xml");

                if (File.Exists(Program.DataPath + "OldVersion.json"))
                    files.Add(Program.DataPath + "OldVersion.json");
                if (File.Exists(Program.DataPath + "NewVersion.json"))
                    files.Add(Program.DataPath + "NewVersion.json");

                if (Directory.Exists(Program.DataPath + "TaskData"))
                    directories.AddRange(Directory.GetDirectories(Program.DataPath + "TaskData"));
                if (Directory.Exists(Program.DataPath + "Jira"))
                    directories.AddRange(Directory.GetDirectories(Program.DataPath + "Jira"));
                if (Directory.Exists(Program.DataPath + "Messages"))
                    files.AddRange(Directory.GetFiles(Program.DataPath + "Messages").ToList());
                if(Directory.Exists(Program.DataPath + "Messages"))
                    directories.AddRange(Directory.GetDirectories(Program.DataPath + "Messages"));
                foreach (string s in files)
                    File.Delete(s);
                foreach (string s in directories)
                    if(Directory.Exists(s))
                        Directory.Delete(s, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Added this due to HIPAA so that we never run into compliance issues.
        /// Due to how JiraBrowser handles attachments, I clear them out every time the application closes.
        /// That way no client data that is attached to Jira remains
        /// </summary>
        public static void CleanJira()
        {
            try
            {
                List<string> directories = new List<string>();
                directories.AddRange(Directory.GetDirectories(Program.DataPath + "Jira"));
                foreach (string s in directories)
                    if(Directory.Exists(s))
                        Directory.Delete(s, true);
            }
            catch { }
        }
    }
}
