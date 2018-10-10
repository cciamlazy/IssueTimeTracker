namespace IssueTimeTracker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DayProgress = new CircularProgressBar.CircularProgressBar();
            this.Global_Timer = new System.Windows.Forms.Timer(this.components);
            this.Global_Hour = new System.Windows.Forms.Label();
            this.Global_Minute = new System.Windows.Forms.Label();
            this.Global_Second = new System.Windows.Forms.Label();
            this.Global_HourColon = new System.Windows.Forms.Label();
            this.Global_MinuteColon = new System.Windows.Forms.Label();
            this.Global_SecondPeriod = new System.Windows.Forms.Label();
            this.Global_Millisecond = new System.Windows.Forms.Label();
            this.Task_Millisecond = new System.Windows.Forms.Label();
            this.Task_SecondPeriod = new System.Windows.Forms.Label();
            this.Task_Second = new System.Windows.Forms.Label();
            this.Task_MinuteColon = new System.Windows.Forms.Label();
            this.Task_Minute = new System.Windows.Forms.Label();
            this.Task_HourColon = new System.Windows.Forms.Label();
            this.Task_Hour = new System.Windows.Forms.Label();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.UseComboBox = new System.Windows.Forms.ComboBox();
            this.LeftoverLabel = new System.Windows.Forms.Label();
            this.MoveLeftOverButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastTaskLabel = new System.Windows.Forms.Label();
            this.StartPauseButton = new System.Windows.Forms.Button();
            this.UseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.LACounty = new System.Windows.Forms.Timer(this.components);
            this.TaskLabel = new System.Windows.Forms.Label();
            this.IssueNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JiraTicketChecker = new System.Windows.Forms.Timer(this.components);
            this.IssueNumberCombo = new System.Windows.Forms.ComboBox();
            this.MessageWatcher = new System.Windows.Forms.Timer(this.components);
            this.APSCheckbox = new System.Windows.Forms.CheckBox();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jiraBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearChromeCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jiraDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataVisualizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstTimeSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.DayProgress.Location = new System.Drawing.Point(14, 106);
            this.DayProgress.MarqueeAnimationSpeed = 2000;
            this.DayProgress.Name = "DayProgress";
            this.DayProgress.OuterColor = System.Drawing.Color.Silver;
            this.DayProgress.OuterMargin = -5;
            this.DayProgress.OuterWidth = 3;
            this.DayProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.DayProgress.ProgressWidth = 3;
            this.DayProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DayProgress.Size = new System.Drawing.Size(64, 64);
            this.DayProgress.StartAngle = 270;
            this.DayProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DayProgress.SubscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SubscriptText = "";
            this.DayProgress.SuperscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SuperscriptText = "";
            this.DayProgress.TabIndex = 0;
            this.DayProgress.Text = "0";
            this.DayProgress.TextMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.Value = 100;
            // 
            // Global_Timer
            // 
            this.Global_Timer.Enabled = true;
            this.Global_Timer.Interval = 25;
            this.Global_Timer.Tick += new System.EventHandler(this.Global_Timer_Tick);
            // 
            // Global_Hour
            // 
            this.Global_Hour.AutoSize = true;
            this.Global_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Global_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Hour.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Global_Hour.Location = new System.Drawing.Point(17, 38);
            this.Global_Hour.Name = "Global_Hour";
            this.Global_Hour.Size = new System.Drawing.Size(84, 65);
            this.Global_Hour.TabIndex = 1;
            this.Global_Hour.Text = "00";
            // 
            // Global_Minute
            // 
            this.Global_Minute.AutoSize = true;
            this.Global_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Global_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Minute.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Global_Minute.Location = new System.Drawing.Point(87, 38);
            this.Global_Minute.Name = "Global_Minute";
            this.Global_Minute.Size = new System.Drawing.Size(84, 65);
            this.Global_Minute.TabIndex = 2;
            this.Global_Minute.Text = "00";
            // 
            // Global_Second
            // 
            this.Global_Second.AutoSize = true;
            this.Global_Second.BackColor = System.Drawing.Color.Transparent;
            this.Global_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Second.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Second.ForeColor = System.Drawing.Color.Gray;
            this.Global_Second.Location = new System.Drawing.Point(157, 38);
            this.Global_Second.Name = "Global_Second";
            this.Global_Second.Size = new System.Drawing.Size(84, 65);
            this.Global_Second.TabIndex = 100;
            this.Global_Second.Text = "00";
            // 
            // Global_HourColon
            // 
            this.Global_HourColon.AutoSize = true;
            this.Global_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_HourColon.Location = new System.Drawing.Point(74, 34);
            this.Global_HourColon.Name = "Global_HourColon";
            this.Global_HourColon.Size = new System.Drawing.Size(40, 65);
            this.Global_HourColon.TabIndex = 101;
            this.Global_HourColon.Text = ":";
            // 
            // Global_MinuteColon
            // 
            this.Global_MinuteColon.AutoSize = true;
            this.Global_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_MinuteColon.Location = new System.Drawing.Point(144, 34);
            this.Global_MinuteColon.Name = "Global_MinuteColon";
            this.Global_MinuteColon.Size = new System.Drawing.Size(40, 65);
            this.Global_MinuteColon.TabIndex = 102;
            this.Global_MinuteColon.Text = ":";
            // 
            // Global_SecondPeriod
            // 
            this.Global_SecondPeriod.AutoSize = true;
            this.Global_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Global_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Global_SecondPeriod.Location = new System.Drawing.Point(215, 50);
            this.Global_SecondPeriod.Name = "Global_SecondPeriod";
            this.Global_SecondPeriod.Size = new System.Drawing.Size(28, 47);
            this.Global_SecondPeriod.TabIndex = 103;
            this.Global_SecondPeriod.Text = ".";
            // 
            // Global_Millisecond
            // 
            this.Global_Millisecond.AutoSize = true;
            this.Global_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Global_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Millisecond.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Global_Millisecond.Location = new System.Drawing.Point(227, 52);
            this.Global_Millisecond.Name = "Global_Millisecond";
            this.Global_Millisecond.Size = new System.Drawing.Size(56, 45);
            this.Global_Millisecond.TabIndex = 104;
            this.Global_Millisecond.Text = "00";
            // 
            // Task_Millisecond
            // 
            this.Task_Millisecond.AutoSize = true;
            this.Task_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Task_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Millisecond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Task_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Task_Millisecond.Location = new System.Drawing.Point(243, 123);
            this.Task_Millisecond.Name = "Task_Millisecond";
            this.Task_Millisecond.Size = new System.Drawing.Size(28, 21);
            this.Task_Millisecond.TabIndex = 114;
            this.Task_Millisecond.Text = "00";
            // 
            // Task_SecondPeriod
            // 
            this.Task_SecondPeriod.AutoSize = true;
            this.Task_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Task_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Task_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Task_SecondPeriod.Location = new System.Drawing.Point(234, 120);
            this.Task_SecondPeriod.Name = "Task_SecondPeriod";
            this.Task_SecondPeriod.Size = new System.Drawing.Size(17, 25);
            this.Task_SecondPeriod.TabIndex = 113;
            this.Task_SecondPeriod.Text = ".";
            // 
            // Task_Second
            // 
            this.Task_Second.AutoSize = true;
            this.Task_Second.BackColor = System.Drawing.Color.Transparent;
            this.Task_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Second.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Second.ForeColor = System.Drawing.Color.Gray;
            this.Task_Second.Location = new System.Drawing.Point(195, 106);
            this.Task_Second.Name = "Task_Second";
            this.Task_Second.Size = new System.Drawing.Size(56, 45);
            this.Task_Second.TabIndex = 110;
            this.Task_Second.Text = "00";
            // 
            // Task_MinuteColon
            // 
            this.Task_MinuteColon.AutoSize = true;
            this.Task_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Task_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_MinuteColon.Location = new System.Drawing.Point(182, 103);
            this.Task_MinuteColon.Name = "Task_MinuteColon";
            this.Task_MinuteColon.Size = new System.Drawing.Size(28, 45);
            this.Task_MinuteColon.TabIndex = 112;
            this.Task_MinuteColon.Text = ":";
            // 
            // Task_Minute
            // 
            this.Task_Minute.AutoSize = true;
            this.Task_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Task_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Minute.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Task_Minute.Location = new System.Drawing.Point(143, 106);
            this.Task_Minute.Name = "Task_Minute";
            this.Task_Minute.Size = new System.Drawing.Size(56, 45);
            this.Task_Minute.TabIndex = 109;
            this.Task_Minute.Text = "00";
            // 
            // Task_HourColon
            // 
            this.Task_HourColon.AutoSize = true;
            this.Task_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Task_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_HourColon.Location = new System.Drawing.Point(131, 103);
            this.Task_HourColon.Name = "Task_HourColon";
            this.Task_HourColon.Size = new System.Drawing.Size(28, 45);
            this.Task_HourColon.TabIndex = 111;
            this.Task_HourColon.Text = ":";
            // 
            // Task_Hour
            // 
            this.Task_Hour.AutoSize = true;
            this.Task_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Task_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Hour.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Task_Hour.Location = new System.Drawing.Point(92, 106);
            this.Task_Hour.Name = "Task_Hour";
            this.Task_Hour.Size = new System.Drawing.Size(56, 45);
            this.Task_Hour.TabIndex = 108;
            this.Task_Hour.Text = "00";
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTaskLabel.Location = new System.Drawing.Point(23, 176);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(55, 30);
            this.CurrentTaskLabel.TabIndex = 115;
            this.CurrentTaskLabel.Text = "0.00";
            this.CurrentTaskLabel.TextChanged += new System.EventHandler(this.CurrentTaskLabel_TextChanged);
            // 
            // UseComboBox
            // 
            this.UseComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseComboBox.FormattingEnabled = true;
            this.UseComboBox.Location = new System.Drawing.Point(20, 211);
            this.UseComboBox.Name = "UseComboBox";
            this.UseComboBox.Size = new System.Drawing.Size(66, 29);
            this.UseComboBox.TabIndex = 116;
            this.UseComboBox.Text = "Use";
            // 
            // LeftoverLabel
            // 
            this.LeftoverLabel.AutoSize = true;
            this.LeftoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftoverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LeftoverLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftoverLabel.Location = new System.Drawing.Point(102, 176);
            this.LeftoverLabel.Name = "LeftoverLabel";
            this.LeftoverLabel.Size = new System.Drawing.Size(55, 30);
            this.LeftoverLabel.TabIndex = 117;
            this.LeftoverLabel.Text = "0.00";
            this.LeftoverLabel.TextChanged += new System.EventHandler(this.LeftoverLabel_TextChanged);
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
            this.MoveLeftOverButton.Location = new System.Drawing.Point(70, 179);
            this.MoveLeftOverButton.Name = "MoveLeftOverButton";
            this.MoveLeftOverButton.Size = new System.Drawing.Size(28, 28);
            this.MoveLeftOverButton.TabIndex = 118;
            this.MoveLeftOverButton.Text = "f";
            this.MoveLeftOverButton.UseVisualStyleBackColor = false;
            this.MoveLeftOverButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "Leftover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 121;
            this.label2.Text = "Last Task";
            this.label2.Visible = false;
            // 
            // LastTaskLabel
            // 
            this.LastTaskLabel.AutoSize = true;
            this.LastTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LastTaskLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTaskLabel.Location = new System.Drawing.Point(220, 176);
            this.LastTaskLabel.Name = "LastTaskLabel";
            this.LastTaskLabel.Size = new System.Drawing.Size(55, 30);
            this.LastTaskLabel.TabIndex = 120;
            this.LastTaskLabel.Text = "0.00";
            this.LastTaskLabel.Visible = false;
            this.LastTaskLabel.TextChanged += new System.EventHandler(this.LastTaskLabel_TextChanged);
            this.LastTaskLabel.Click += new System.EventHandler(this.LastTaskLabel_Click);
            // 
            // StartPauseButton
            // 
            this.StartPauseButton.FlatAppearance.BorderSize = 0;
            this.StartPauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StartPauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartPauseButton.Font = new System.Drawing.Font("Wingdings 3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StartPauseButton.Location = new System.Drawing.Point(184, 4);
            this.StartPauseButton.Name = "StartPauseButton";
            this.StartPauseButton.Size = new System.Drawing.Size(42, 42);
            this.StartPauseButton.TabIndex = 123;
            this.StartPauseButton.Text = "w";
            this.StartPauseButton.UseVisualStyleBackColor = true;
            this.StartPauseButton.Click += new System.EventHandler(this.StartPauseButton_Click);
            // 
            // UseButton
            // 
            this.UseButton.FlatAppearance.BorderSize = 0;
            this.UseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UseButton.Location = new System.Drawing.Point(217, 225);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(58, 45);
            this.UseButton.TabIndex = 124;
            this.UseButton.Text = "Enter";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StopButton.Location = new System.Drawing.Point(229, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(42, 42);
            this.StopButton.TabIndex = 125;
            this.StopButton.Text = "c";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LACounty
            // 
            this.LACounty.Enabled = true;
            this.LACounty.Interval = 800000;
            this.LACounty.Tick += new System.EventHandler(this.LACounty_Tick);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TaskLabel.Location = new System.Drawing.Point(19, 246);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(65, 21);
            this.TaskLabel.TabIndex = 127;
            this.TaskLabel.Text = "Issue #:";
            // 
            // IssueNumber
            // 
            this.IssueNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IssueNumber.Location = new System.Drawing.Point(78, 247);
            this.IssueNumber.Name = "IssueNumber";
            this.IssueNumber.Size = new System.Drawing.Size(135, 22);
            this.IssueNumber.TabIndex = 128;
            this.IssueNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IssueNumber_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(10, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 1);
            this.panel1.TabIndex = 130;
            // 
            // JiraTicketChecker
            // 
            this.JiraTicketChecker.Interval = 30000;
            this.JiraTicketChecker.Tick += new System.EventHandler(this.JiraChecker_Tick);
            // 
            // IssueNumberCombo
            // 
            this.IssueNumberCombo.BackColor = System.Drawing.Color.White;
            this.IssueNumberCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueNumberCombo.Font = new System.Drawing.Font("Segoe UI", 8.63F);
            this.IssueNumberCombo.FormattingEnabled = true;
            this.IssueNumberCombo.Location = new System.Drawing.Point(78, 247);
            this.IssueNumberCombo.Name = "IssueNumberCombo";
            this.IssueNumberCombo.Size = new System.Drawing.Size(135, 23);
            this.IssueNumberCombo.TabIndex = 132;
            this.IssueNumberCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IssueNumberCombo_KeyPress);
            // 
            // MessageWatcher
            // 
            this.MessageWatcher.Interval = 1000;
            this.MessageWatcher.Tick += new System.EventHandler(this.MessageWatcher_Tick);
            // 
            // APSCheckbox
            // 
            this.APSCheckbox.AutoSize = true;
            this.APSCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APSCheckbox.Location = new System.Drawing.Point(93, 225);
            this.APSCheckbox.Name = "APSCheckbox";
            this.APSCheckbox.Size = new System.Drawing.Size(120, 17);
            this.APSCheckbox.TabIndex = 135;
            this.APSCheckbox.Text = "APS Hours Utilized";
            this.APSCheckbox.UseVisualStyleBackColor = true;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.Transparent;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(282, 24);
            this.TopMenu.TabIndex = 136;
            this.TopMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useStripMenuItem1,
            this.startToolStripMenuItem,
            this.endToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.suggestionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // useStripMenuItem1
            // 
            this.useStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.useStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.useStripMenuItem1.Name = "useStripMenuItem1";
            this.useStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.useStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.useStripMenuItem1.Text = "Enter Task";
            this.useStripMenuItem1.Click += new System.EventHandler(this.useStripMenuItem1_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.startToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.startToolStripMenuItem.Text = "Start Day";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.endToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.endToolStripMenuItem.Enabled = false;
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.endToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.endToolStripMenuItem.Text = "End Day";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // suggestionToolStripMenuItem
            // 
            this.suggestionToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.suggestionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.suggestionToolStripMenuItem.Name = "suggestionToolStripMenuItem";
            this.suggestionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.suggestionToolStripMenuItem.Text = "Make a Suggestion";
            this.suggestionToolStripMenuItem.Click += new System.EventHandler(this.suggestionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logBrowserToolStripMenuItem,
            this.jiraBrowserToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.taskListToolStripMenuItem});
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.browserToolStripMenuItem.Text = "Browser";
            // 
            // logBrowserToolStripMenuItem
            // 
            this.logBrowserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logBrowserToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logBrowserToolStripMenuItem.Name = "logBrowserToolStripMenuItem";
            this.logBrowserToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.logBrowserToolStripMenuItem.Text = "Log Browser";
            this.logBrowserToolStripMenuItem.Click += new System.EventHandler(this.logBrowserToolStripMenuItem_Click);
            // 
            // jiraBrowserToolStripMenuItem
            // 
            this.jiraBrowserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.jiraBrowserToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.jiraBrowserToolStripMenuItem.Enabled = false;
            this.jiraBrowserToolStripMenuItem.Name = "jiraBrowserToolStripMenuItem";
            this.jiraBrowserToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.jiraBrowserToolStripMenuItem.Text = "Jira Browser";
            this.jiraBrowserToolStripMenuItem.Click += new System.EventHandler(this.jiraBrowserToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.notesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.taskListToolStripMenuItem.Text = "Task List";
            this.taskListToolStripMenuItem.Visible = false;
            this.taskListToolStripMenuItem.Click += new System.EventHandler(this.taskListToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearChromeCacheToolStripMenuItem,
            this.manualStripMenuItem,
            this.cleanToolStripMenuItem,
            this.advancedToolStripMenuItem1,
            this.jiraDataToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.advancedToolStripMenuItem.Text = "Tools";
            // 
            // clearChromeCacheToolStripMenuItem
            // 
            this.clearChromeCacheToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.clearChromeCacheToolStripMenuItem.Name = "clearChromeCacheToolStripMenuItem";
            this.clearChromeCacheToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearChromeCacheToolStripMenuItem.Text = "Clear Chrome Cache";
            this.clearChromeCacheToolStripMenuItem.Visible = false;
            this.clearChromeCacheToolStripMenuItem.Click += new System.EventHandler(this.clearChromeCacheToolStripMenuItem_Click);
            // 
            // manualStripMenuItem
            // 
            this.manualStripMenuItem.BackColor = System.Drawing.Color.White;
            this.manualStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.manualStripMenuItem.Name = "manualStripMenuItem";
            this.manualStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manualStripMenuItem.Text = "Manually Enter Time";
            this.manualStripMenuItem.Click += new System.EventHandler(this.manualStripMenuItem_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cleanToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem1
            // 
            this.advancedToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.advancedToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.advancedToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterCommandToolStripMenuItem});
            this.advancedToolStripMenuItem1.Name = "advancedToolStripMenuItem1";
            this.advancedToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.advancedToolStripMenuItem1.Text = "Modify Use Amount";
            this.advancedToolStripMenuItem1.Click += new System.EventHandler(this.advancedToolStripMenuItem1_Click);
            // 
            // enterCommandToolStripMenuItem
            // 
            this.enterCommandToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.enterCommandToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enterCommandToolStripMenuItem.Name = "enterCommandToolStripMenuItem";
            this.enterCommandToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.enterCommandToolStripMenuItem.Text = "Enter Command";
            this.enterCommandToolStripMenuItem.Visible = false;
            this.enterCommandToolStripMenuItem.Click += new System.EventHandler(this.enterCommandToolStripMenuItem_Click);
            // 
            // jiraDataToolStripMenuItem
            // 
            this.jiraDataToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.jiraDataToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.jiraDataToolStripMenuItem.Enabled = false;
            this.jiraDataToolStripMenuItem.Name = "jiraDataToolStripMenuItem";
            this.jiraDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.jiraDataToolStripMenuItem.Text = "Jira Data";
            this.jiraDataToolStripMenuItem.Click += new System.EventHandler(this.jiraDataToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messengerToolStripMenuItem,
            this.applyThemeToolStripMenuItem,
            this.testToolStripMenuItem,
            this.dataVisualizerToolStripMenuItem,
            this.firstTimeSetupToolStripMenuItem,
            this.playgroundToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // messengerToolStripMenuItem
            // 
            this.messengerToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.messengerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.messengerToolStripMenuItem.Name = "messengerToolStripMenuItem";
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.messengerToolStripMenuItem.Text = "Messenger";
            this.messengerToolStripMenuItem.Click += new System.EventHandler(this.messengerToolStripMenuItem_Click);
            // 
            // applyThemeToolStripMenuItem
            // 
            this.applyThemeToolStripMenuItem.Name = "applyThemeToolStripMenuItem";
            this.applyThemeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.applyThemeToolStripMenuItem.Text = "Apply Theme";
            this.applyThemeToolStripMenuItem.Click += new System.EventHandler(this.applyThemeToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // dataVisualizerToolStripMenuItem
            // 
            this.dataVisualizerToolStripMenuItem.Name = "dataVisualizerToolStripMenuItem";
            this.dataVisualizerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dataVisualizerToolStripMenuItem.Text = "Data Visualizer";
            this.dataVisualizerToolStripMenuItem.Click += new System.EventHandler(this.dataVisualizerToolStripMenuItem_Click);
            // 
            // firstTimeSetupToolStripMenuItem
            // 
            this.firstTimeSetupToolStripMenuItem.Name = "firstTimeSetupToolStripMenuItem";
            this.firstTimeSetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.firstTimeSetupToolStripMenuItem.Text = "First Time Setup";
            this.firstTimeSetupToolStripMenuItem.Click += new System.EventHandler(this.firstTimeSetupToolStripMenuItem_Click);
            // 
            // playgroundToolStripMenuItem
            // 
            this.playgroundToolStripMenuItem.Name = "playgroundToolStripMenuItem";
            this.playgroundToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.playgroundToolStripMenuItem.Text = "Playground";
            this.playgroundToolStripMenuItem.Click += new System.EventHandler(this.playgroundToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartPauseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DayProgress);
            this.Controls.Add(this.APSCheckbox);
            this.Controls.Add(this.IssueNumberCombo);
            this.Controls.Add(this.IssueNumber);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.UseButton);
            this.Controls.Add(this.LastTaskLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoveLeftOverButton);
            this.Controls.Add(this.LeftoverLabel);
            this.Controls.Add(this.UseComboBox);
            this.Controls.Add(this.CurrentTaskLabel);
            this.Controls.Add(this.Task_Millisecond);
            this.Controls.Add(this.Task_SecondPeriod);
            this.Controls.Add(this.Task_Second);
            this.Controls.Add(this.Task_MinuteColon);
            this.Controls.Add(this.Task_Minute);
            this.Controls.Add(this.Task_HourColon);
            this.Controls.Add(this.Task_Hour);
            this.Controls.Add(this.Global_Millisecond);
            this.Controls.Add(this.Global_SecondPeriod);
            this.Controls.Add(this.Global_Second);
            this.Controls.Add(this.Global_MinuteColon);
            this.Controls.Add(this.Global_Minute);
            this.Controls.Add(this.Global_HourColon);
            this.Controls.Add(this.Global_Hour);
            this.Controls.Add(this.TopMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Issue Time Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.LocationChanged += new System.EventHandler(this.Main_LocationChanged);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Global_Timer;
        private System.Windows.Forms.Label Global_Hour;
        private System.Windows.Forms.Label Global_Minute;
        private System.Windows.Forms.Label Global_Second;
        private System.Windows.Forms.Label Global_HourColon;
        private System.Windows.Forms.Label Global_MinuteColon;
        private System.Windows.Forms.Label Global_SecondPeriod;
        private System.Windows.Forms.Label Global_Millisecond;
        private System.Windows.Forms.Label Task_Millisecond;
        private System.Windows.Forms.Label Task_SecondPeriod;
        private System.Windows.Forms.Label Task_Second;
        private System.Windows.Forms.Label Task_MinuteColon;
        private System.Windows.Forms.Label Task_Minute;
        private System.Windows.Forms.Label Task_HourColon;
        private System.Windows.Forms.Label Task_Hour;
        private System.Windows.Forms.Label CurrentTaskLabel;
        private System.Windows.Forms.ComboBox UseComboBox;
        private System.Windows.Forms.Label LeftoverLabel;
        private System.Windows.Forms.Button MoveLeftOverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LastTaskLabel;
        private System.Windows.Forms.Button StartPauseButton;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer LACounty;
        private CircularProgressBar.CircularProgressBar DayProgress;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.TextBox IssueNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox IssueNumberCombo;
        private System.Windows.Forms.Timer MessageWatcher;
        private System.Windows.Forms.CheckBox APSCheckbox;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jiraBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suggestionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jiraDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataVisualizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstTimeSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCommandToolStripMenuItem;
        public System.Windows.Forms.Timer JiraTicketChecker;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearChromeCacheToolStripMenuItem;
    }
}

