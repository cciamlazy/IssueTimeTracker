using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker
{
    public static class Setting
    {
        public static Classes.Settings Value = new Classes.Settings();
        
        public static void Save()
        {
            string path = Program.DataPath + "\\Settings.json";
            Serializer<Classes.Settings>.WriteToJSONFile(Setting.Value, path);
        }

        public static void Load(string extension = "json")
        {
            string path = Program.DataPath + "\\Settings." + extension;
            if (!File.Exists(path))
                Create();
            if (extension == "xml")
                Value = Serializer<Classes.Settings>.LoadFromXMLFile(path);
            else
                Value = Serializer<Classes.Settings>.LoadFromJSONFile(path);
        }

        public static void Create()
        {
            Setting.Value = new Classes.Settings();

            Setting.Save();
        }

        public static void Reload()
        {
            Load();
        }

        public static void Update()
        {

            Save();
        }

        public static void Reset()
        {
            Create();
        }
    }
}
