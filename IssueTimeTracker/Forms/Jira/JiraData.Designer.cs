namespace IssueTimeTracker.Forms.Jira
{
    partial class JiraData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraData));
            this.ticketList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxIssuesPerRequest = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.ListBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimeFormat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.toggleUpDown = new System.Windows.Forms.Button();
            this.rememberSettings = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveNameLabel = new System.Windows.Forms.Label();
            this.SaveName = new System.Windows.Forms.TextBox();
            this.savedQueries = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxIssuesPerRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketList
            // 
            this.ticketList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketList.FormattingEnabled = true;
            this.ticketList.Location = new System.Drawing.Point(12, 145);
            this.ticketList.Name = "ticketList";
            this.ticketList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ticketList.Size = new System.Drawing.Size(187, 210);
            this.ticketList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "JQL Query:";
            // 
            // JQL
            // 
            this.JQL.Location = new System.Drawing.Point(79, 33);
            this.JQL.Name = "JQL";
            this.JQL.Size = new System.Drawing.Size(356, 22);
            this.JQL.TabIndex = 3;
            this.JQL.Text = "project = CT AND reporter = currentUser()";
            this.JQL.TextChanged += new System.EventHandler(this.JQL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Issues Per Request:";
            // 
            // maxIssuesPerRequest
            // 
            this.maxIssuesPerRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxIssuesPerRequest.Location = new System.Drawing.Point(147, 89);
            this.maxIssuesPerRequest.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxIssuesPerRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIssuesPerRequest.Name = "maxIssuesPerRequest";
            this.maxIssuesPerRequest.Size = new System.Drawing.Size(52, 18);
            this.maxIssuesPerRequest.TabIndex = 5;
            this.maxIssuesPerRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxIssuesPerRequest.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(382, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "JQL Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data/Columns";
            // 
            // dataList
            // 
            this.dataList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataList.FormattingEnabled = true;
            this.dataList.Items.AddRange(new object[] {
            "Key",
            "Assignee",
            "Components",
            "Created",
            "Fix Versions",
            "Fix Versions Is Released",
            "Fix Versions Release Date",
            "Labels",
            "Priority",
            "Reporter",
            "Resolution",
            "Resolution Date",
            "Status",
            "Summary",
            "Updated"});
            this.dataList.Location = new System.Drawing.Point(220, 145);
            this.dataList.Name = "dataList";
            this.dataList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dataList.Size = new System.Drawing.Size(186, 210);
            this.dataList.TabIndex = 8;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(205, 86);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(147, 23);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(358, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(331, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Select All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(124, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Deselect All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimeFormat
            // 
            this.dateTimeFormat.Location = new System.Drawing.Point(114, 61);
            this.dateTimeFormat.Name = "dateTimeFormat";
            this.dateTimeFormat.Size = new System.Drawing.Size(132, 22);
            this.dateTimeFormat.TabIndex = 16;
            this.dateTimeFormat.Text = "MM/dd/yyyy hh:mm:ss tt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date/Time Format:";
            // 
            // up
            // 
            this.up.Enabled = false;
            this.up.FlatAppearance.BorderSize = 0;
            this.up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.up.Location = new System.Drawing.Point(412, 174);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(23, 23);
            this.up.TabIndex = 17;
            this.up.Text = "p";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Enabled = false;
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.down.Location = new System.Drawing.Point(412, 203);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(23, 23);
            this.down.TabIndex = 18;
            this.down.Text = "q";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // toggleUpDown
            // 
            this.toggleUpDown.FlatAppearance.BorderSize = 0;
            this.toggleUpDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.toggleUpDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toggleUpDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleUpDown.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toggleUpDown.Location = new System.Drawing.Point(412, 145);
            this.toggleUpDown.Name = "toggleUpDown";
            this.toggleUpDown.Size = new System.Drawing.Size(23, 23);
            this.toggleUpDown.TabIndex = 19;
            this.toggleUpDown.Text = "E";
            this.toggleUpDown.UseVisualStyleBackColor = true;
            this.toggleUpDown.Click += new System.EventHandler(this.toggleUpDown_Click);
            // 
            // rememberSettings
            // 
            this.rememberSettings.AutoSize = true;
            this.rememberSettings.Location = new System.Drawing.Point(220, 365);
            this.rememberSettings.Name = "rememberSettings";
            this.rememberSettings.Size = new System.Drawing.Size(125, 17);
            this.rememberSettings.TabIndex = 20;
            this.rememberSettings.Text = "Remember Settings";
            this.rememberSettings.UseVisualStyleBackColor = true;
            this.rememberSettings.CheckedChanged += new System.EventHandler(this.rememberSettings_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load Saved Query:";
            // 
            // SaveNameLabel
            // 
            this.SaveNameLabel.AutoSize = true;
            this.SaveNameLabel.Location = new System.Drawing.Point(12, 365);
            this.SaveNameLabel.Name = "SaveNameLabel";
            this.SaveNameLabel.Size = new System.Drawing.Size(39, 13);
            this.SaveNameLabel.TabIndex = 22;
            this.SaveNameLabel.Text = "Name:";
            this.SaveNameLabel.Visible = false;
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(57, 362);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(142, 22);
            this.SaveName.TabIndex = 23;
            this.SaveName.Visible = false;
            // 
            // savedQueries
            // 
            this.savedQueries.FormattingEnabled = true;
            this.savedQueries.Location = new System.Drawing.Point(114, 6);
            this.savedQueries.Name = "savedQueries";
            this.savedQueries.Size = new System.Drawing.Size(259, 21);
            this.savedQueries.TabIndex = 24;
            this.savedQueries.SelectedIndexChanged += new System.EventHandler(this.savedQueries_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(379, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 21);
            this.button5.TabIndex = 25;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // JiraData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 118);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.savedQueries);
            this.Controls.Add(this.SaveName);
            this.Controls.Add(this.SaveNameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rememberSettings);
            this.Controls.Add(this.toggleUpDown);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.dateTimeFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.maxIssuesPerRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JiraData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jira Data";
            this.Load += new System.EventHandler(this.JiraData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxIssuesPerRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ticketList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxIssuesPerRequest;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox dateTimeFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button toggleUpDown;
        private System.Windows.Forms.CheckBox rememberSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SaveNameLabel;
        private System.Windows.Forms.TextBox SaveName;
        private System.Windows.Forms.ComboBox savedQueries;
        private System.Windows.Forms.Button button5;
    }
}