namespace IssueTimeTracker.Forms
{
    partial class TaskFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskFilter));
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrgCheckBox = new System.Windows.Forms.CheckBox();
            this.OrgPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customOrgTextBox = new System.Windows.Forms.TextBox();
            this.OrgListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.ElapsedCheckBox = new System.Windows.Forms.CheckBox();
            this.ElapsedPanel = new System.Windows.Forms.Panel();
            this.toElapsedTime = new System.Windows.Forms.DateTimePicker();
            this.FromElapsedTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsedPanel = new System.Windows.Forms.Panel();
            this.UsedTimeList = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UsedCheckBox = new System.Windows.Forms.CheckBox();
            this.APSCheckbox = new System.Windows.Forms.CheckBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DatePanel.SuspendLayout();
            this.OrgPanel.SuspendLayout();
            this.ElapsedPanel.SuspendLayout();
            this.UsedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Location = new System.Drawing.Point(12, 12);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(88, 17);
            this.DateCheckBox.TabIndex = 2;
            this.DateCheckBox.Text = "Filter by Date";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // DatePanel
            // 
            this.DatePanel.Controls.Add(this.DateTo);
            this.DatePanel.Controls.Add(this.DateFrom);
            this.DatePanel.Controls.Add(this.label2);
            this.DatePanel.Controls.Add(this.label1);
            this.DatePanel.Location = new System.Drawing.Point(9, 31);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(300, 30);
            this.DatePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "and";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Between:";
            // 
            // OrgCheckBox
            // 
            this.OrgCheckBox.AutoSize = true;
            this.OrgCheckBox.Location = new System.Drawing.Point(12, 60);
            this.OrgCheckBox.Name = "OrgCheckBox";
            this.OrgCheckBox.Size = new System.Drawing.Size(124, 17);
            this.OrgCheckBox.TabIndex = 7;
            this.OrgCheckBox.Text = "Filter by Organization";
            this.OrgCheckBox.UseVisualStyleBackColor = true;
            this.OrgCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OrgPanel
            // 
            this.OrgPanel.Controls.Add(this.button2);
            this.OrgPanel.Controls.Add(this.label6);
            this.OrgPanel.Controls.Add(this.customOrgTextBox);
            this.OrgPanel.Controls.Add(this.OrgListBox);
            this.OrgPanel.Controls.Add(this.label3);
            this.OrgPanel.Location = new System.Drawing.Point(9, 81);
            this.OrgPanel.Name = "OrgPanel";
            this.OrgPanel.Size = new System.Drawing.Size(300, 99);
            this.OrgPanel.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Add Custom";
            // 
            // customOrgTextBox
            // 
            this.customOrgTextBox.Location = new System.Drawing.Point(7, 40);
            this.customOrgTextBox.Name = "customOrgTextBox";
            this.customOrgTextBox.Size = new System.Drawing.Size(62, 20);
            this.customOrgTextBox.TabIndex = 2;
            // 
            // OrgListBox
            // 
            this.OrgListBox.FormattingEnabled = true;
            this.OrgListBox.Location = new System.Drawing.Point(75, 4);
            this.OrgListBox.Name = "OrgListBox";
            this.OrgListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.OrgListBox.Size = new System.Drawing.Size(216, 95);
            this.OrgListBox.Sorted = true;
            this.OrgListBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Organizations:";
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(222, 385);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 32);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElapsedCheckBox
            // 
            this.ElapsedCheckBox.AutoSize = true;
            this.ElapsedCheckBox.Location = new System.Drawing.Point(12, 183);
            this.ElapsedCheckBox.Name = "ElapsedCheckBox";
            this.ElapsedCheckBox.Size = new System.Drawing.Size(129, 17);
            this.ElapsedCheckBox.TabIndex = 10;
            this.ElapsedCheckBox.Text = "Filter by Elapsed Time";
            this.ElapsedCheckBox.UseVisualStyleBackColor = true;
            this.ElapsedCheckBox.CheckedChanged += new System.EventHandler(this.ElapsedCheckBox_CheckedChanged);
            // 
            // ElapsedPanel
            // 
            this.ElapsedPanel.Controls.Add(this.toElapsedTime);
            this.ElapsedPanel.Controls.Add(this.FromElapsedTime);
            this.ElapsedPanel.Controls.Add(this.label4);
            this.ElapsedPanel.Controls.Add(this.label5);
            this.ElapsedPanel.Location = new System.Drawing.Point(9, 203);
            this.ElapsedPanel.Name = "ElapsedPanel";
            this.ElapsedPanel.Size = new System.Drawing.Size(300, 30);
            this.ElapsedPanel.TabIndex = 6;
            // 
            // toElapsedTime
            // 
            this.toElapsedTime.CustomFormat = "HH:mm:ss";
            this.toElapsedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toElapsedTime.Location = new System.Drawing.Point(155, 3);
            this.toElapsedTime.Name = "toElapsedTime";
            this.toElapsedTime.ShowUpDown = true;
            this.toElapsedTime.Size = new System.Drawing.Size(67, 20);
            this.toElapsedTime.TabIndex = 7;
            this.toElapsedTime.Value = new System.DateTime(2017, 7, 13, 0, 0, 0, 0);
            // 
            // FromElapsedTime
            // 
            this.FromElapsedTime.CustomFormat = "HH:mm:ss";
            this.FromElapsedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromElapsedTime.Location = new System.Drawing.Point(53, 3);
            this.FromElapsedTime.Name = "FromElapsedTime";
            this.FromElapsedTime.ShowUpDown = true;
            this.FromElapsedTime.Size = new System.Drawing.Size(65, 20);
            this.FromElapsedTime.TabIndex = 6;
            this.FromElapsedTime.Value = new System.DateTime(2017, 7, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "and";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Between:";
            // 
            // UsedPanel
            // 
            this.UsedPanel.Controls.Add(this.UsedTimeList);
            this.UsedPanel.Controls.Add(this.label10);
            this.UsedPanel.Location = new System.Drawing.Point(9, 258);
            this.UsedPanel.Name = "UsedPanel";
            this.UsedPanel.Size = new System.Drawing.Size(300, 104);
            this.UsedPanel.TabIndex = 14;
            // 
            // UsedTimeList
            // 
            this.UsedTimeList.FormattingEnabled = true;
            this.UsedTimeList.Location = new System.Drawing.Point(71, 3);
            this.UsedTimeList.Name = "UsedTimeList";
            this.UsedTimeList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsedTimeList.Size = new System.Drawing.Size(62, 95);
            this.UsedTimeList.Sorted = true;
            this.UsedTimeList.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Used Time:";
            // 
            // UsedCheckBox
            // 
            this.UsedCheckBox.AutoSize = true;
            this.UsedCheckBox.Location = new System.Drawing.Point(12, 237);
            this.UsedCheckBox.Name = "UsedCheckBox";
            this.UsedCheckBox.Size = new System.Drawing.Size(143, 17);
            this.UsedCheckBox.TabIndex = 13;
            this.UsedCheckBox.Text = "Filter by Total Used Time";
            this.UsedCheckBox.UseVisualStyleBackColor = true;
            this.UsedCheckBox.CheckedChanged += new System.EventHandler(this.UsedCheckBox_CheckedChanged);
            // 
            // APSCheckbox
            // 
            this.APSCheckbox.AutoSize = true;
            this.APSCheckbox.Location = new System.Drawing.Point(12, 368);
            this.APSCheckbox.Name = "APSCheckbox";
            this.APSCheckbox.Size = new System.Drawing.Size(154, 17);
            this.APSCheckbox.TabIndex = 15;
            this.APSCheckbox.Text = "Filter by APS Hours Utilized";
            this.APSCheckbox.UseVisualStyleBackColor = true;
            // 
            // DateFrom
            // 
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(62, 3);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(95, 20);
            this.DateFrom.TabIndex = 6;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // DateTo
            // 
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(191, 3);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(95, 20);
            this.DateTo.TabIndex = 7;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // TaskFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 430);
            this.Controls.Add(this.APSCheckbox);
            this.Controls.Add(this.UsedPanel);
            this.Controls.Add(this.UsedCheckBox);
            this.Controls.Add(this.ElapsedPanel);
            this.Controls.Add(this.ElapsedCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.OrgPanel);
            this.Controls.Add(this.OrgCheckBox);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.DateCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskFilter";
            this.Text = "Task Filter";
            this.Load += new System.EventHandler(this.TaskFilter_Load);
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.OrgPanel.ResumeLayout(false);
            this.OrgPanel.PerformLayout();
            this.ElapsedPanel.ResumeLayout(false);
            this.ElapsedPanel.PerformLayout();
            this.UsedPanel.ResumeLayout(false);
            this.UsedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OrgCheckBox;
        private System.Windows.Forms.Panel OrgPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox ElapsedCheckBox;
        private System.Windows.Forms.Panel ElapsedPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker toElapsedTime;
        private System.Windows.Forms.DateTimePicker FromElapsedTime;
        private System.Windows.Forms.ListBox OrgListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customOrgTextBox;
        private System.Windows.Forms.Panel UsedPanel;
        private System.Windows.Forms.ListBox UsedTimeList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox UsedCheckBox;
        private System.Windows.Forms.CheckBox APSCheckbox;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
    }
}