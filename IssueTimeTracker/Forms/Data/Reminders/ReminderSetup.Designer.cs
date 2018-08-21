namespace IssueTimeTracker.Forms.Data.Reminders
{
    partial class ReminderSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Advanced = new System.Windows.Forms.CheckBox();
            this.Completed = new System.Windows.Forms.CheckBox();
            this.AdvancedPanel = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RemindAfterTaskComplete = new System.Windows.Forms.CheckBox();
            this.Notification = new System.Windows.Forms.CheckBox();
            this.RemindState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BetweenDaySpecific = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.RemindEndTimeWeek = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.RemindStartTimeWeek = new System.Windows.Forms.DateTimePicker();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.Between = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.RemindEndTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.RemindStartTime = new System.Windows.Forms.DateTimePicker();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.SpecificDateTime = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.RemindDateTime = new System.Windows.Forms.DateTimePicker();
            this.AdvancedPanel.SuspendLayout();
            this.BetweenDaySpecific.SuspendLayout();
            this.Between.SuspendLayout();
            this.SpecificDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(87, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 25);
            this.Title.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.Location = new System.Drawing.Point(87, 36);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(280, 126);
            this.Description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // Advanced
            // 
            this.Advanced.AutoSize = true;
            this.Advanced.Checked = true;
            this.Advanced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Advanced.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Advanced.Location = new System.Drawing.Point(10, 198);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(90, 22);
            this.Advanced.TabIndex = 4;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.CheckedChanged += new System.EventHandler(this.Advanced_CheckedChanged);
            // 
            // Completed
            // 
            this.Completed.AutoSize = true;
            this.Completed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Completed.Location = new System.Drawing.Point(10, 169);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(97, 22);
            this.Completed.TabIndex = 5;
            this.Completed.Text = "Completed";
            this.Completed.UseVisualStyleBackColor = true;
            // 
            // AdvancedPanel
            // 
            this.AdvancedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdvancedPanel.Controls.Add(this.SpecificDateTime);
            this.AdvancedPanel.Controls.Add(this.Between);
            this.AdvancedPanel.Controls.Add(this.BetweenDaySpecific);
            this.AdvancedPanel.Controls.Add(this.label3);
            this.AdvancedPanel.Controls.Add(this.RemindState);
            this.AdvancedPanel.Controls.Add(this.Notification);
            this.AdvancedPanel.Controls.Add(this.RemindAfterTaskComplete);
            this.AdvancedPanel.Location = new System.Drawing.Point(10, 227);
            this.AdvancedPanel.Name = "AdvancedPanel";
            this.AdvancedPanel.Size = new System.Drawing.Size(356, 191);
            this.AdvancedPanel.TabIndex = 6;
            // 
            // CreateButton
            // 
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CreateButton.Location = new System.Drawing.Point(278, 187);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(89, 34);
            this.CreateButton.TabIndex = 125;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(183, 187);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 34);
            this.CancelButton.TabIndex = 126;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // RemindAfterTaskComplete
            // 
            this.RemindAfterTaskComplete.AutoSize = true;
            this.RemindAfterTaskComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemindAfterTaskComplete.Location = new System.Drawing.Point(3, 30);
            this.RemindAfterTaskComplete.Name = "RemindAfterTaskComplete";
            this.RemindAfterTaskComplete.Size = new System.Drawing.Size(184, 21);
            this.RemindAfterTaskComplete.TabIndex = 5;
            this.RemindAfterTaskComplete.Text = "Remind After Entered Task:";
            this.RemindAfterTaskComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemindAfterTaskComplete.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Notification.Location = new System.Drawing.Point(3, 3);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(143, 21);
            this.Notification.TabIndex = 7;
            this.Notification.Text = "Display Notification:";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // RemindState
            // 
            this.RemindState.FormattingEnabled = true;
            this.RemindState.Items.AddRange(new object[] {
            "None",
            "Specific Date",
            "Between Two Dates/Times",
            "Between Two Dates w/ Days of Week"});
            this.RemindState.Location = new System.Drawing.Point(100, 54);
            this.RemindState.Name = "RemindState";
            this.RemindState.Size = new System.Drawing.Size(251, 25);
            this.RemindState.TabIndex = 8;
            this.RemindState.SelectedIndexChanged += new System.EventHandler(this.RemindState_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dates / Times:";
            // 
            // BetweenDaySpecific
            // 
            this.BetweenDaySpecific.Controls.Add(this.Sunday);
            this.BetweenDaySpecific.Controls.Add(this.Monday);
            this.BetweenDaySpecific.Controls.Add(this.Tuesday);
            this.BetweenDaySpecific.Controls.Add(this.Wednesday);
            this.BetweenDaySpecific.Controls.Add(this.Thursday);
            this.BetweenDaySpecific.Controls.Add(this.Friday);
            this.BetweenDaySpecific.Controls.Add(this.Saturday);
            this.BetweenDaySpecific.Controls.Add(this.label5);
            this.BetweenDaySpecific.Controls.Add(this.RemindEndTimeWeek);
            this.BetweenDaySpecific.Controls.Add(this.label4);
            this.BetweenDaySpecific.Controls.Add(this.RemindStartTimeWeek);
            this.BetweenDaySpecific.Location = new System.Drawing.Point(6, 85);
            this.BetweenDaySpecific.Name = "BetweenDaySpecific";
            this.BetweenDaySpecific.Size = new System.Drawing.Size(345, 100);
            this.BetweenDaySpecific.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            // 
            // RemindEndTimeWeek
            // 
            this.RemindEndTimeWeek.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.RemindEndTimeWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindEndTimeWeek.Location = new System.Drawing.Point(94, 34);
            this.RemindEndTimeWeek.Name = "RemindEndTimeWeek";
            this.RemindEndTimeWeek.Size = new System.Drawing.Size(251, 25);
            this.RemindEndTimeWeek.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "From:";
            // 
            // RemindStartTimeWeek
            // 
            this.RemindStartTimeWeek.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.RemindStartTimeWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindStartTimeWeek.Location = new System.Drawing.Point(94, 3);
            this.RemindStartTimeWeek.Name = "RemindStartTimeWeek";
            this.RemindStartTimeWeek.Size = new System.Drawing.Size(251, 25);
            this.RemindStartTimeWeek.TabIndex = 5;
            // 
            // Saturday
            // 
            this.Saturday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Saturday.AutoSize = true;
            this.Saturday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saturday.Location = new System.Drawing.Point(290, 65);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(36, 27);
            this.Saturday.TabIndex = 9;
            this.Saturday.Text = "Sat";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Between
            // 
            this.Between.Controls.Add(this.label6);
            this.Between.Controls.Add(this.RemindEndTime);
            this.Between.Controls.Add(this.label7);
            this.Between.Controls.Add(this.RemindStartTime);
            this.Between.Location = new System.Drawing.Point(6, 85);
            this.Between.Name = "Between";
            this.Between.Size = new System.Drawing.Size(345, 100);
            this.Between.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "To:";
            // 
            // RemindEndTime
            // 
            this.RemindEndTime.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.RemindEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindEndTime.Location = new System.Drawing.Point(94, 34);
            this.RemindEndTime.Name = "RemindEndTime";
            this.RemindEndTime.Size = new System.Drawing.Size(251, 25);
            this.RemindEndTime.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "From:";
            // 
            // RemindStartTime
            // 
            this.RemindStartTime.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.RemindStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindStartTime.Location = new System.Drawing.Point(94, 3);
            this.RemindStartTime.Name = "RemindStartTime";
            this.RemindStartTime.Size = new System.Drawing.Size(251, 25);
            this.RemindStartTime.TabIndex = 5;
            // 
            // Friday
            // 
            this.Friday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Friday.AutoSize = true;
            this.Friday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friday.Location = new System.Drawing.Point(252, 65);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(32, 27);
            this.Friday.TabIndex = 10;
            this.Friday.Text = "Fri";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Thursday.AutoSize = true;
            this.Thursday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Thursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thursday.Location = new System.Drawing.Point(207, 65);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(39, 27);
            this.Thursday.TabIndex = 11;
            this.Thursday.Text = "Thu";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Wednesday.AutoSize = true;
            this.Wednesday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wednesday.Location = new System.Drawing.Point(157, 65);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(44, 27);
            this.Wednesday.TabIndex = 12;
            this.Wednesday.Text = "Wed";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Tuesday.AutoSize = true;
            this.Tuesday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tuesday.Location = new System.Drawing.Point(112, 65);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(39, 27);
            this.Tuesday.TabIndex = 13;
            this.Tuesday.Text = "Tue";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Monday.AutoSize = true;
            this.Monday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Monday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Monday.Location = new System.Drawing.Point(61, 65);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(45, 27);
            this.Monday.TabIndex = 14;
            this.Monday.Text = "Mon";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Sunday
            // 
            this.Sunday.Appearance = System.Windows.Forms.Appearance.Button;
            this.Sunday.AutoSize = true;
            this.Sunday.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sunday.Location = new System.Drawing.Point(18, 65);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(39, 27);
            this.Sunday.TabIndex = 15;
            this.Sunday.Text = "Sun";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // SpecificDateTime
            // 
            this.SpecificDateTime.Controls.Add(this.label9);
            this.SpecificDateTime.Controls.Add(this.RemindDateTime);
            this.SpecificDateTime.Location = new System.Drawing.Point(6, 85);
            this.SpecificDateTime.Name = "SpecificDateTime";
            this.SpecificDateTime.Size = new System.Drawing.Size(345, 100);
            this.SpecificDateTime.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date / Time:";
            // 
            // RemindDateTime
            // 
            this.RemindDateTime.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.RemindDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RemindDateTime.Location = new System.Drawing.Point(94, 3);
            this.RemindDateTime.Name = "RemindDateTime";
            this.RemindDateTime.Size = new System.Drawing.Size(251, 25);
            this.RemindDateTime.TabIndex = 5;
            // 
            // ReminderSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AdvancedPanel);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Completed);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReminderSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Setup";
            this.Load += new System.EventHandler(this.ReminderSetup_Load);
            this.AdvancedPanel.ResumeLayout(false);
            this.AdvancedPanel.PerformLayout();
            this.BetweenDaySpecific.ResumeLayout(false);
            this.BetweenDaySpecific.PerformLayout();
            this.Between.ResumeLayout(false);
            this.Between.PerformLayout();
            this.SpecificDateTime.ResumeLayout(false);
            this.SpecificDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Advanced;
        private System.Windows.Forms.CheckBox Completed;
        private System.Windows.Forms.Panel AdvancedPanel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox RemindAfterTaskComplete;
        private System.Windows.Forms.CheckBox Notification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RemindState;
        private System.Windows.Forms.Panel BetweenDaySpecific;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker RemindEndTimeWeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker RemindStartTimeWeek;
        private System.Windows.Forms.Panel Between;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker RemindEndTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker RemindStartTime;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.Panel SpecificDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker RemindDateTime;
    }
}