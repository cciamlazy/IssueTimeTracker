using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IssueTimeTracker.Classes.Messenger
{
    public class MessageDataJiraData
    {
        public string Type { get; set; } = "JiraData";
        public JiraDataSave Data { get; set; }

        public void HandleData()
        {
            PropertyInfo[] from = Data.GetType().GetProperties();
            Setting.Value.JiraData_List.Add(new JiraDataSave());
            PropertyInfo[] to = Setting.Value.JiraData_List.Last().GetType().GetProperties();

            for (int i = 0; i < from.Length; i++)
            {
                if (from[i].GetValue(Data) != null && to[i].GetValue(Setting.Value.JiraData_List.Last()) != null)
                {
                    Console.WriteLine(from[i].Name + " - " + from[i].GetValue(Data).ToString() + " | " + to[i].GetValue(Setting.Value.JiraData_List.Last()).ToString());

                    to[i].SetValue(Setting.Value.JiraData_List.Last(), from[i].GetValue(Data));

                    Console.WriteLine(from[i].Name + " - " + from[i].GetValue(Data).ToString() + " | " + to[i].GetValue(Setting.Value.JiraData_List.Last()) + "\n");
                }
            }
        }
    }
}
