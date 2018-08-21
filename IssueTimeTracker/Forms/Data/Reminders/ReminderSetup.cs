using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Classes.Data.Reminders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Data.Reminders
{
    public partial class ReminderSetup : Form
    {
        Reminder _reminder = new Reminder();

        public ReminderSetup(Reminder reminder = null)
        {
            InitializeComponent();
            Advanced.Checked = false;
            if (reminder != null)
            {
                _reminder = reminder;
                Title.Text = reminder.Title;
                Description.Text = reminder.Description;
                Completed.Checked = reminder.Completed;
                Advanced.Checked = reminder.AdvancedTask;
                Notification.Checked = reminder.Notification;
                RemindAfterTaskComplete.Checked = reminder.RemindAfterTaskComplete;
                RemindState.SelectedIndex = (int)reminder.RemindState;
                RemindDateTime.Value = (reminder.RemindDateTime != new DateTime() ? reminder.RemindDateTime : DateTime.Now);
                RemindStartTime.Value = (reminder.RemindStartTime != new DateTime() ? reminder.RemindStartTime : DateTime.Now);
                RemindEndTime.Value = (reminder.RemindEndTime != new DateTime() ? reminder.RemindEndTime : DateTime.Now);
                RemindStartTimeWeek.Value = (reminder.RemindStartTime != new DateTime() ? reminder.RemindStartTime : DateTime.Now);
                RemindEndTimeWeek.Value = (reminder.RemindEndTime != new DateTime() ? reminder.RemindEndTime : DateTime.Now);

                Monday.Checked = reminder.RemindDays.Monday;
                Tuesday.Checked = reminder.RemindDays.Tuesday;
                Wednesday.Checked = reminder.RemindDays.Wednesday;
                Thursday.Checked = reminder.RemindDays.Thursday;
                Friday.Checked = reminder.RemindDays.Friday;
                Saturday.Checked = reminder.RemindDays.Saturday;
                Sunday.Checked = reminder.RemindDays.Sunday;

                CreateButton.Text = "Update";
            }
            else
            {
                RemindState.SelectedIndex = 0;
            }
        }

        private void Advanced_CheckedChanged(object sender, EventArgs e)
        {
            if (Advanced.Checked)
            {
                AdvancedPanel.Visible = true;
                CreateButton.Location = new Point(278, AdvancedPanel.Location.Y + AdvancedPanel.Size.Height + 6);
                CancelButton.Location = new Point(183, AdvancedPanel.Location.Y + AdvancedPanel.Size.Height + 6);
                this.Size = new Size(393, CreateButton.Location.Y + (CreateButton.Size.Height * 2) + 12);
            }
            else
            {
                AdvancedPanel.Visible = false;
                this.Size = new Size(393, 265);
                CreateButton.Location = new Point(278, 187);
                CancelButton.Location = new Point(183, 187);
            }
        }

        private void ReminderSetup_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            UpdateReminder();
            if (CreateButton.Text == "Create")
                ReminderHandler.AddReminder(_reminder);
            else
                ReminderHandler.UpdateReminder(_reminder);
            this.Close();
        }

        private void UpdateReminder()
        {
            _reminder.Title = Title.Text;
            _reminder.Description = Description.Text;
            _reminder.Completed = Completed.Checked;
            _reminder.AdvancedTask = Advanced.Checked;

            _reminder.Notification = Notification.Checked;
            _reminder.RemindAfterTaskComplete = RemindAfterTaskComplete.Checked;
            _reminder.RemindState = (RemindState)RemindState.SelectedIndex;
            _reminder.RemindDateTime = RemindDateTime.Value;

            if (_reminder.RemindState == Classes.Data.Reminders.RemindState.Between)
            {
                _reminder.RemindStartTime = RemindStartTime.Value;
                _reminder.RemindEndTime = RemindEndTime.Value;
            }
            else if (_reminder.RemindState == Classes.Data.Reminders.RemindState.BetweenDaySpecific)
            {
                _reminder.RemindStartTime = RemindStartTimeWeek.Value;
                _reminder.RemindEndTime = RemindEndTimeWeek.Value;
            }

            _reminder.RemindDays.Monday = Monday.Checked;
            _reminder.RemindDays.Tuesday = Tuesday.Checked;
            _reminder.RemindDays.Wednesday = Wednesday.Checked;
            _reminder.RemindDays.Thursday = Thursday.Checked;
            _reminder.RemindDays.Friday = Friday.Checked;
            _reminder.RemindDays.Saturday = Saturday.Checked;
            _reminder.RemindDays.Sunday = Sunday.Checked;
        }

        private void RemindState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificDateTime.Visible = false;
            Between.Visible = false;
            BetweenDaySpecific.Visible = false;
            switch(RemindState.SelectedIndex)
            {
                case 1:
                    SpecificDateTime.Visible = true;
                    break;
                case 2:
                    Between.Visible = true;
                    break;
                case 3:
                    BetweenDaySpecific.Visible = true;
                    break;
            }
        }
    }
}
