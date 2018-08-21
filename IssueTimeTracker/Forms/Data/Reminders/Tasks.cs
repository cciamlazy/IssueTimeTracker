using IssueTimeTracker.Classes.Data;
using IssueTimeTracker.Classes.Data.Reminders;
using IssueTimeTracker.Forms.Data.Reminders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Data
{
    public partial class Tasks : Form
    {
        private ContextMenuStrip ReminderMenuOptions;
        private ContextMenuStrip NoReminderMenuOptions;
        private ListViewItem SelectedItem;
        private ToolStripMenuItem ShowCompletedItem;

        private static bool reloading = false;

        private static Tasks Instance;

        public Tasks()
        {
            InitializeComponent();
            InitToolStrips();
            Instance = this;
            ReminderHandler.Load();
        }

        public static void ReloadList()
        {
            reloading = true;
            if (Instance == null || Instance.TaskList == null)
                return;
            Instance.TaskList.Items.Clear();
            ReminderHandler.GenerateList(Instance.TaskList, Setting.Value.Reminder_ShowCompleted);
            reloading = false;
        }

        #region Tool Strips

        private void InitToolStrips()
        {
            ShowCompletedItem = new ToolStripMenuItem { Text = "Show Completed", BackColor = Color.White };
            ShowCompletedItem.Click += ShowCompletedItem_Click;
            if (Setting.Value.Reminder_ShowCompleted)
                ShowCompletedItem.CheckState = CheckState.Checked;
            else
                ShowCompletedItem.CheckState = CheckState.Unchecked;

            var EditMenuItem = new ToolStripMenuItem { Text = "Edit", BackColor = Color.White };
            EditMenuItem.Click += EditMenuItem_Click;
            var CompletedMenuItem = new ToolStripMenuItem { Text = "Mark Completed", BackColor = Color.White };
            CompletedMenuItem.Click += CompletedMenuItem_Click;
            var IncompleteMenuItem = new ToolStripMenuItem { Text = "Mark Uncompleted", BackColor = Color.White };
            IncompleteMenuItem.Click += IncompleteMenuItem_Click;
            ReminderMenuOptions = new ContextMenuStrip();
            ReminderMenuOptions.Items.AddRange(new ToolStripItem[] { EditMenuItem, CompletedMenuItem, IncompleteMenuItem, ShowCompletedItem });

            var NewMenuItem = new ToolStripMenuItem { Text = "New", BackColor = Color.White };
            NewMenuItem.Click += NewMenuItem_Click;
            NoReminderMenuOptions = new ContextMenuStrip();
            NoReminderMenuOptions.Items.AddRange(new ToolStripItem[] { NewMenuItem, ShowCompletedItem });
        }

        private void ShowCompletedItem_Click(object sender, EventArgs e)
        {
            ShowCompletedItem.CheckState = (ShowCompletedItem.CheckState == CheckState.Unchecked ? CheckState.Checked : CheckState.Unchecked);
            if (ShowCompletedItem.CheckState == CheckState.Checked)
                Setting.Value.Reminder_ShowCompleted = true;
            else
                Setting.Value.Reminder_ShowCompleted = false;

            ReloadList();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            new ReminderSetup().Show();
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            new ReminderSetup((Reminder)SelectedItem.Tag).Show();
        }

        private void CompletedMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem.Tag == null)
                return;
            Reminder r = (Reminder)SelectedItem.Tag;
            r.Completed = true;
            ReminderHandler.UpdateReminder(r);
        }

        private void IncompleteMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem.Tag == null)
                return;
            Reminder r = (Reminder)SelectedItem.Tag;
            r.Completed = false;
            ReminderHandler.UpdateReminder(r);
        }

        #endregion

        private void Tasks_SizeChanged(object sender, EventArgs e)
        {
            TaskList.Size = new Size(this.Size.Width - (TaskList.Location.X + 12), this.Size.Height - (TaskList.Location.Y + 12));
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            this.Location = Setting.Value.Reminder_FormPosition;
            this.Size = Setting.Value.Reminder_FormSize;
            ReloadList();
        }

        private void Tasks_ResizeEnd(object sender, EventArgs e)
        {
            Setting.Value.Reminder_FormSize = this.Size;
        }

        private void Tasks_LocationChanged(object sender, EventArgs e)
        {
            Setting.Value.Reminder_FormPosition = this.Location;
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.Value.Reminder_ItemWidth = this.Item.Width;
            Setting.Value.Reminder_DateWidth = this.Date.Width;
            Setting.Save();
        }

        private void TaskList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item != null && e.Item.Tag != null && !reloading)
            {
                Reminder r = (Reminder)e.Item.Tag;
                r.Completed = e.Item.Checked;
                ReminderHandler.UpdateReminder(r);
            }
        }

        private void TaskList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((TaskList.FocusedItem != null && TaskList.FocusedItem.Bounds.Contains(e.Location)) || (TaskList.SelectedItems != null && TaskList.SelectedItems.Count == 1 && TaskList.SelectedItems[0].Bounds.Contains(e.Location)))
                {
                    ReminderMenuOptions.Show(Cursor.Position);
                    Reminder r = (Reminder)TaskList.FocusedItem.Tag;
                    ReminderMenuOptions.Items[1].Visible = !r.Completed;
                    ReminderMenuOptions.Items[2].Visible = r.Completed;
                    ReminderMenuOptions.Items.Add(ShowCompletedItem);
                    NoReminderMenuOptions.Visible = false;
                    SelectedItem = TaskList.FocusedItem;
                }
                else
                {
                    NoReminderMenuOptions.Items.Add(ShowCompletedItem);
                    ReminderMenuOptions.Visible = false;
                    NoReminderMenuOptions.Show(Cursor.Position);
                    SelectedItem = null;
                }
            }
        }
    }
}
