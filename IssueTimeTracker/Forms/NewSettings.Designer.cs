namespace IssueTimeTracker.Forms
{
    partial class NewSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSettings));
            this.settingPages = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.updateFileButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Timer_YPos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Timer_XPos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.themeListView = new System.Windows.Forms.ListView();
            this.Timer_Opacity = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.Timer_Themes = new System.Windows.Forms.CheckBox();
            this.Timer_RoundUpMinutes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Timer_MaxRecentIssues = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.Jira = new System.Windows.Forms.TabPage();
            this.Jira_Mode = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Jira_AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Jira_Username = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Jira_Link = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Notification_Carrier = new System.Windows.Forms.ComboBox();
            this.Notification_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Notification_TextNotification = new System.Windows.Forms.CheckBox();
            this.Jira_WindowsNotification = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Notification_Scale = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Notification_SoundComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Notification_Frequency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Notification_DirectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Notification_CornerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Notification_ScreenComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataLogging = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Log_ExcelLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Log_ExportXlsx = new System.Windows.Forms.CheckBox();
            this.CloseWithoutSavingButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.themeList = new System.Windows.Forms.ImageList(this.components);
            this.Minimize = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.IconI = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jiraSLAGrid = new System.Windows.Forms.DataGridView();
            this.settingPages.SuspendLayout();
            this.General.SuspendLayout();
            this.Timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_RoundUpMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_MaxRecentIssues)).BeginInit();
            this.Jira.SuspendLayout();
            this.Notifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_Frequency)).BeginInit();
            this.DataLogging.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconI)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jiraSLAGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // settingPages
            // 
            this.settingPages.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.settingPages.Controls.Add(this.General);
            this.settingPages.Controls.Add(this.Timer);
            this.settingPages.Controls.Add(this.Jira);
            this.settingPages.Controls.Add(this.Notifications);
            this.settingPages.Controls.Add(this.DataLogging);
            this.settingPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingPages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.settingPages.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingPages.ItemSize = new System.Drawing.Size(25, 125);
            this.settingPages.Location = new System.Drawing.Point(0, 30);
            this.settingPages.Multiline = true;
            this.settingPages.Name = "settingPages";
            this.settingPages.Padding = new System.Drawing.Point(0, 0);
            this.settingPages.SelectedIndex = 0;
            this.settingPages.Size = new System.Drawing.Size(415, 293);
            this.settingPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.settingPages.TabIndex = 0;
            this.settingPages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.settingPages_DrawItem);
            // 
            // General
            // 
            this.General.Controls.Add(this.button10);
            this.General.Controls.Add(this.button8);
            this.General.Controls.Add(this.button7);
            this.General.Controls.Add(this.updateFileButton);
            this.General.Controls.Add(this.button6);
            this.General.Controls.Add(this.button4);
            this.General.Controls.Add(this.button3);
            this.General.Controls.Add(this.label13);
            this.General.Controls.Add(this.Timer_YPos);
            this.General.Controls.Add(this.label12);
            this.General.Controls.Add(this.Timer_XPos);
            this.General.Controls.Add(this.label11);
            this.General.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.General.Location = new System.Drawing.Point(129, 4);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(282, 285);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(6, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 30);
            this.button10.TabIndex = 165;
            this.button10.Text = "Open Data Location";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(153, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 30);
            this.button8.TabIndex = 164;
            this.button8.Text = "Restore Backup";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(153, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 30);
            this.button7.TabIndex = 163;
            this.button7.Text = "Create Backup";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // updateFileButton
            // 
            this.updateFileButton.FlatAppearance.BorderSize = 0;
            this.updateFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateFileButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFileButton.Location = new System.Drawing.Point(122, 179);
            this.updateFileButton.Name = "updateFileButton";
            this.updateFileButton.Size = new System.Drawing.Size(153, 30);
            this.updateFileButton.TabIndex = 162;
            this.updateFileButton.Text = "Generate New Update File";
            this.updateFileButton.UseVisualStyleBackColor = true;
            this.updateFileButton.Visible = false;
            this.updateFileButton.Click += new System.EventHandler(this.updateFileButton_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 30);
            this.button6.TabIndex = 161;
            this.button6.Text = "Check for Updates";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(234, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 20);
            this.button4.TabIndex = 160;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(97, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 20);
            this.button3.TabIndex = 159;
            this.button3.Text = "Set To Current Position";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(174, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 19);
            this.label13.TabIndex = 158;
            this.label13.Text = "Y:";
            // 
            // Timer_YPos
            // 
            this.Timer_YPos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_YPos.Location = new System.Drawing.Point(194, 5);
            this.Timer_YPos.Name = "Timer_YPos";
            this.Timer_YPos.ReadOnly = true;
            this.Timer_YPos.Size = new System.Drawing.Size(37, 22);
            this.Timer_YPos.TabIndex = 157;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(102, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 19);
            this.label12.TabIndex = 156;
            this.label12.Text = "X:";
            // 
            // Timer_XPos
            // 
            this.Timer_XPos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_XPos.Location = new System.Drawing.Point(122, 4);
            this.Timer_XPos.Name = "Timer_XPos";
            this.Timer_XPos.ReadOnly = true;
            this.Timer_XPos.Size = new System.Drawing.Size(37, 22);
            this.Timer_XPos.TabIndex = 155;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(5, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 154;
            this.label11.Text = "Start Position:";
            // 
            // Timer
            // 
            this.Timer.Controls.Add(this.button11);
            this.Timer.Controls.Add(this.themeListView);
            this.Timer.Controls.Add(this.Timer_Opacity);
            this.Timer.Controls.Add(this.label26);
            this.Timer.Controls.Add(this.Timer_Themes);
            this.Timer.Controls.Add(this.Timer_RoundUpMinutes);
            this.Timer.Controls.Add(this.label5);
            this.Timer.Controls.Add(this.label7);
            this.Timer.Controls.Add(this.Timer_MaxRecentIssues);
            this.Timer.Controls.Add(this.label22);
            this.Timer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Timer.Location = new System.Drawing.Point(129, 4);
            this.Timer.Name = "Timer";
            this.Timer.Padding = new System.Windows.Forms.Padding(3);
            this.Timer.Size = new System.Drawing.Size(282, 285);
            this.Timer.TabIndex = 1;
            this.Timer.Text = "Timer";
            this.Timer.UseVisualStyleBackColor = true;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(218, 84);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 24);
            this.button11.TabIndex = 131;
            this.button11.Text = "Get More";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // themeListView
            // 
            this.themeListView.Location = new System.Drawing.Point(11, 114);
            this.themeListView.Name = "themeListView";
            this.themeListView.Size = new System.Drawing.Size(264, 163);
            this.themeListView.TabIndex = 169;
            this.themeListView.UseCompatibleStateImageBehavior = false;
            this.themeListView.View = System.Windows.Forms.View.SmallIcon;
            this.themeListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.themeListView_ItemCheck);
            this.themeListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.themeListView_MouseUp);
            // 
            // Timer_Opacity
            // 
            this.Timer_Opacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timer_Opacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Timer_Opacity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Timer_Opacity.Location = new System.Drawing.Point(170, 57);
            this.Timer_Opacity.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.Timer_Opacity.Name = "Timer_Opacity";
            this.Timer_Opacity.Size = new System.Drawing.Size(44, 21);
            this.Timer_Opacity.TabIndex = 168;
            this.Timer_Opacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_Opacity.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label26.Location = new System.Drawing.Point(5, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 19);
            this.label26.TabIndex = 167;
            this.label26.Text = "Opacity:";
            // 
            // Timer_Themes
            // 
            this.Timer_Themes.AutoSize = true;
            this.Timer_Themes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Timer_Themes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Timer_Themes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Timer_Themes.Location = new System.Drawing.Point(0, 84);
            this.Timer_Themes.Name = "Timer_Themes";
            this.Timer_Themes.Size = new System.Drawing.Size(210, 24);
            this.Timer_Themes.TabIndex = 166;
            this.Timer_Themes.Text = "Enable Experimental Themes:";
            this.Timer_Themes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Timer_Themes.UseVisualStyleBackColor = true;
            this.Timer_Themes.CheckedChanged += new System.EventHandler(this.Timer_Themes_CheckedChanged);
            // 
            // Timer_RoundUpMinutes
            // 
            this.Timer_RoundUpMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timer_RoundUpMinutes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Timer_RoundUpMinutes.Location = new System.Drawing.Point(170, 30);
            this.Timer_RoundUpMinutes.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.Timer_RoundUpMinutes.Name = "Timer_RoundUpMinutes";
            this.Timer_RoundUpMinutes.Size = new System.Drawing.Size(44, 21);
            this.Timer_RoundUpMinutes.TabIndex = 164;
            this.Timer_RoundUpMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_RoundUpMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timer_RoundUpMinutes.ValueChanged += new System.EventHandler(this.Timer_RoundUpMinutes_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(5, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 163;
            this.label5.Text = "[Use] time round up after";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(214, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 165;
            this.label7.Text = "minute(s)";
            // 
            // Timer_MaxRecentIssues
            // 
            this.Timer_MaxRecentIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timer_MaxRecentIssues.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Timer_MaxRecentIssues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Timer_MaxRecentIssues.Location = new System.Drawing.Point(170, 5);
            this.Timer_MaxRecentIssues.Name = "Timer_MaxRecentIssues";
            this.Timer_MaxRecentIssues.Size = new System.Drawing.Size(44, 21);
            this.Timer_MaxRecentIssues.TabIndex = 160;
            this.Timer_MaxRecentIssues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_MaxRecentIssues.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Timer_MaxRecentIssues.ValueChanged += new System.EventHandler(this.Timer_MaxRecentIssues_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label22.Location = new System.Drawing.Point(5, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 19);
            this.label22.TabIndex = 159;
            this.label22.Text = "Max Recent Issues:";
            // 
            // Jira
            // 
            this.Jira.Controls.Add(this.groupBox1);
            this.Jira.Controls.Add(this.Jira_Mode);
            this.Jira.Controls.Add(this.label21);
            this.Jira.Controls.Add(this.button9);
            this.Jira.Controls.Add(this.button5);
            this.Jira.Controls.Add(this.Jira_AutoCheckBox);
            this.Jira.Controls.Add(this.label16);
            this.Jira.Controls.Add(this.Jira_Username);
            this.Jira.Controls.Add(this.label15);
            this.Jira.Controls.Add(this.Jira_Link);
            this.Jira.Controls.Add(this.label14);
            this.Jira.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Jira.Location = new System.Drawing.Point(129, 4);
            this.Jira.Name = "Jira";
            this.Jira.Size = new System.Drawing.Size(282, 285);
            this.Jira.TabIndex = 4;
            this.Jira.Text = "Jira";
            this.Jira.UseVisualStyleBackColor = true;
            // 
            // Jira_Mode
            // 
            this.Jira_Mode.FormattingEnabled = true;
            this.Jira_Mode.Items.AddRange(new object[] {
            "None",
            "In Application",
            "Web Browser"});
            this.Jira_Mode.Location = new System.Drawing.Point(160, 89);
            this.Jira_Mode.Name = "Jira_Mode";
            this.Jira_Mode.Size = new System.Drawing.Size(118, 23);
            this.Jira_Mode.TabIndex = 143;
            this.Jira_Mode.SelectedIndexChanged += new System.EventHandler(this.Jira_Mode_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label21.Location = new System.Drawing.Point(5, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 19);
            this.label21.TabIndex = 142;
            this.label21.Text = "Open Jira Ticket Mode:";
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(132, 253);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 29);
            this.button9.TabIndex = 141;
            this.button9.Text = "Clear Pin";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(208, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 29);
            this.button5.TabIndex = 140;
            this.button5.Text = "Login";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Jira_AutoCheckBox
            // 
            this.Jira_AutoCheckBox.AutoSize = true;
            this.Jira_AutoCheckBox.FlatAppearance.BorderSize = 0;
            this.Jira_AutoCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.Jira_AutoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jira_AutoCheckBox.Location = new System.Drawing.Point(167, 67);
            this.Jira_AutoCheckBox.Name = "Jira_AutoCheckBox";
            this.Jira_AutoCheckBox.Size = new System.Drawing.Size(12, 11);
            this.Jira_AutoCheckBox.TabIndex = 139;
            this.Jira_AutoCheckBox.UseVisualStyleBackColor = true;
            this.Jira_AutoCheckBox.CheckedChanged += new System.EventHandler(this.Jira_AutoCheckBox_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.Location = new System.Drawing.Point(5, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 19);
            this.label16.TabIndex = 138;
            this.label16.Text = "Check Jira for LAC issues:";
            // 
            // Jira_Username
            // 
            this.Jira_Username.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jira_Username.Location = new System.Drawing.Point(79, 33);
            this.Jira_Username.Name = "Jira_Username";
            this.Jira_Username.Size = new System.Drawing.Size(199, 22);
            this.Jira_Username.TabIndex = 137;
            this.Jira_Username.TextChanged += new System.EventHandler(this.Jira_Username_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(5, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 136;
            this.label15.Text = "Username:";
            // 
            // Jira_Link
            // 
            this.Jira_Link.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jira_Link.Location = new System.Drawing.Point(48, 5);
            this.Jira_Link.Name = "Jira_Link";
            this.Jira_Link.Size = new System.Drawing.Size(230, 22);
            this.Jira_Link.TabIndex = 135;
            this.Jira_Link.TextChanged += new System.EventHandler(this.Jira_Link_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(5, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 19);
            this.label14.TabIndex = 134;
            this.label14.Text = "Link:";
            // 
            // Notifications
            // 
            this.Notifications.Controls.Add(this.button12);
            this.Notifications.Controls.Add(this.label6);
            this.Notifications.Controls.Add(this.Notification_Carrier);
            this.Notifications.Controls.Add(this.Notification_PhoneNumber);
            this.Notifications.Controls.Add(this.label17);
            this.Notifications.Controls.Add(this.Notification_TextNotification);
            this.Notifications.Controls.Add(this.Jira_WindowsNotification);
            this.Notifications.Controls.Add(this.label25);
            this.Notifications.Controls.Add(this.Notification_Scale);
            this.Notifications.Controls.Add(this.label20);
            this.Notifications.Controls.Add(this.label19);
            this.Notifications.Controls.Add(this.button2);
            this.Notifications.Controls.Add(this.Notification_SoundComboBox);
            this.Notifications.Controls.Add(this.label10);
            this.Notifications.Controls.Add(this.Notification_Frequency);
            this.Notifications.Controls.Add(this.label4);
            this.Notifications.Controls.Add(this.Notification_DirectionComboBox);
            this.Notifications.Controls.Add(this.label3);
            this.Notifications.Controls.Add(this.Notification_CornerComboBox);
            this.Notifications.Controls.Add(this.label2);
            this.Notifications.Controls.Add(this.Notification_ScreenComboBox);
            this.Notifications.Controls.Add(this.label1);
            this.Notifications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notifications.Location = new System.Drawing.Point(129, 4);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(282, 285);
            this.Notifications.TabIndex = 2;
            this.Notifications.Text = "Notifications";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(216, 230);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 19);
            this.button12.TabIndex = 169;
            this.button12.Text = "Test";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 168;
            this.label6.Text = "Carrier:";
            // 
            // Notification_Carrier
            // 
            this.Notification_Carrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_Carrier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification_Carrier.FormattingEnabled = true;
            this.Notification_Carrier.Location = new System.Drawing.Point(109, 256);
            this.Notification_Carrier.Name = "Notification_Carrier";
            this.Notification_Carrier.Size = new System.Drawing.Size(157, 25);
            this.Notification_Carrier.TabIndex = 167;
            this.Notification_Carrier.SelectedIndexChanged += new System.EventHandler(this.Notification_Carrier_SelectedIndexChanged);
            // 
            // Notification_PhoneNumber
            // 
            this.Notification_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notification_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Notification_PhoneNumber.Location = new System.Drawing.Point(109, 230);
            this.Notification_PhoneNumber.MaxLength = 10;
            this.Notification_PhoneNumber.Name = "Notification_PhoneNumber";
            this.Notification_PhoneNumber.Size = new System.Drawing.Size(101, 19);
            this.Notification_PhoneNumber.TabIndex = 166;
            this.Notification_PhoneNumber.Text = "8888888888";
            this.Notification_PhoneNumber.TextChanged += new System.EventHandler(this.Notification_PhoneNumber_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 165;
            this.label17.Text = "Phone Number:";
            // 
            // Notification_TextNotification
            // 
            this.Notification_TextNotification.AutoSize = true;
            this.Notification_TextNotification.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Notification_TextNotification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Notification_TextNotification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Notification_TextNotification.Location = new System.Drawing.Point(7, 201);
            this.Notification_TextNotification.Name = "Notification_TextNotification";
            this.Notification_TextNotification.Size = new System.Drawing.Size(259, 24);
            this.Notification_TextNotification.TabIndex = 164;
            this.Notification_TextNotification.Text = "Send Text While Computer is Locked:";
            this.Notification_TextNotification.UseVisualStyleBackColor = true;
            this.Notification_TextNotification.CheckedChanged += new System.EventHandler(this.Notification_TextNotification_CheckedChanged);
            // 
            // Jira_WindowsNotification
            // 
            this.Jira_WindowsNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jira_WindowsNotification.FormattingEnabled = true;
            this.Jira_WindowsNotification.Items.AddRange(new object[] {
            "Legacy",
            "Windows"});
            this.Jira_WindowsNotification.Location = new System.Drawing.Point(89, 12);
            this.Jira_WindowsNotification.Name = "Jira_WindowsNotification";
            this.Jira_WindowsNotification.Size = new System.Drawing.Size(102, 23);
            this.Jira_WindowsNotification.TabIndex = 163;
            this.Jira_WindowsNotification.Text = "Type";
            this.Jira_WindowsNotification.SelectedIndexChanged += new System.EventHandler(this.Jira_WindowsNotification_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label25.Location = new System.Drawing.Point(3, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 19);
            this.label25.TabIndex = 162;
            this.label25.Text = "Notification:";
            // 
            // Notification_Scale
            // 
            this.Notification_Scale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notification_Scale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Notification_Scale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Notification_Scale.Location = new System.Drawing.Point(135, 178);
            this.Notification_Scale.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Notification_Scale.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Notification_Scale.Name = "Notification_Scale";
            this.Notification_Scale.Size = new System.Drawing.Size(56, 21);
            this.Notification_Scale.TabIndex = 158;
            this.Notification_Scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Notification_Scale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Notification_Scale.ValueChanged += new System.EventHandler(this.Notification_Scale_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label20.Location = new System.Drawing.Point(190, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 19);
            this.label20.TabIndex = 159;
            this.label20.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label19.Location = new System.Drawing.Point(3, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 19);
            this.label19.TabIndex = 157;
            this.label19.Text = "Scale:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 20);
            this.button2.TabIndex = 152;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Notification_SoundComboBox
            // 
            this.Notification_SoundComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_SoundComboBox.FormattingEnabled = true;
            this.Notification_SoundComboBox.Location = new System.Drawing.Point(70, 122);
            this.Notification_SoundComboBox.Name = "Notification_SoundComboBox";
            this.Notification_SoundComboBox.Size = new System.Drawing.Size(121, 23);
            this.Notification_SoundComboBox.TabIndex = 151;
            this.Notification_SoundComboBox.SelectedIndexChanged += new System.EventHandler(this.Notification_SoundComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(3, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 150;
            this.label10.Text = "Sound:";
            // 
            // Notification_Frequency
            // 
            this.Notification_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notification_Frequency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Notification_Frequency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Notification_Frequency.Location = new System.Drawing.Point(135, 150);
            this.Notification_Frequency.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Notification_Frequency.Name = "Notification_Frequency";
            this.Notification_Frequency.Size = new System.Drawing.Size(56, 21);
            this.Notification_Frequency.TabIndex = 149;
            this.Notification_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Notification_Frequency.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.Notification_Frequency.ValueChanged += new System.EventHandler(this.Notification_Frequency_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 148;
            this.label4.Text = "Frequency (minutes):";
            // 
            // Notification_DirectionComboBox
            // 
            this.Notification_DirectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_DirectionComboBox.FormattingEnabled = true;
            this.Notification_DirectionComboBox.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.Notification_DirectionComboBox.Location = new System.Drawing.Point(70, 95);
            this.Notification_DirectionComboBox.Name = "Notification_DirectionComboBox";
            this.Notification_DirectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.Notification_DirectionComboBox.TabIndex = 147;
            this.Notification_DirectionComboBox.SelectedIndexChanged += new System.EventHandler(this.Notification_DirectionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 146;
            this.label3.Text = "Direction:";
            // 
            // Notification_CornerComboBox
            // 
            this.Notification_CornerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_CornerComboBox.FormattingEnabled = true;
            this.Notification_CornerComboBox.Items.AddRange(new object[] {
            "Top Left",
            "Top Right",
            "Bottom Right",
            "Bottom Left"});
            this.Notification_CornerComboBox.Location = new System.Drawing.Point(70, 68);
            this.Notification_CornerComboBox.Name = "Notification_CornerComboBox";
            this.Notification_CornerComboBox.Size = new System.Drawing.Size(121, 23);
            this.Notification_CornerComboBox.TabIndex = 145;
            this.Notification_CornerComboBox.SelectedIndexChanged += new System.EventHandler(this.Notification_CornerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 144;
            this.label2.Text = "Corner:";
            // 
            // Notification_ScreenComboBox
            // 
            this.Notification_ScreenComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_ScreenComboBox.FormattingEnabled = true;
            this.Notification_ScreenComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Notification_ScreenComboBox.Location = new System.Drawing.Point(70, 41);
            this.Notification_ScreenComboBox.Name = "Notification_ScreenComboBox";
            this.Notification_ScreenComboBox.Size = new System.Drawing.Size(121, 23);
            this.Notification_ScreenComboBox.TabIndex = 143;
            this.Notification_ScreenComboBox.SelectedIndexChanged += new System.EventHandler(this.Notification_ScreenComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 142;
            this.label1.Text = "Screen:";
            // 
            // DataLogging
            // 
            this.DataLogging.Controls.Add(this.button1);
            this.DataLogging.Controls.Add(this.Log_ExcelLocation);
            this.DataLogging.Controls.Add(this.label9);
            this.DataLogging.Controls.Add(this.label8);
            this.DataLogging.Controls.Add(this.Log_ExportXlsx);
            this.DataLogging.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataLogging.Location = new System.Drawing.Point(129, 4);
            this.DataLogging.Name = "DataLogging";
            this.DataLogging.Size = new System.Drawing.Size(282, 285);
            this.DataLogging.TabIndex = 3;
            this.DataLogging.Text = "Data Logging";
            this.DataLogging.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(255, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log_ExcelLocation
            // 
            this.Log_ExcelLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_ExcelLocation.Location = new System.Drawing.Point(70, 33);
            this.Log_ExcelLocation.Name = "Log_ExcelLocation";
            this.Log_ExcelLocation.Size = new System.Drawing.Size(184, 22);
            this.Log_ExcelLocation.TabIndex = 9;
            this.Log_ExcelLocation.TextChanged += new System.EventHandler(this.Log_ExcelLocation_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(5, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Export Excel File:";
            // 
            // Log_ExportXlsx
            // 
            this.Log_ExportXlsx.AutoSize = true;
            this.Log_ExportXlsx.Location = new System.Drawing.Point(116, 9);
            this.Log_ExportXlsx.Name = "Log_ExportXlsx";
            this.Log_ExportXlsx.Size = new System.Drawing.Size(15, 14);
            this.Log_ExportXlsx.TabIndex = 6;
            this.Log_ExportXlsx.UseVisualStyleBackColor = true;
            this.Log_ExportXlsx.CheckedChanged += new System.EventHandler(this.Log_ExportXlsx_CheckedChanged);
            // 
            // CloseWithoutSavingButton
            // 
            this.CloseWithoutSavingButton.FlatAppearance.BorderSize = 0;
            this.CloseWithoutSavingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CloseWithoutSavingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseWithoutSavingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWithoutSavingButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWithoutSavingButton.Location = new System.Drawing.Point(-3, 290);
            this.CloseWithoutSavingButton.Name = "CloseWithoutSavingButton";
            this.CloseWithoutSavingButton.Size = new System.Drawing.Size(130, 31);
            this.CloseWithoutSavingButton.TabIndex = 128;
            this.CloseWithoutSavingButton.Text = "Close Without Saving";
            this.CloseWithoutSavingButton.UseVisualStyleBackColor = true;
            this.CloseWithoutSavingButton.Click += new System.EventHandler(this.CloseWithoutSavingButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.FlatAppearance.BorderSize = 0;
            this.SaveAndCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveAndCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(0, 259);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(127, 31);
            this.SaveAndCloseButton.TabIndex = 129;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(0, 228);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 31);
            this.SaveButton.TabIndex = 130;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // themeList
            // 
            this.themeList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.themeList.ImageSize = new System.Drawing.Size(16, 16);
            this.themeList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(330, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 30);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(373, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Tag = "NoTheme";
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.ExitButton);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(414, 30);
            this.TitleBar.TabIndex = 131;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(66, 21);
            this.Title.TabIndex = 1;
            this.Title.Text = "Settings";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // IconI
            // 
            this.IconI.ErrorImage = ((System.Drawing.Image)(resources.GetObject("IconI.ErrorImage")));
            this.IconI.Image = ((System.Drawing.Image)(resources.GetObject("IconI.Image")));
            this.IconI.InitialImage = ((System.Drawing.Image)(resources.GetObject("IconI.InitialImage")));
            this.IconI.Location = new System.Drawing.Point(7, 7);
            this.IconI.Name = "IconI";
            this.IconI.Size = new System.Drawing.Size(16, 16);
            this.IconI.TabIndex = 132;
            this.IconI.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 75);
            this.panel1.TabIndex = 133;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jiraSLAGrid);
            this.groupBox1.Location = new System.Drawing.Point(9, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 123);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jira SLAs";
            // 
            // jiraSLAGrid
            // 
            this.jiraSLAGrid.BackgroundColor = System.Drawing.Color.White;
            this.jiraSLAGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jiraSLAGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jiraSLAGrid.GridColor = System.Drawing.Color.White;
            this.jiraSLAGrid.Location = new System.Drawing.Point(6, 22);
            this.jiraSLAGrid.Name = "jiraSLAGrid";
            this.jiraSLAGrid.Size = new System.Drawing.Size(257, 95);
            this.jiraSLAGrid.TabIndex = 1;
            // 
            // NewSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 323);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.IconI);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.CloseWithoutSavingButton);
            this.Controls.Add(this.settingPages);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSettings_FormClosing);
            this.Load += new System.EventHandler(this.NewSettings_Load);
            this.settingPages.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Timer.ResumeLayout(false);
            this.Timer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_RoundUpMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_MaxRecentIssues)).EndInit();
            this.Jira.ResumeLayout(false);
            this.Jira.PerformLayout();
            this.Notifications.ResumeLayout(false);
            this.Notifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_Frequency)).EndInit();
            this.DataLogging.ResumeLayout(false);
            this.DataLogging.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jiraSLAGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingPages;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Timer;
        private System.Windows.Forms.TabPage Jira;
        private System.Windows.Forms.TabPage Notifications;
        private System.Windows.Forms.TabPage DataLogging;
        private System.Windows.Forms.NumericUpDown Notification_Scale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Notification_SoundComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Notification_Frequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Notification_DirectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Notification_CornerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Notification_ScreenComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Log_ExcelLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Log_ExportXlsx;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox Jira_AutoCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Jira_Username;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Jira_Link;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Timer_YPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Timer_XPos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Timer_MaxRecentIssues;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button updateFileButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button CloseWithoutSavingButton;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown Timer_RoundUpMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox Jira_Mode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Jira_WindowsNotification;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox Timer_Themes;
        private System.Windows.Forms.NumericUpDown Timer_Opacity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListView themeListView;
        private System.Windows.Forms.ImageList themeList;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox IconI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Notification_Carrier;
        private System.Windows.Forms.TextBox Notification_PhoneNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox Notification_TextNotification;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView jiraSLAGrid;
    }
}