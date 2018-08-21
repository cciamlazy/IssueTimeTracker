using IssueTimeTracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class FirstTimeSetup : Form
    {
        public FirstTimeSetup()
        {
            InitializeComponent();
        }

        private void FirstTimeSetup_Load(object sender, EventArgs e)
        {
            var positions = Enum.GetNames(typeof(Position));
            Position.Items.Clear();
            foreach (var p in positions)
                Position.Items.Add(Regex.Replace(p, "(\\B[A-Z])", " $1"));
            
            Position.SelectedIndex = (int)Setting.Value.General_Position;
            
        }

        private void Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Position.SelectedIndex)
            {
                case 0:
                    JiraYesNo.SelectedIndex = 0;
                    APSYesNo.SelectedIndex = 0;
                    break;
                case 1:
                    JiraYesNo.SelectedIndex = 1;
                    APSYesNo.SelectedIndex = 1;
                    break;
                case 2:
                    JiraYesNo.SelectedIndex = 1;
                    APSYesNo.SelectedIndex = 1;
                    break;
                case 3:
                    JiraYesNo.SelectedIndex = 1;
                    APSYesNo.SelectedIndex = 1;
                    break;
                case 4:
                    JiraYesNo.SelectedIndex = 1;
                    APSYesNo.SelectedIndex = 1;
                    break;
                default:
                    JiraYesNo.SelectedIndex = 1;
                    APSYesNo.SelectedIndex = 1;
                    break;
            }
            CheckSaveButtonEnable();
        }

        private void CheckSaveButtonEnable()
        {
            if (Position.SelectedIndex >= 0 && JiraYesNo.SelectedIndex >= 0 && APSYesNo.SelectedIndex >= 0)
                SaveButton.Enabled = true;
            else
                SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Setting.Value.General_FirstTime = false;
            Setting.Value.General_Position = (Classes.Position)Enum.ToObject(typeof(Position), Position.SelectedIndex);
            Setting.Value.General_JiraAccess = (JiraYesNo.SelectedIndex == 0 ? true : false);
            Setting.Value.General_APSUtlizer = (APSYesNo.SelectedIndex == 0 ? true : false);

            if (!Setting.Value.General_JiraAccess)
                Setting.Value.Notification_Frequency = 0;
            else
                Setting.Value.Notification_Frequency = 13;

            Setting.Save();
            if (StaticHandler._Main != null)
                StaticHandler._Main.UpdateNewSettings();
            if (StaticHandler._ThemedMain != null)
                StaticHandler._ThemedMain.UpdateNewSettings();
            this.Close();
        }

        private void JiraYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckSaveButtonEnable();
        }

        private void APSYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckSaveButtonEnable();
        }
    }
}
