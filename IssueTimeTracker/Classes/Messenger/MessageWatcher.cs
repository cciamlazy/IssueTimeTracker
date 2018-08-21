using IssueTimeTracker.Classes.Messenger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes
{
    public class MessageWatcher
    {
        /*WebClient webClient = new WebClient();

        public MessageWatcher()
        {
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCompleted);
        }

        private void DownloadStringCompleted(object o, DownloadStringCompletedEventArgs e)
        {
            string totalMessages = e.Result;
            int total = 0;
            bool pass = int.TryParse(totalMessages, out total);
            if(pass && total > Setting.Value.Message_Total)
            {
                int dif = total - Setting.Value.Message_Total;
                if(dif > 1)
                {
                    for (int i = Setting.Value.Message_Total; i < total; i++)
                    {
                        HandleMessage(i);
                        //File.Delete(location + ext);
                    }
                }
                else
                {
                    HandleMessage(total - 1);
                    //File.Delete(location + ext);
                }
                Main.PlayNotificationSound(Setting.Value.Notification_Sound);
                Setting.Value.Message_Total = total;
                Setting.Save();
            }
    }

    private void HandleMessage(int num)
        {
            string location = Program.DataPath + "Messages";
            string ext = "/" + (num) + ".json";
            if (!Directory.Exists(location))
                Directory.CreateDirectory(location);
            while (webClient.IsBusy) { }
            webClient.DownloadFile(MainData.Instance.Domain + "IssueTimeTracker/Messages/" + Setting.Value.Jira_Username.Replace("@eccoviasolutions.com", "").ToLower() + ext, location + ext);
            Message message = GetMessageFile(location + ext);
            Notification toastNotification = new Notification(message);
            toastNotification.Show();
            if (message.DownloadData && (message.JiraData != null || message.JiraData.Type != "null"))
                HandleDownloadData(null, message.JiraData);
            Setting.Save();
        }

        private void HandleDownloadData(MessageData data = null, MessageDataJiraData jiraData = null)
        {
            if(data != null)
                data.HandleData();
            if (jiraData != null)
                jiraData.HandleData();
        }

        public static Message GetMessageFile(string path)
        {
            Message message = null;
            if (File.Exists(path))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Message));
                StreamReader file = new System.IO.StreamReader(path);
                message = (Message)reader.Deserialize(file);
                file.Close();
            }
            return message;
        }

        public bool CheckAsync()
        {
            if (Program.CheckForInternetConnection() && !webClient.IsBusy && Setting.Value.Jira_Username != "")
            {
                try
                {
                    string name = Setting.Value.Jira_Username.Replace("@eccoviasolutions.com", "").ToLower();
                    foreach (string s in MainData.Instance.JiraNames.Select(x => x.From).ToArray())
                        if (s.ToLower().Contains(name))
                            webClient.DownloadStringAsync(new Uri(MainData.Instance.Domain + "IssueTimeTracker/Messages/" + name));
                        else
                            return false;
                }
                catch { return false; }
            }

            return true;
        }
    */
    }
}
