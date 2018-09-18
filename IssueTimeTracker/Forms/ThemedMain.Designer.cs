namespace IssueTimeTracker
{
    partial class ThemedMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemedMain));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IconI = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartPauseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DayProgress = new CircularProgressBar.CircularProgressBar();
            this.APSCheckbox = new System.Windows.Forms.CheckBox();
            this.IssueNumberCombo = new System.Windows.Forms.ComboBox();
            this.IssueNumber = new System.Windows.Forms.TextBox();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.UseButton = new System.Windows.Forms.Button();
            this.LastTaskLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveLeftOverButton = new System.Windows.Forms.Button();
            this.LeftoverLabel = new System.Windows.Forms.Label();
            this.UseComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.Task_Millisecond = new System.Windows.Forms.Label();
            this.Task_SecondPeriod = new System.Windows.Forms.Label();
            this.Task_Second = new System.Windows.Forms.Label();
            this.Task_MinuteColon = new System.Windows.Forms.Label();
            this.Task_Minute = new System.Windows.Forms.Label();
            this.Task_HourColon = new System.Windows.Forms.Label();
            this.Task_Hour = new System.Windows.Forms.Label();
            this.Global_Millisecond = new System.Windows.Forms.Label();
            this.Global_SecondPeriod = new System.Windows.Forms.Label();
            this.Global_Second = new System.Windows.Forms.Label();
            this.Global_MinuteColon = new System.Windows.Forms.Label();
            this.Global_Minute = new System.Windows.Forms.Label();
            this.Global_HourColon = new System.Windows.Forms.Label();
            this.Global_Hour = new System.Windows.Forms.Label();
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
            this.colorPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Global_Timer = new System.Windows.Forms.Timer(this.components);
            this.LACounty = new System.Windows.Forms.Timer(this.components);
            this.JiraChecker = new System.Windows.Forms.Timer(this.components);
            this.Animator = new System.Windows.Forms.Timer(this.components);
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconI)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.ExitButton);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(300, 30);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(217, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 30);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(29, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(137, 21);
            this.Title.TabIndex = 1;
            this.Title.Text = "Issue Time Tracker";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(260, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Tag = "NoTheme";
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // IconI
            // 
            this.IconI.ErrorImage = ((System.Drawing.Image)(resources.GetObject("IconI.ErrorImage")));
            this.IconI.Image = ((System.Drawing.Image)(resources.GetObject("IconI.Image")));
            this.IconI.InitialImage = ((System.Drawing.Image)(resources.GetObject("IconI.InitialImage")));
            this.IconI.Location = new System.Drawing.Point(7, 7);
            this.IconI.Name = "IconI";
            this.IconI.Size = new System.Drawing.Size(16, 16);
            this.IconI.TabIndex = 2;
            this.IconI.TabStop = false;
            this.IconI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.IconI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.IconI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.StopButton);
            this.MainPanel.Controls.Add(this.StartPauseButton);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.DayProgress);
            this.MainPanel.Controls.Add(this.APSCheckbox);
            this.MainPanel.Controls.Add(this.IssueNumberCombo);
            this.MainPanel.Controls.Add(this.IssueNumber);
            this.MainPanel.Controls.Add(this.TaskLabel);
            this.MainPanel.Controls.Add(this.UseButton);
            this.MainPanel.Controls.Add(this.LastTaskLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.MoveLeftOverButton);
            this.MainPanel.Controls.Add(this.LeftoverLabel);
            this.MainPanel.Controls.Add(this.UseComboBox);
            this.MainPanel.Controls.Add(this.CurrentTaskLabel);
            this.MainPanel.Controls.Add(this.Task_Millisecond);
            this.MainPanel.Controls.Add(this.Task_SecondPeriod);
            this.MainPanel.Controls.Add(this.Task_Second);
            this.MainPanel.Controls.Add(this.Task_MinuteColon);
            this.MainPanel.Controls.Add(this.Task_Minute);
            this.MainPanel.Controls.Add(this.Task_HourColon);
            this.MainPanel.Controls.Add(this.Task_Hour);
            this.MainPanel.Controls.Add(this.Global_Millisecond);
            this.MainPanel.Controls.Add(this.Global_SecondPeriod);
            this.MainPanel.Controls.Add(this.Global_Second);
            this.MainPanel.Controls.Add(this.Global_MinuteColon);
            this.MainPanel.Controls.Add(this.Global_Minute);
            this.MainPanel.Controls.Add(this.Global_HourColon);
            this.MainPanel.Controls.Add(this.Global_Hour);
            this.MainPanel.Controls.Add(this.TopMenu);
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(300, 300);
            this.MainPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 158;
            this.label2.Text = "Last Task";
            this.label2.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StopButton.Location = new System.Drawing.Point(246, 17);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(42, 42);
            this.StopButton.TabIndex = 161;
            this.StopButton.Text = "c";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StartPauseButton
            // 
            this.StartPauseButton.FlatAppearance.BorderSize = 0;
            this.StartPauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StartPauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartPauseButton.Font = new System.Drawing.Font("Wingdings 3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StartPauseButton.Location = new System.Drawing.Point(201, 17);
            this.StartPauseButton.Name = "StartPauseButton";
            this.StartPauseButton.Size = new System.Drawing.Size(42, 42);
            this.StartPauseButton.TabIndex = 159;
            this.StartPauseButton.Text = "w";
            this.StartPauseButton.UseVisualStyleBackColor = true;
            this.StartPauseButton.Click += new System.EventHandler(this.StartPauseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(10, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 164;
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
            this.DayProgress.Location = new System.Drawing.Point(14, 121);
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
            this.DayProgress.TabIndex = 137;
            this.DayProgress.Text = "0";
            this.DayProgress.TextMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.Value = 100;
            // 
            // APSCheckbox
            // 
            this.APSCheckbox.AutoSize = true;
            this.APSCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APSCheckbox.Location = new System.Drawing.Point(104, 242);
            this.APSCheckbox.Name = "APSCheckbox";
            this.APSCheckbox.Size = new System.Drawing.Size(120, 17);
            this.APSCheckbox.TabIndex = 166;
            this.APSCheckbox.Text = "APS Hours Utilized";
            this.APSCheckbox.UseVisualStyleBackColor = true;
            // 
            // IssueNumberCombo
            // 
            this.IssueNumberCombo.BackColor = System.Drawing.Color.White;
            this.IssueNumberCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueNumberCombo.Font = new System.Drawing.Font("Segoe UI", 8.63F);
            this.IssueNumberCombo.FormattingEnabled = true;
            this.IssueNumberCombo.Location = new System.Drawing.Point(70, 265);
            this.IssueNumberCombo.Name = "IssueNumberCombo";
            this.IssueNumberCombo.Size = new System.Drawing.Size(154, 23);
            this.IssueNumberCombo.TabIndex = 165;
            // 
            // IssueNumber
            // 
            this.IssueNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IssueNumber.Location = new System.Drawing.Point(70, 265);
            this.IssueNumber.Name = "IssueNumber";
            this.IssueNumber.Size = new System.Drawing.Size(154, 22);
            this.IssueNumber.TabIndex = 163;
            this.IssueNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IssueNumber_KeyPress);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TaskLabel.Location = new System.Drawing.Point(12, 264);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(65, 21);
            this.TaskLabel.TabIndex = 162;
            this.TaskLabel.Text = "Issue #:";
            // 
            // UseButton
            // 
            this.UseButton.FlatAppearance.BorderSize = 0;
            this.UseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UseButton.Location = new System.Drawing.Point(230, 243);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(58, 45);
            this.UseButton.TabIndex = 160;
            this.UseButton.Text = "Enter";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // LastTaskLabel
            // 
            this.LastTaskLabel.AutoSize = true;
            this.LastTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LastTaskLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTaskLabel.Location = new System.Drawing.Point(225, 191);
            this.LastTaskLabel.Name = "LastTaskLabel";
            this.LastTaskLabel.Size = new System.Drawing.Size(55, 30);
            this.LastTaskLabel.TabIndex = 157;
            this.LastTaskLabel.Text = "0.00";
            this.LastTaskLabel.Visible = false;
            this.LastTaskLabel.TextChanged += new System.EventHandler(this.LastTaskLabel_TextChanged);
            this.LastTaskLabel.Click += new System.EventHandler(this.LastTaskLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 156;
            this.label1.Text = "Leftover";
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
            this.MoveLeftOverButton.Location = new System.Drawing.Point(70, 194);
            this.MoveLeftOverButton.Name = "MoveLeftOverButton";
            this.MoveLeftOverButton.Size = new System.Drawing.Size(28, 28);
            this.MoveLeftOverButton.TabIndex = 155;
            this.MoveLeftOverButton.Text = "f";
            this.MoveLeftOverButton.UseVisualStyleBackColor = false;
            this.MoveLeftOverButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LeftoverLabel
            // 
            this.LeftoverLabel.AutoSize = true;
            this.LeftoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftoverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LeftoverLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftoverLabel.Location = new System.Drawing.Point(102, 191);
            this.LeftoverLabel.Name = "LeftoverLabel";
            this.LeftoverLabel.Size = new System.Drawing.Size(55, 30);
            this.LeftoverLabel.TabIndex = 154;
            this.LeftoverLabel.Text = "0.00";
            this.LeftoverLabel.TextChanged += new System.EventHandler(this.LeftoverLabel_TextChanged);
            // 
            // UseComboBox
            // 
            this.UseComboBox.BackColor = System.Drawing.Color.White;
            this.UseComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseComboBox.FormattingEnabled = true;
            this.UseComboBox.Location = new System.Drawing.Point(12, 228);
            this.UseComboBox.Name = "UseComboBox";
            this.UseComboBox.Size = new System.Drawing.Size(66, 29);
            this.UseComboBox.TabIndex = 153;
            this.UseComboBox.Text = "Use";
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTaskLabel.Location = new System.Drawing.Point(17, 191);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(55, 30);
            this.CurrentTaskLabel.TabIndex = 152;
            this.CurrentTaskLabel.Text = "0.00";
            this.CurrentTaskLabel.TextChanged += new System.EventHandler(this.CurrentTaskLabel_TextChanged);
            // 
            // Task_Millisecond
            // 
            this.Task_Millisecond.AutoSize = true;
            this.Task_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Task_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Millisecond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Task_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Task_Millisecond.Location = new System.Drawing.Point(245, 138);
            this.Task_Millisecond.Name = "Task_Millisecond";
            this.Task_Millisecond.Size = new System.Drawing.Size(28, 21);
            this.Task_Millisecond.TabIndex = 151;
            this.Task_Millisecond.Text = "00";
            // 
            // Task_SecondPeriod
            // 
            this.Task_SecondPeriod.AutoSize = true;
            this.Task_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Task_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Task_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Task_SecondPeriod.Location = new System.Drawing.Point(236, 135);
            this.Task_SecondPeriod.Name = "Task_SecondPeriod";
            this.Task_SecondPeriod.Size = new System.Drawing.Size(17, 25);
            this.Task_SecondPeriod.TabIndex = 150;
            this.Task_SecondPeriod.Text = ".";
            // 
            // Task_Second
            // 
            this.Task_Second.AutoSize = true;
            this.Task_Second.BackColor = System.Drawing.Color.Transparent;
            this.Task_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Second.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Second.ForeColor = System.Drawing.Color.Gray;
            this.Task_Second.Location = new System.Drawing.Point(197, 121);
            this.Task_Second.Name = "Task_Second";
            this.Task_Second.Size = new System.Drawing.Size(56, 45);
            this.Task_Second.TabIndex = 147;
            this.Task_Second.Text = "00";
            // 
            // Task_MinuteColon
            // 
            this.Task_MinuteColon.AutoSize = true;
            this.Task_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Task_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_MinuteColon.Location = new System.Drawing.Point(184, 118);
            this.Task_MinuteColon.Name = "Task_MinuteColon";
            this.Task_MinuteColon.Size = new System.Drawing.Size(28, 45);
            this.Task_MinuteColon.TabIndex = 149;
            this.Task_MinuteColon.Text = ":";
            // 
            // Task_Minute
            // 
            this.Task_Minute.AutoSize = true;
            this.Task_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Task_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Minute.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Task_Minute.Location = new System.Drawing.Point(145, 121);
            this.Task_Minute.Name = "Task_Minute";
            this.Task_Minute.Size = new System.Drawing.Size(56, 45);
            this.Task_Minute.TabIndex = 146;
            this.Task_Minute.Text = "00";
            // 
            // Task_HourColon
            // 
            this.Task_HourColon.AutoSize = true;
            this.Task_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Task_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Task_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Task_HourColon.Location = new System.Drawing.Point(133, 118);
            this.Task_HourColon.Name = "Task_HourColon";
            this.Task_HourColon.Size = new System.Drawing.Size(28, 45);
            this.Task_HourColon.TabIndex = 148;
            this.Task_HourColon.Text = ":";
            // 
            // Task_Hour
            // 
            this.Task_Hour.AutoSize = true;
            this.Task_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Task_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Task_Hour.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Task_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Task_Hour.Location = new System.Drawing.Point(94, 121);
            this.Task_Hour.Name = "Task_Hour";
            this.Task_Hour.Size = new System.Drawing.Size(56, 45);
            this.Task_Hour.TabIndex = 145;
            this.Task_Hour.Text = "00";
            // 
            // Global_Millisecond
            // 
            this.Global_Millisecond.AutoSize = true;
            this.Global_Millisecond.BackColor = System.Drawing.Color.Transparent;
            this.Global_Millisecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Millisecond.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Millisecond.ForeColor = System.Drawing.Color.Gray;
            this.Global_Millisecond.Location = new System.Drawing.Point(237, 67);
            this.Global_Millisecond.Name = "Global_Millisecond";
            this.Global_Millisecond.Size = new System.Drawing.Size(56, 45);
            this.Global_Millisecond.TabIndex = 144;
            this.Global_Millisecond.Text = "00";
            // 
            // Global_SecondPeriod
            // 
            this.Global_SecondPeriod.AutoSize = true;
            this.Global_SecondPeriod.BackColor = System.Drawing.Color.Transparent;
            this.Global_SecondPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_SecondPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_SecondPeriod.ForeColor = System.Drawing.Color.Gray;
            this.Global_SecondPeriod.Location = new System.Drawing.Point(225, 65);
            this.Global_SecondPeriod.Name = "Global_SecondPeriod";
            this.Global_SecondPeriod.Size = new System.Drawing.Size(28, 47);
            this.Global_SecondPeriod.TabIndex = 143;
            this.Global_SecondPeriod.Text = ".";
            // 
            // Global_Second
            // 
            this.Global_Second.AutoSize = true;
            this.Global_Second.BackColor = System.Drawing.Color.Transparent;
            this.Global_Second.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Second.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Second.ForeColor = System.Drawing.Color.Gray;
            this.Global_Second.Location = new System.Drawing.Point(167, 53);
            this.Global_Second.Name = "Global_Second";
            this.Global_Second.Size = new System.Drawing.Size(84, 65);
            this.Global_Second.TabIndex = 140;
            this.Global_Second.Text = "00";
            // 
            // Global_MinuteColon
            // 
            this.Global_MinuteColon.AutoSize = true;
            this.Global_MinuteColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_MinuteColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_MinuteColon.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_MinuteColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_MinuteColon.Location = new System.Drawing.Point(154, 49);
            this.Global_MinuteColon.Name = "Global_MinuteColon";
            this.Global_MinuteColon.Size = new System.Drawing.Size(40, 65);
            this.Global_MinuteColon.TabIndex = 142;
            this.Global_MinuteColon.Text = ":";
            // 
            // Global_Minute
            // 
            this.Global_Minute.AutoSize = true;
            this.Global_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Global_Minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Minute.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Minute.ForeColor = System.Drawing.Color.Gray;
            this.Global_Minute.Location = new System.Drawing.Point(97, 53);
            this.Global_Minute.Name = "Global_Minute";
            this.Global_Minute.Size = new System.Drawing.Size(84, 65);
            this.Global_Minute.TabIndex = 139;
            this.Global_Minute.Text = "00";
            // 
            // Global_HourColon
            // 
            this.Global_HourColon.AutoSize = true;
            this.Global_HourColon.BackColor = System.Drawing.Color.Transparent;
            this.Global_HourColon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_HourColon.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_HourColon.ForeColor = System.Drawing.Color.Gray;
            this.Global_HourColon.Location = new System.Drawing.Point(84, 49);
            this.Global_HourColon.Name = "Global_HourColon";
            this.Global_HourColon.Size = new System.Drawing.Size(40, 65);
            this.Global_HourColon.TabIndex = 141;
            this.Global_HourColon.Text = ":";
            // 
            // Global_Hour
            // 
            this.Global_Hour.AutoSize = true;
            this.Global_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Global_Hour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Global_Hour.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Global_Hour.ForeColor = System.Drawing.Color.Gray;
            this.Global_Hour.Location = new System.Drawing.Point(27, 53);
            this.Global_Hour.Name = "Global_Hour";
            this.Global_Hour.Size = new System.Drawing.Size(84, 65);
            this.Global_Hour.TabIndex = 138;
            this.Global_Hour.Text = "00";
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
            this.TopMenu.Size = new System.Drawing.Size(300, 24);
            this.TopMenu.TabIndex = 167;
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
            this.playgroundToolStripMenuItem,
            this.colorPickerToolStripMenuItem,
            this.commandToolStripMenuItem});
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
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messengerToolStripMenuItem.Text = "Messenger";
            this.messengerToolStripMenuItem.Click += new System.EventHandler(this.messengerToolStripMenuItem_Click);
            // 
            // applyThemeToolStripMenuItem
            // 
            this.applyThemeToolStripMenuItem.Name = "applyThemeToolStripMenuItem";
            this.applyThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applyThemeToolStripMenuItem.Text = "Apply Theme";
            this.applyThemeToolStripMenuItem.Click += new System.EventHandler(this.applyThemeToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // dataVisualizerToolStripMenuItem
            // 
            this.dataVisualizerToolStripMenuItem.Name = "dataVisualizerToolStripMenuItem";
            this.dataVisualizerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataVisualizerToolStripMenuItem.Text = "Data Visualizer";
            this.dataVisualizerToolStripMenuItem.Click += new System.EventHandler(this.dataVisualizerToolStripMenuItem_Click);
            // 
            // firstTimeSetupToolStripMenuItem
            // 
            this.firstTimeSetupToolStripMenuItem.Name = "firstTimeSetupToolStripMenuItem";
            this.firstTimeSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firstTimeSetupToolStripMenuItem.Text = "First Time Setup";
            this.firstTimeSetupToolStripMenuItem.Click += new System.EventHandler(this.firstTimeSetupToolStripMenuItem_Click);
            // 
            // playgroundToolStripMenuItem
            // 
            this.playgroundToolStripMenuItem.Name = "playgroundToolStripMenuItem";
            this.playgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playgroundToolStripMenuItem.Text = "Playground";
            this.playgroundToolStripMenuItem.Click += new System.EventHandler(this.playgroundToolStripMenuItem_Click);
            // 
            // colorPickerToolStripMenuItem
            // 
            this.colorPickerToolStripMenuItem.Name = "colorPickerToolStripMenuItem";
            this.colorPickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorPickerToolStripMenuItem.Text = "Color Picker";
            this.colorPickerToolStripMenuItem.Click += new System.EventHandler(this.colorPickerToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandToolStripMenuItem.Text = "Command";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // Global_Timer
            // 
            this.Global_Timer.Enabled = true;
            this.Global_Timer.Interval = 25;
            this.Global_Timer.Tick += new System.EventHandler(this.Global_Timer_Tick);
            // 
            // LACounty
            // 
            this.LACounty.Enabled = true;
            this.LACounty.Interval = 800000;
            this.LACounty.Tick += new System.EventHandler(this.LACounty_Tick);
            // 
            // JiraChecker
            // 
            this.JiraChecker.Interval = 30000;
            this.JiraChecker.Tick += new System.EventHandler(this.JiraChecker_Tick);
            // 
            // Animator
            // 
            this.Animator.Interval = 66;
            this.Animator.Tick += new System.EventHandler(this.Animator_Tick);
            // 
            // ThemedMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.IconI);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemedMain";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Issue Time Tracker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.ThemedMain_Load);
            this.LocationChanged += new System.EventHandler(this.Main_LocationChanged);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconI)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox IconI;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartPauseButton;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar DayProgress;
        private System.Windows.Forms.CheckBox APSCheckbox;
        private System.Windows.Forms.ComboBox IssueNumberCombo;
        private System.Windows.Forms.TextBox IssueNumber;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Label LastTaskLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveLeftOverButton;
        private System.Windows.Forms.Label LeftoverLabel;
        private System.Windows.Forms.ComboBox UseComboBox;
        private System.Windows.Forms.Label CurrentTaskLabel;
        private System.Windows.Forms.Label Task_Millisecond;
        private System.Windows.Forms.Label Task_SecondPeriod;
        private System.Windows.Forms.Label Task_Second;
        private System.Windows.Forms.Label Task_MinuteColon;
        private System.Windows.Forms.Label Task_Minute;
        private System.Windows.Forms.Label Task_HourColon;
        private System.Windows.Forms.Label Task_Hour;
        private System.Windows.Forms.Label Global_Millisecond;
        private System.Windows.Forms.Label Global_SecondPeriod;
        private System.Windows.Forms.Label Global_Second;
        private System.Windows.Forms.Label Global_MinuteColon;
        private System.Windows.Forms.Label Global_Minute;
        private System.Windows.Forms.Label Global_HourColon;
        private System.Windows.Forms.Label Global_Hour;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logBrowserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jiraBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearChromeCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enterCommandToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jiraDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataVisualizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstTimeSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playgroundToolStripMenuItem;
        private System.Windows.Forms.Timer Global_Timer;
        private System.Windows.Forms.Timer LACounty;
        public System.Windows.Forms.Timer JiraChecker;
        private System.Windows.Forms.ToolStripMenuItem colorPickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.Timer Animator;
    }
}