namespace IssueTimeTracker.Forms
{
    partial class ManualTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTime));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueNumber = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.ElapsedTime = new System.Windows.Forms.DateTimePicker();
            this.TimeUsed = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.APSHours = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUsed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Elapsed Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time Used:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "APS Hours Utilized:";
            // 
            // IssueNumber
            // 
            this.IssueNumber.Location = new System.Drawing.Point(104, 33);
            this.IssueNumber.Name = "IssueNumber";
            this.IssueNumber.Size = new System.Drawing.Size(255, 23);
            this.IssueNumber.TabIndex = 7;
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "HH:mm:ss";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(104, 57);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(85, 23);
            this.StartTime.TabIndex = 8;
            this.StartTime.Value = new System.DateTime(2017, 7, 13, 0, 0, 0, 0);
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "HH:mm:ss";
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(104, 82);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(85, 23);
            this.EndTime.TabIndex = 9;
            this.EndTime.Value = new System.DateTime(2017, 7, 13, 0, 0, 0, 0);
            this.EndTime.ValueChanged += new System.EventHandler(this.EndTime_ValueChanged);
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.CustomFormat = "HH:mm:ss";
            this.ElapsedTime.Enabled = false;
            this.ElapsedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ElapsedTime.Location = new System.Drawing.Point(104, 107);
            this.ElapsedTime.Name = "ElapsedTime";
            this.ElapsedTime.ShowUpDown = true;
            this.ElapsedTime.Size = new System.Drawing.Size(65, 23);
            this.ElapsedTime.TabIndex = 10;
            this.ElapsedTime.Value = new System.DateTime(2017, 7, 13, 0, 0, 0, 0);
            // 
            // TimeUsed
            // 
            this.TimeUsed.BackColor = System.Drawing.Color.White;
            this.TimeUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeUsed.DecimalPlaces = 2;
            this.TimeUsed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.TimeUsed.Location = new System.Drawing.Point(104, 135);
            this.TimeUsed.Name = "TimeUsed";
            this.TimeUsed.Size = new System.Drawing.Size(65, 23);
            this.TimeUsed.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(104, 8);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(255, 23);
            this.Date.TabIndex = 12;
            // 
            // APSHours
            // 
            this.APSHours.AutoSize = true;
            this.APSHours.Location = new System.Drawing.Point(128, 164);
            this.APSHours.Name = "APSHours";
            this.APSHours.Size = new System.Drawing.Size(15, 14);
            this.APSHours.TabIndex = 13;
            this.APSHours.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(178, 181);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(73, 29);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.FlatAppearance.BorderSize = 0;
            this.SaveAndCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveAndCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(254, 181);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(115, 29);
            this.SaveAndCloseButton.TabIndex = 15;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // ManualTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 211);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.APSHours);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.TimeUsed);
            this.Controls.Add(this.ElapsedTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.IssueNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManualTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Time Entry";
            ((System.ComponentModel.ISupportInitialize)(this.TimeUsed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IssueNumber;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker ElapsedTime;
        private System.Windows.Forms.NumericUpDown TimeUsed;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.CheckBox APSHours;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveAndCloseButton;
    }
}