namespace IssueTimeTracker.Forms.Data
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Today", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Tomorrow", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("This Week", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Later", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Previous", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Riverside-11860");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "CityOfBaltimoreHMIS-13854",
            "Wa"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.TaskList = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TaskList
            // 
            this.TaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskList.CheckBoxes = true;
            this.TaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Date});
            this.TaskList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskList.FullRowSelect = true;
            listViewGroup1.Header = "Today";
            listViewGroup1.Name = "Today";
            listViewGroup2.Header = "Tomorrow";
            listViewGroup2.Name = "Tomorrow";
            listViewGroup3.Header = "This Week";
            listViewGroup3.Name = "ThisWeek";
            listViewGroup4.Header = "Later";
            listViewGroup4.Name = "Later";
            listViewGroup5.Header = "Previous";
            listViewGroup5.Name = "Previous";
            this.TaskList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.TaskList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            this.TaskList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.TaskList.Location = new System.Drawing.Point(12, 12);
            this.TaskList.MultiSelect = false;
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(229, 310);
            this.TaskList.TabIndex = 0;
            this.TaskList.UseCompatibleStateImageBehavior = false;
            this.TaskList.View = System.Windows.Forms.View.Details;
            this.TaskList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.TaskList_ItemChecked);
            this.TaskList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskList_MouseUp);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = Setting.Value.Reminder_ItemWidth;
            // 
            // Date
            // 
            this.Date.Text = "Due Date";
            this.Date.Width = Setting.Value.Reminder_DateWidth;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 334);
            this.Controls.Add(this.TaskList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tasks_FormClosing);
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResizeEnd += new System.EventHandler(this.Tasks_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.Tasks_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Tasks_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TaskList;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Date;
    }
}