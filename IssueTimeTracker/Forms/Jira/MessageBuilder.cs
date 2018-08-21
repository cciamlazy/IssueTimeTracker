using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class MessageBuilder : Form
    {
        private int CurrentMessage = -1;
        private string _selectedMenuItem;
        private readonly ContextMenuStrip collectionRoundMenuStrip;

        public MessageBuilder()
        {
            InitializeComponent();
            var toolStripMenuItem1 = new ToolStripMenuItem { Text = "Duplicate" };
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            var toolStripMenuItem2 = new ToolStripMenuItem { Text = "Delete" };
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            collectionRoundMenuStrip = new ContextMenuStrip();
            collectionRoundMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Setting.Value.Jira_Responses.Add(_selectedMenuItem);
            Setting.Save();
            PopulateList();
            MessageList.SelectedIndex = MessageList.Items.Count - 2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Setting.Value.Jira_Responses.Remove(_selectedMenuItem);
            Setting.Save();
            PopulateList();
            MessageList.SelectedIndex = 0;
        }

        private void MessageBuilder_Load(object sender, EventArgs e)
        {
            PopulateList();
            this.Size = new Size(Size.Width + 1, Size.Height + 1);
            MessageList.SelectedIndex = 0;
        }

        private void PopulateList()
        {
            MessageList.Items.Clear();
            MessageList.Items.AddRange(Setting.Value.Jira_Responses.ToArray());
            MessageList.Items.Add("Add New..");
            if (MessageList.Items.Count == 1)
            {
                CurrentMessage = -1;
                Message.Enabled = false;
                Message.Text = "";
            }
            else
                Message.Enabled = true;
        }

        private void MessageBuilder_SizeChanged(object sender, EventArgs e)
        {
            int margin = 3;
            MessageList.Size = new Size(this.ClientSize.Width - (margin*2), MessageList.Size.Height);
            Message.Size = new Size(this.ClientSize.Width - (margin * 2), this.ClientSize.Height - Message.Location.Y - margin);
        }

        private void MessageList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = MessageList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && index != MessageList.Items.Count - 1)
            {
                MessageList.SelectedIndex = index;
                _selectedMenuItem = MessageList.Items[index].ToString();
                collectionRoundMenuStrip.Show(Cursor.Position);
                collectionRoundMenuStrip.Visible = true;
            }
            else
            {
                collectionRoundMenuStrip.Visible = false;
            }
        }

        private void MessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MessageList.SelectedIndex >= 0 && MessageList.SelectedIndex < MessageList.Items.Count - 1)
            {
                if (Setting.Value.Jira_Responses.Count > MessageList.SelectedIndex && Setting.Value.Jira_Responses[MessageList.SelectedIndex] != null)
                {
                    CurrentMessage = MessageList.SelectedIndex;
                    Message.Text = Setting.Value.Jira_Responses[MessageList.SelectedIndex].Replace("\r\n", "\n").Replace("\n", Environment.NewLine);
                    Message.Enabled = true;
                }
                else
                {
                    CurrentMessage = -1;
                    Message.Text = "Invalid Object";
                    Message.Enabled = false;
                }
            }
            else if (MessageList.SelectedIndex == MessageList.Items.Count - 1)
            {
                CurrentMessage = -1;
                Message.Text = "";
                Message.Enabled = false;
            }
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            if(CurrentMessage != -1 && CurrentMessage < Setting.Value.Jira_Responses.Count)
            {
                Setting.Value.Jira_Responses[CurrentMessage] = Message.Text;
                MessageList.Items[CurrentMessage] = Message.Text;
                Setting.Save();
            }
        }

        private void MessageList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = MessageList.IndexFromPoint(e.Location);
            if (index == MessageList.Items.Count - 1)
            {
                Setting.Value.Jira_Responses.Add("When opening an unassigned Jira ticket, the reply box will get auto-populated by a randomly selected response from the above list\r\n" +
                    "Everything you type will be automatically saved. You can right click items to Duplicate or Delete them" +
                    "Fill out a response in this box. Here are the different commands you can use\r\n" +
                    "{phone} - Gets the customer phone number. Typically this comes in as 'FirstName LastName PhoneNumber Email' from LAC\r\n" +
                    "You can get the FirstName from the phone number by doing something like this: {phone,0}\r\n" +
                    "For Example: If enter 'Hello {phone,0}, etc.' in this textbox, when you go to respond to a Jira ticket this will generate a response like this: 'Hello FirstName, etc.'\r\n" +
                    "{phone,3} would get the Email if the Customer Phone Number in the Jira ticket was filled out properly\r\n" +
                    "{reporter} - Gets the username who submitted the Jira Ticket (will most likely be LAC Housing for Health)\r\n" +
                    "{champ} - Gets the champ ticket number\r\n" +
                    "");
            }
            Setting.Save();
            PopulateList();
            MessageList.SelectedIndex = MessageList.Items.Count - 2;
        }
    }
}
