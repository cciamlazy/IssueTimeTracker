using IssueTimeTracker.Classes.Data;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class SendMessage : Form
    {
        WebClient webClient = new WebClient();
        public SendMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(to.SelectedItem.ToString() == "All")
            {
                foreach(JiraName j in MainData.Instance.JiraNames)
                {
                    while (webClient.IsBusy) { }
                    string stringID = webClient.DownloadString(MainData.Instance.Domain + "IssueTimeTracker/Messages/" + j.From.ToLower()).Trim();
                    int id = int.Parse(stringID);
                    Classes.Messenger.Message message = new Classes.Messenger.Message()
                    {
                        From = Setting.Value.Jira_Username.Replace("@eccoviasolutions.com", "").ToLower(),
                        MessageID = id,
                        To = j.From.ToLower(),
                        LongMessage = messageText.Text,
                        TimeSent = DateTime.Now.ToShortTimeString()
                    };
                    string path = Program.DataPath + "Messages\\Temp\\" + message.To + "\\";
                    Directory.CreateDirectory(path);
                    path += message.MessageID + ".json";

                    Serializer<Classes.Messenger.Message>.WriteToJSONFile(message, path);

                    string source = path;
                    string destination = "/home/csmioyik/public_html/IssueTimeTracker/Messages/" + message.To;
                    string host = "server237.web-hosting.com";
                    string username = AdminControl.Control.Domain_Username;
                    string password = AdminControl.Control.Domain_Password;
                    int port = 21098;  //Port 22 is defaulted for SFTP upload

                    try
                    {
                        sftp.UploadSFTPFile(host, username, password, source, destination, port);
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                    File.Delete(path);
                }
            }
            else
            {
                string stringID = webClient.DownloadString(MainData.Instance.Domain + "IssueTimeTracker/Messages/" + condenseName(to.Text.Trim().Replace("@eccoviasolutions.com", "")).ToLower());
                int id = int.Parse(stringID);
                Classes.Messenger.Message message = new Classes.Messenger.Message()
                {
                    From = Setting.Value.Jira_Username.Replace("@eccoviasolutions.com", "").ToLower(),
                    MessageID = id,
                    To = condenseName(to.SelectedItem.ToString()),
                    LongMessage = messageText.Text,
                    TimeSent = DateTime.Now.ToShortTimeString(),
                    DownloadData = savedQueries.SelectedIndex > -1,
                    JiraData = (savedQueries.SelectedIndex > -1 ? 
                            new Classes.Messenger.MessageDataJiraData()
                            {
                                Type = "JiraDataSave",
                                Data = Setting.Value.JiraData_List[Setting.Value.JiraData_List.Select(j => j.Name).ToList().IndexOf(savedQueries.SelectedItem.ToString())]
                            } : 
                            new Classes.Messenger.MessageDataJiraData()
                            {
                                Type = "null",
                                Data = null
                            }
                            )
                };
                string path = Program.DataPath + "Messages\\Temp\\";
                Directory.CreateDirectory(path);
                path += message.MessageID + ".json";

                Serializer<Classes.Messenger.Message>.WriteToJSONFile(message, path);

                string source = path;
                string destination = "/home/csmioyik/public_html/IssueTimeTracker/Messages/" + message.To;
                string host = "server237.web-hosting.com";
                string username = AdminControl.Control.Domain_Username;
                string password = AdminControl.Control.Domain_Password;
                int port = 21098;  //Port 22 is defaulted for SFTP upload

                try
                {
                    sftp.UploadSFTPFile(host, username, password, source, destination, port);
                }
                catch (Exception ae)
                {
                    MessageBox.Show(ae.Message);
                }
                File.Delete(path);
            }
        }

        private string condenseName(string name)
        {
            foreach (JiraName j in MainData.Instance.JiraNames)
                name = name.Replace(j.To, j.From);
            return name;
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.AddRange(MainData.Instance.JiraNames.Select(x => x.To).ToArray());
            to.AutoCompleteCustomSource = auto;
            to.Items.Add("All");
            to.Items.AddRange(MainData.Instance.JiraNames.Select(x => x.To).ToArray());
            savedQueries.Items.AddRange(Setting.Value.JiraData_List.Select(l => l.Name).ToArray());
        }
    }

    public static class sftp
    {
        public static void UploadSFTPFile(string host, string username,
        string password, string sourcefile, string destinationpath, int port)
        {
            using (SftpClient client = new SftpClient(host, port, username, password))
            {
                client.Connect();
                client.ChangeDirectory(destinationpath);
                using (FileStream fs = new FileStream(sourcefile, FileMode.Open))
                {
                    client.BufferSize = 4 * 1024;
                    client.UploadFile(fs, Path.GetFileName(sourcefile));
                }
            }
        }
    }
}
