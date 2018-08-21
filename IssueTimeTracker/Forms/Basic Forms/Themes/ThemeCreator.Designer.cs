namespace IssueTimeTracker.Forms.Basic_Forms
{
    partial class ThemeCreator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeCreator));
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelThemeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ThemeName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.Global_Millisecond = new System.Windows.Forms.Label();
            this.Global_SecondPeriod = new System.Windows.Forms.Label();
            this.Global_Second = new System.Windows.Forms.Label();
            this.Global_MinuteColon = new System.Windows.Forms.Label();
            this.Global_Minute = new System.Windows.Forms.Label();
            this.Global_HourColon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.UseComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Task_Millisecond = new System.Windows.Forms.Label();
            this.LeftoverLabel = new System.Windows.Forms.Label();
            this.DayProgress = new CircularProgressBar.CircularProgressBar();
            this.Task_SecondPeriod = new System.Windows.Forms.Label();
            this.MoveLeftOverButton = new System.Windows.Forms.Button();
            this.UseButton = new System.Windows.Forms.Button();
            this.Task_Second = new System.Windows.Forms.Label();
            this.Task_MinuteColon = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.APSCheckbox = new System.Windows.Forms.CheckBox();
            this.Task_Minute = new System.Windows.Forms.Label();
            this.Task_HourColon = new System.Windows.Forms.Label();
            this.IssueNumber = new System.Windows.Forms.TextBox();
            this.Global_Hour = new System.Windows.Forms.Label();
            this.Task_Hour = new System.Windows.Forms.Label();
            this.themeListView = new System.Windows.Forms.ListView();
            this.themeList = new System.Windows.Forms.ImageList(this.components);
            this.PreviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(109, 198);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 31);
            this.SaveButton.TabIndex = 131;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelThemeButton
            // 
            this.CancelThemeButton.FlatAppearance.BorderSize = 0;
            this.CancelThemeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CancelThemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelThemeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CancelThemeButton.Location = new System.Drawing.Point(10, 198);
            this.CancelThemeButton.Name = "CancelThemeButton";
            this.CancelThemeButton.Size = new System.Drawing.Size(90, 31);
            this.CancelThemeButton.TabIndex = 132;
            this.CancelThemeButton.Text = "Cancel";
            this.CancelThemeButton.UseVisualStyleBackColor = true;
            this.CancelThemeButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // ThemeName
            // 
            this.ThemeName.Location = new System.Drawing.Point(66, 6);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(128, 25);
            this.ThemeName.TabIndex = 133;
            this.ThemeName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(119, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 23);
            this.checkBox1.TabIndex = 134;
            this.checkBox1.Text = "Preview";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.Global_Millisecond);
            this.PreviewPanel.Controls.Add(this.Global_SecondPeriod);
            this.PreviewPanel.Controls.Add(this.Global_Second);
            this.PreviewPanel.Controls.Add(this.Global_MinuteColon);
            this.PreviewPanel.Controls.Add(this.Global_Minute);
            this.PreviewPanel.Controls.Add(this.Global_HourColon);
            this.PreviewPanel.Controls.Add(this.panel2);
            this.PreviewPanel.Controls.Add(this.CurrentTaskLabel);
            this.PreviewPanel.Controls.Add(this.UseComboBox);
            this.PreviewPanel.Controls.Add(this.label9);
            this.PreviewPanel.Controls.Add(this.Task_Millisecond);
            this.PreviewPanel.Controls.Add(this.LeftoverLabel);
            this.PreviewPanel.Controls.Add(this.DayProgress);
            this.PreviewPanel.Controls.Add(this.Task_SecondPeriod);
            this.PreviewPanel.Controls.Add(this.MoveLeftOverButton);
            this.PreviewPanel.Controls.Add(this.UseButton);
            this.PreviewPanel.Controls.Add(this.Task_Second);
            this.PreviewPanel.Controls.Add(this.Task_MinuteColon);
            this.PreviewPanel.Controls.Add(this.TaskLabel);
            this.PreviewPanel.Controls.Add(this.APSCheckbox);
            this.PreviewPanel.Controls.Add(this.Task_Minute);
            this.PreviewPanel.Controls.Add(this.Task_HourColon);
            this.PreviewPanel.Controls.Add(this.IssueNumber);
            this.PreviewPanel.Controls.Add(this.Global_Hour);
            this.PreviewPanel.Controls.Add(this.Task_Hour);
            this.PreviewPanel.Location = new System.Drawing.Point(205, 6);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(221, 223);
            this.PreviewPanel.TabIndex = 135;
            // 
            // Global_Millisecond
            // 
            this.Global_Millisecond.AutoSize = true;
            this.Global_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Global_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Millisecond.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Global_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Global_Millisecond.Location = new System.Drawing.Point(164, 14);
            this.Global_Millisecond.Name = "Global_Millisecond";
            this.Global_Millisecond.Size = new System.Drawing.Size(43, 32);
            this.Global_Millisecond.TabIndex = 174;
            this.Global_Millisecond.Text = "14";
            // 
            // Global_SecondPeriod
            // 
            this.Global_SecondPeriod.AutoSize = true;
            this.Global_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Global_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Global_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Global_SecondPeriod.Location = new System.Drawing.Point(158, 19);
            this.Global_SecondPeriod.Name = "Global_SecondPeriod";
            this.Global_SecondPeriod.Size = new System.Drawing.Size(17, 25);
            this.Global_SecondPeriod.TabIndex = 173;
            this.Global_SecondPeriod.Text = ".";
            // 
            // Global_Second
            // 
            this.Global_Second.AutoSize = true;
            this.Global_Second.BackColor = System.Drawing.Color.Transparent;
            this.Global_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Second.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Global_Second.ForeColor = System.Drawing.Color.Gray;
            this.Global_Second.Location = new System.Drawing.Point(120, 5);
            this.Global_Second.Name = "Global_Second";
            this.Global_Second.Size = new System.Drawing.Size(56, 45);
            this.Global_Second.TabIndex = 170;
            this.Global_Second.Text = "47";
            // 
            // Global_MinuteColon
            // 
            this.Global_MinuteColon.AutoSize = true;
            this.Global_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Global_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_MinuteColon.Location = new System.Drawing.Point(108, 2);
            this.Global_MinuteColon.Name = "Global_MinuteColon";
            this.Global_MinuteColon.Size = new System.Drawing.Size(28, 45);
            this.Global_MinuteColon.TabIndex = 172;
            this.Global_MinuteColon.Text = ":";
            // 
            // Global_Minute
            // 
            this.Global_Minute.AutoSize = true;
            this.Global_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Global_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Minute.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Global_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Global_Minute.Location = new System.Drawing.Point(69, 5);
            this.Global_Minute.Name = "Global_Minute";
            this.Global_Minute.Size = new System.Drawing.Size(56, 45);
            this.Global_Minute.TabIndex = 169;
            this.Global_Minute.Text = "05";
            // 
            // Global_HourColon
            // 
            this.Global_HourColon.AutoSize = true;
            this.Global_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Global_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_HourColon.Location = new System.Drawing.Point(58, 2);
            this.Global_HourColon.Name = "Global_HourColon";
            this.Global_HourColon.Size = new System.Drawing.Size(28, 45);
            this.Global_HourColon.TabIndex = 171;
            this.Global_HourColon.Text = ":";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(9, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 192;
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CurrentTaskLabel.Location = new System.Drawing.Point(8, 130);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(41, 21);
            this.CurrentTaskLabel.TabIndex = 182;
            this.CurrentTaskLabel.Text = "0.00";
            // 
            // UseComboBox
            // 
            this.UseComboBox.BackColor = System.Drawing.Color.White;
            this.UseComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.UseComboBox.FormattingEnabled = true;
            this.UseComboBox.Location = new System.Drawing.Point(7, 171);
            this.UseComboBox.Name = "UseComboBox";
            this.UseComboBox.Size = new System.Drawing.Size(66, 21);
            this.UseComboBox.TabIndex = 183;
            this.UseComboBox.Text = "Use";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(84, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 186;
            this.label9.Text = "Leftover";
            // 
            // Task_Millisecond
            // 
            this.Task_Millisecond.AutoSize = true;
            this.Task_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Task_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Millisecond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Task_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Task_Millisecond.Location = new System.Drawing.Point(179, 80);
            this.Task_Millisecond.Name = "Task_Millisecond";
            this.Task_Millisecond.Size = new System.Drawing.Size(28, 21);
            this.Task_Millisecond.TabIndex = 181;
            this.Task_Millisecond.Text = "85";
            // 
            // LeftoverLabel
            // 
            this.LeftoverLabel.AutoSize = true;
            this.LeftoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftoverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LeftoverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LeftoverLabel.Location = new System.Drawing.Point(85, 130);
            this.LeftoverLabel.Name = "LeftoverLabel";
            this.LeftoverLabel.Size = new System.Drawing.Size(41, 21);
            this.LeftoverLabel.TabIndex = 184;
            this.LeftoverLabel.Text = "0.00";
            // 
            // DayProgress
            // 
            this.DayProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.DayProgress.AnimationSpeed = 500;
            this.DayProgress.BackColor = System.Drawing.Color.White;
            this.DayProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DayProgress.ForeColor = System.Drawing.Color.Black;
            this.DayProgress.InnerColor = System.Drawing.Color.Transparent;
            this.DayProgress.InnerMargin = 2;
            this.DayProgress.InnerWidth = -1;
            this.DayProgress.Location = new System.Drawing.Point(7, 70);
            this.DayProgress.MarqueeAnimationSpeed = 2000;
            this.DayProgress.Name = "DayProgress";
            this.DayProgress.OuterColor = System.Drawing.Color.Silver;
            this.DayProgress.OuterMargin = -5;
            this.DayProgress.OuterWidth = 3;
            this.DayProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.DayProgress.ProgressWidth = 3;
            this.DayProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DayProgress.Size = new System.Drawing.Size(40, 40);
            this.DayProgress.StartAngle = 270;
            this.DayProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DayProgress.SubscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SubscriptText = "";
            this.DayProgress.SuperscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SuperscriptText = "";
            this.DayProgress.TabIndex = 167;
            this.DayProgress.Text = "0";
            this.DayProgress.TextMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.Value = 50;
            // 
            // Task_SecondPeriod
            // 
            this.Task_SecondPeriod.AutoSize = true;
            this.Task_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Task_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Task_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Task_SecondPeriod.Location = new System.Drawing.Point(172, 76);
            this.Task_SecondPeriod.Name = "Task_SecondPeriod";
            this.Task_SecondPeriod.Size = new System.Drawing.Size(17, 25);
            this.Task_SecondPeriod.TabIndex = 180;
            this.Task_SecondPeriod.Text = ".";
            // 
            // MoveLeftOverButton
            // 
            this.MoveLeftOverButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveLeftOverButton.Enabled = false;
            this.MoveLeftOverButton.FlatAppearance.BorderSize = 0;
            this.MoveLeftOverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.MoveLeftOverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MoveLeftOverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLeftOverButton.Font = new System.Drawing.Font("Wingdings 3", 12.5F);
            this.MoveLeftOverButton.Location = new System.Drawing.Point(55, 129);
            this.MoveLeftOverButton.Name = "MoveLeftOverButton";
            this.MoveLeftOverButton.Size = new System.Drawing.Size(24, 24);
            this.MoveLeftOverButton.TabIndex = 185;
            this.MoveLeftOverButton.Text = "f";
            this.MoveLeftOverButton.UseVisualStyleBackColor = false;
            // 
            // UseButton
            // 
            this.UseButton.FlatAppearance.BorderSize = 0;
            this.UseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseButton.Location = new System.Drawing.Point(166, 172);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(52, 42);
            this.UseButton.TabIndex = 189;
            this.UseButton.Text = "Enter";
            this.UseButton.UseVisualStyleBackColor = true;
            // 
            // Task_Second
            // 
            this.Task_Second.AutoSize = true;
            this.Task_Second.BackColor = System.Drawing.Color.Transparent;
            this.Task_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Second.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Task_Second.ForeColor = System.Drawing.Color.Gray;
            this.Task_Second.Location = new System.Drawing.Point(143, 72);
            this.Task_Second.Name = "Task_Second";
            this.Task_Second.Size = new System.Drawing.Size(57, 32);
            this.Task_Second.TabIndex = 177;
            this.Task_Second.Text = "485";
            // 
            // Task_MinuteColon
            // 
            this.Task_MinuteColon.AutoSize = true;
            this.Task_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Task_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_MinuteColon.Location = new System.Drawing.Point(132, 70);
            this.Task_MinuteColon.Name = "Task_MinuteColon";
            this.Task_MinuteColon.Size = new System.Drawing.Size(21, 32);
            this.Task_MinuteColon.TabIndex = 179;
            this.Task_MinuteColon.Text = ":";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.TaskLabel.Location = new System.Drawing.Point(9, 197);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(46, 13);
            this.TaskLabel.TabIndex = 190;
            this.TaskLabel.Text = "Issue #:";
            // 
            // APSCheckbox
            // 
            this.APSCheckbox.AutoSize = true;
            this.APSCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.APSCheckbox.Location = new System.Drawing.Point(79, 172);
            this.APSCheckbox.Name = "APSCheckbox";
            this.APSCheckbox.Size = new System.Drawing.Size(92, 15);
            this.APSCheckbox.TabIndex = 194;
            this.APSCheckbox.Text = "APS Hours Utilized";
            this.APSCheckbox.UseVisualStyleBackColor = true;
            // 
            // Task_Minute
            // 
            this.Task_Minute.AutoSize = true;
            this.Task_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Task_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Minute.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Task_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Task_Minute.Location = new System.Drawing.Point(101, 72);
            this.Task_Minute.Name = "Task_Minute";
            this.Task_Minute.Size = new System.Drawing.Size(43, 32);
            this.Task_Minute.TabIndex = 176;
            this.Task_Minute.Text = "00";
            // 
            // Task_HourColon
            // 
            this.Task_HourColon.AutoSize = true;
            this.Task_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Task_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_HourColon.Location = new System.Drawing.Point(92, 70);
            this.Task_HourColon.Name = "Task_HourColon";
            this.Task_HourColon.Size = new System.Drawing.Size(21, 32);
            this.Task_HourColon.TabIndex = 178;
            this.Task_HourColon.Text = ":";
            // 
            // IssueNumber
            // 
            this.IssueNumber.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.IssueNumber.Location = new System.Drawing.Point(61, 196);
            this.IssueNumber.Name = "IssueNumber";
            this.IssueNumber.Size = new System.Drawing.Size(99, 18);
            this.IssueNumber.TabIndex = 191;
            // 
            // Global_Hour
            // 
            this.Global_Hour.AutoSize = true;
            this.Global_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Global_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Hour.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Global_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Global_Hour.Location = new System.Drawing.Point(20, 6);
            this.Global_Hour.Name = "Global_Hour";
            this.Global_Hour.Size = new System.Drawing.Size(56, 45);
            this.Global_Hour.TabIndex = 168;
            this.Global_Hour.Text = "00";
            // 
            // Task_Hour
            // 
            this.Task_Hour.AutoSize = true;
            this.Task_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Task_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Hour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Task_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Task_Hour.Location = new System.Drawing.Point(63, 72);
            this.Task_Hour.Name = "Task_Hour";
            this.Task_Hour.Size = new System.Drawing.Size(43, 32);
            this.Task_Hour.TabIndex = 175;
            this.Task_Hour.Text = "00";
            // 
            // themeListView
            // 
            this.themeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.themeListView.FullRowSelect = true;
            this.themeListView.Location = new System.Drawing.Point(10, 37);
            this.themeListView.MultiSelect = false;
            this.themeListView.Name = "themeListView";
            this.themeListView.Size = new System.Drawing.Size(184, 138);
            this.themeListView.TabIndex = 170;
            this.themeListView.UseCompatibleStateImageBehavior = false;
            this.themeListView.View = System.Windows.Forms.View.SmallIcon;
            this.themeListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.themeListView_MouseDoubleClick);
            // 
            // themeList
            // 
            this.themeList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.themeList.ImageSize = new System.Drawing.Size(16, 16);
            this.themeList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ThemeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 236);
            this.Controls.Add(this.themeListView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PreviewPanel);
            this.Controls.Add(this.ThemeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelThemeButton);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemeCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme Creator";
            this.Load += new System.EventHandler(this.ThemeCreator_Load);
            this.PreviewPanel.ResumeLayout(false);
            this.PreviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelThemeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ThemeName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel PreviewPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentTaskLabel;
        private System.Windows.Forms.ComboBox UseComboBox;
        private System.Windows.Forms.Label Global_Second;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Global_MinuteColon;
        private System.Windows.Forms.Label Task_Millisecond;
        private System.Windows.Forms.Label LeftoverLabel;
        private CircularProgressBar.CircularProgressBar DayProgress;
        private System.Windows.Forms.Label Task_SecondPeriod;
        private System.Windows.Forms.Button MoveLeftOverButton;
        private System.Windows.Forms.Label Global_SecondPeriod;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Label Task_Second;
        private System.Windows.Forms.Label Global_Minute;
        private System.Windows.Forms.Label Task_MinuteColon;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.CheckBox APSCheckbox;
        private System.Windows.Forms.Label Task_Minute;
        private System.Windows.Forms.Label Task_HourColon;
        private System.Windows.Forms.Label Global_Millisecond;
        private System.Windows.Forms.TextBox IssueNumber;
        private System.Windows.Forms.Label Global_Hour;
        private System.Windows.Forms.Label Global_HourColon;
        private System.Windows.Forms.Label Task_Hour;
        private System.Windows.Forms.ListView themeListView;
        private System.Windows.Forms.ImageList themeList;
    }
}