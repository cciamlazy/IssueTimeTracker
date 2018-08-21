namespace IssueTimeTracker.Forms
{
    partial class JiraIssueBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraIssueBrowser));
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.AttachmentsPanel = new System.Windows.Forms.Panel();
            this.dropLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.CommentsText = new System.Windows.Forms.RichTextBox();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.RespondButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.KeyLink = new System.Windows.Forms.LinkLabel();
            this.CommentsSeperator = new System.Windows.Forms.Panel();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Reporter = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ResolveButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.RespondText = new System.Windows.Forms.TextBox();
            this.Assignee = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RespondSeperator = new System.Windows.Forms.Panel();
            this.RespondLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Resolution = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.JiraLocation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IssueID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerPhoneNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AllOpenButton = new System.Windows.Forms.Button();
            this.AllOpenNumber = new System.Windows.Forms.Label();
            this.UnassignedNumber = new System.Windows.Forms.Label();
            this.UnassignedButton = new System.Windows.Forms.Button();
            this.AssignedNumber = new System.Windows.Forms.Label();
            this.AssignedButton = new System.Windows.Forms.Button();
            this.WaitingNumber = new System.Windows.Forms.Label();
            this.WaitingButton = new System.Windows.Forms.Button();
            this.RecentNumber = new System.Windows.Forms.Label();
            this.RecentButton = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.Panel();
            this.IssueListPanel = new System.Windows.Forms.Panel();
            this.NoIssuesLabel = new System.Windows.Forms.Label();
            this.IssuesList = new System.Windows.Forms.ListView();
            this.listKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listReporter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueueLabel = new System.Windows.Forms.Label();
            this.MessageBuilderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.JiraNamesButton = new System.Windows.Forms.Button();
            this.TicketPanel.SuspendLayout();
            this.AttachmentsPanel.SuspendLayout();
            this.IssueListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketPanel
            // 
            this.TicketPanel.AutoScroll = true;
            this.TicketPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TicketPanel.Controls.Add(this.AttachmentsPanel);
            this.TicketPanel.Controls.Add(this.CommentsText);
            this.TicketPanel.Controls.Add(this.Priority);
            this.TicketPanel.Controls.Add(this.RespondButton);
            this.TicketPanel.Controls.Add(this.label17);
            this.TicketPanel.Controls.Add(this.linkLabel1);
            this.TicketPanel.Controls.Add(this.KeyLink);
            this.TicketPanel.Controls.Add(this.CommentsSeperator);
            this.TicketPanel.Controls.Add(this.CommentsLabel);
            this.TicketPanel.Controls.Add(this.CreatedDate);
            this.TicketPanel.Controls.Add(this.label16);
            this.TicketPanel.Controls.Add(this.Reporter);
            this.TicketPanel.Controls.Add(this.label14);
            this.TicketPanel.Controls.Add(this.Title);
            this.TicketPanel.Controls.Add(this.ResolveButton);
            this.TicketPanel.Controls.Add(this.AssignButton);
            this.TicketPanel.Controls.Add(this.RespondText);
            this.TicketPanel.Controls.Add(this.Assignee);
            this.TicketPanel.Controls.Add(this.label13);
            this.TicketPanel.Controls.Add(this.RespondSeperator);
            this.TicketPanel.Controls.Add(this.RespondLabel);
            this.TicketPanel.Controls.Add(this.Description);
            this.TicketPanel.Controls.Add(this.panel2);
            this.TicketPanel.Controls.Add(this.label2);
            this.TicketPanel.Controls.Add(this.Resolution);
            this.TicketPanel.Controls.Add(this.label6);
            this.TicketPanel.Controls.Add(this.Status);
            this.TicketPanel.Controls.Add(this.label4);
            this.TicketPanel.Controls.Add(this.panel4);
            this.TicketPanel.Controls.Add(this.label12);
            this.TicketPanel.Controls.Add(this.JiraLocation);
            this.TicketPanel.Controls.Add(this.label9);
            this.TicketPanel.Controls.Add(this.IssueID);
            this.TicketPanel.Controls.Add(this.label7);
            this.TicketPanel.Controls.Add(this.CustomerPhoneNumber);
            this.TicketPanel.Controls.Add(this.label5);
            this.TicketPanel.Controls.Add(this.label3);
            this.TicketPanel.Controls.Add(this.Type);
            this.TicketPanel.Controls.Add(this.label1);
            this.TicketPanel.Location = new System.Drawing.Point(176, 0);
            this.TicketPanel.Name = "TicketPanel";
            this.TicketPanel.Size = new System.Drawing.Size(647, 1012);
            this.TicketPanel.TabIndex = 0;
            this.TicketPanel.SizeChanged += new System.EventHandler(this.TicketPanel_SizeChanged);
            // 
            // AttachmentsPanel
            // 
            this.AttachmentsPanel.AllowDrop = true;
            this.AttachmentsPanel.AutoScroll = true;
            this.AttachmentsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttachmentsPanel.BackColor = System.Drawing.Color.White;
            this.AttachmentsPanel.Controls.Add(this.dropLabel);
            this.AttachmentsPanel.Controls.Add(this.panel5);
            this.AttachmentsPanel.Controls.Add(this.label15);
            this.AttachmentsPanel.Location = new System.Drawing.Point(0, 592);
            this.AttachmentsPanel.Name = "AttachmentsPanel";
            this.AttachmentsPanel.Size = new System.Drawing.Size(539, 160);
            this.AttachmentsPanel.TabIndex = 175;
            this.AttachmentsPanel.SizeChanged += new System.EventHandler(this.AttachmentsPanel_SizeChanged);
            this.AttachmentsPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.AttachmentsPanel_DragDropAsync);
            this.AttachmentsPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.AttachmentsPanel_DragEnter);
            this.AttachmentsPanel.DragLeave += new System.EventHandler(this.AttachmentsPanel_DragLeave);
            // 
            // dropLabel
            // 
            this.dropLabel.AutoSize = true;
            this.dropLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropLabel.Location = new System.Drawing.Point(185, 81);
            this.dropLabel.Name = "dropLabel";
            this.dropLabel.Size = new System.Drawing.Size(172, 13);
            this.dropLabel.TabIndex = 170;
            this.dropLabel.Text = "Drop To Attach Item(s) To Ticket";
            this.dropLabel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(87, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 1);
            this.panel5.TabIndex = 169;
            this.panel5.Tag = "Foreground";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 168;
            this.label15.Text = "Attachments";
            // 
            // CommentsText
            // 
            this.CommentsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentsText.Location = new System.Drawing.Point(14, 410);
            this.CommentsText.Name = "CommentsText";
            this.CommentsText.ReadOnly = true;
            this.CommentsText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CommentsText.Size = new System.Drawing.Size(525, 175);
            this.CommentsText.TabIndex = 174;
            this.CommentsText.Text = "";
            this.CommentsText.Visible = false;
            // 
            // Priority
            // 
            this.Priority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Priority.FormattingEnabled = true;
            this.Priority.Items.AddRange(new object[] {
            "Highest",
            "High",
            "Medium",
            "Low",
            "Lowest"});
            this.Priority.Location = new System.Drawing.Point(152, 98);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(65, 21);
            this.Priority.TabIndex = 173;
            this.Priority.Text = "N/A";
            this.Priority.SelectedIndexChanged += new System.EventHandler(this.Priority_SelectedIndexChangedAsync);
            // 
            // RespondButton
            // 
            this.RespondButton.FlatAppearance.BorderSize = 0;
            this.RespondButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.RespondButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RespondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RespondButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespondButton.Location = new System.Drawing.Point(391, 954);
            this.RespondButton.Name = "RespondButton";
            this.RespondButton.Size = new System.Drawing.Size(148, 27);
            this.RespondButton.TabIndex = 172;
            this.RespondButton.Text = "Respond to customer";
            this.RespondButton.UseVisualStyleBackColor = true;
            this.RespondButton.Visible = false;
            this.RespondButton.Click += new System.EventHandler(this.RespondButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 171;
            this.label17.Text = "/";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 170;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LA County";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // KeyLink
            // 
            this.KeyLink.AutoSize = true;
            this.KeyLink.Location = new System.Drawing.Point(74, 11);
            this.KeyLink.Name = "KeyLink";
            this.KeyLink.Size = new System.Drawing.Size(30, 13);
            this.KeyLink.TabIndex = 169;
            this.KeyLink.TabStop = true;
            this.KeyLink.Text = "LAC-";
            this.KeyLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.KeyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KeyLink_LinkClicked);
            // 
            // CommentsSeperator
            // 
            this.CommentsSeperator.BackColor = System.Drawing.Color.DarkGray;
            this.CommentsSeperator.Location = new System.Drawing.Point(77, 400);
            this.CommentsSeperator.Name = "CommentsSeperator";
            this.CommentsSeperator.Size = new System.Drawing.Size(462, 1);
            this.CommentsSeperator.TabIndex = 167;
            this.CommentsSeperator.Tag = "Foreground";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.Location = new System.Drawing.Point(3, 391);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(67, 15);
            this.CommentsLabel.TabIndex = 166;
            this.CommentsLabel.Text = "Comments";
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSize = true;
            this.CreatedDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedDate.Location = new System.Drawing.Point(450, 172);
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Size = new System.Drawing.Size(26, 13);
            this.CreatedDate.TabIndex = 164;
            this.CreatedDate.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(376, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 163;
            this.label16.Tag = "OtherForeground";
            this.label16.Text = "Created:";
            // 
            // Reporter
            // 
            this.Reporter.AutoSize = true;
            this.Reporter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporter.Location = new System.Drawing.Point(450, 149);
            this.Reporter.Name = "Reporter";
            this.Reporter.Size = new System.Drawing.Size(26, 13);
            this.Reporter.TabIndex = 162;
            this.Reporter.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(376, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 161;
            this.label14.Tag = "OtherForeground";
            this.label14.Text = "Reporter:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(138, 21);
            this.Title.TabIndex = 160;
            this.Title.Text = "LA County / LAC-";
            // 
            // ResolveButton
            // 
            this.ResolveButton.FlatAppearance.BorderSize = 0;
            this.ResolveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.ResolveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ResolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResolveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolveButton.Location = new System.Drawing.Point(256, 954);
            this.ResolveButton.Name = "ResolveButton";
            this.ResolveButton.Size = new System.Drawing.Size(129, 27);
            this.ResolveButton.TabIndex = 159;
            this.ResolveButton.Text = "Resolve this issue";
            this.ResolveButton.UseVisualStyleBackColor = true;
            this.ResolveButton.Visible = false;
            // 
            // AssignButton
            // 
            this.AssignButton.FlatAppearance.BorderSize = 0;
            this.AssignButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.AssignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignButton.Location = new System.Drawing.Point(195, 954);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(57, 27);
            this.AssignButton.TabIndex = 158;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // RespondText
            // 
            this.RespondText.BackColor = System.Drawing.Color.White;
            this.RespondText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RespondText.Location = new System.Drawing.Point(14, 773);
            this.RespondText.Multiline = true;
            this.RespondText.Name = "RespondText";
            this.RespondText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RespondText.Size = new System.Drawing.Size(525, 175);
            this.RespondText.TabIndex = 157;
            this.RespondText.TextChanged += new System.EventHandler(this.RespondText_TextChanged);
            this.RespondText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RespondText_KeyDown);
            // 
            // Assignee
            // 
            this.Assignee.AutoSize = true;
            this.Assignee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignee.Location = new System.Drawing.Point(450, 125);
            this.Assignee.Name = "Assignee";
            this.Assignee.Size = new System.Drawing.Size(26, 13);
            this.Assignee.TabIndex = 156;
            this.Assignee.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(376, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 155;
            this.label13.Tag = "OtherForeground";
            this.label13.Text = "Assignee:";
            // 
            // RespondSeperator
            // 
            this.RespondSeperator.BackColor = System.Drawing.Color.DarkGray;
            this.RespondSeperator.Location = new System.Drawing.Point(60, 764);
            this.RespondSeperator.Name = "RespondSeperator";
            this.RespondSeperator.Size = new System.Drawing.Size(479, 1);
            this.RespondSeperator.TabIndex = 152;
            // 
            // RespondLabel
            // 
            this.RespondLabel.AutoSize = true;
            this.RespondLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespondLabel.Location = new System.Drawing.Point(3, 755);
            this.RespondLabel.Name = "RespondLabel";
            this.RespondLabel.Size = new System.Drawing.Size(55, 15);
            this.RespondLabel.TabIndex = 151;
            this.RespondLabel.Text = "Respond";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(14, 215);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(525, 175);
            this.Description.TabIndex = 154;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(77, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 1);
            this.panel2.TabIndex = 148;
            this.panel2.Tag = "Foreground";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 146;
            this.label2.Text = "Description";
            // 
            // Resolution
            // 
            this.Resolution.AutoSize = true;
            this.Resolution.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolution.Location = new System.Drawing.Point(450, 101);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(26, 13);
            this.Resolution.TabIndex = 153;
            this.Resolution.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(376, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 150;
            this.label6.Tag = "OtherForeground";
            this.label6.Text = "Resolution:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(450, 78);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(26, 13);
            this.Status.TabIndex = 149;
            this.Status.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(376, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 147;
            this.label4.Tag = "OtherForeground";
            this.label4.Text = "Status:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(52, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 1);
            this.panel4.TabIndex = 145;
            this.panel4.Tag = "Foreground";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 144;
            this.label12.Text = "Details";
            // 
            // JiraLocation
            // 
            this.JiraLocation.AutoSize = true;
            this.JiraLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JiraLocation.Location = new System.Drawing.Point(152, 172);
            this.JiraLocation.Name = "JiraLocation";
            this.JiraLocation.Size = new System.Drawing.Size(26, 13);
            this.JiraLocation.TabIndex = 141;
            this.JiraLocation.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(11, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 140;
            this.label9.Tag = "OtherForeground";
            this.label9.Text = "Customer Location:";
            // 
            // IssueID
            // 
            this.IssueID.AutoSize = true;
            this.IssueID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueID.Location = new System.Drawing.Point(152, 149);
            this.IssueID.Name = "IssueID";
            this.IssueID.Size = new System.Drawing.Size(26, 13);
            this.IssueID.TabIndex = 139;
            this.IssueID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(11, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 138;
            this.label7.Tag = "OtherForeground";
            this.label7.Text = "ClientTrack Issue ID:";
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.AutoSize = true;
            this.CustomerPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumber.Location = new System.Drawing.Point(152, 125);
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            this.CustomerPhoneNumber.Size = new System.Drawing.Size(26, 13);
            this.CustomerPhoneNumber.TabIndex = 137;
            this.CustomerPhoneNumber.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 136;
            this.label5.Tag = "OtherForeground";
            this.label5.Text = "Customer Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 134;
            this.label3.Tag = "OtherForeground";
            this.label3.Text = "Priority:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(152, 78);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(26, 13);
            this.Type.TabIndex = 133;
            this.Type.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 132;
            this.label1.Tag = "OtherForeground";
            this.label1.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label10.Location = new System.Drawing.Point(12, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "QUEUES";
            // 
            // AllOpenButton
            // 
            this.AllOpenButton.FlatAppearance.BorderSize = 0;
            this.AllOpenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.AllOpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AllOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllOpenButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOpenButton.Location = new System.Drawing.Point(15, 32);
            this.AllOpenButton.Name = "AllOpenButton";
            this.AllOpenButton.Size = new System.Drawing.Size(124, 23);
            this.AllOpenButton.TabIndex = 2;
            this.AllOpenButton.Text = "All open";
            this.AllOpenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllOpenButton.UseVisualStyleBackColor = true;
            this.AllOpenButton.Click += new System.EventHandler(this.AllOpenButton_ClickAsync);
            // 
            // AllOpenNumber
            // 
            this.AllOpenNumber.AutoSize = true;
            this.AllOpenNumber.BackColor = System.Drawing.Color.Transparent;
            this.AllOpenNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOpenNumber.Location = new System.Drawing.Point(148, 37);
            this.AllOpenNumber.Name = "AllOpenNumber";
            this.AllOpenNumber.Size = new System.Drawing.Size(13, 13);
            this.AllOpenNumber.TabIndex = 3;
            this.AllOpenNumber.Text = "0";
            // 
            // UnassignedNumber
            // 
            this.UnassignedNumber.AutoSize = true;
            this.UnassignedNumber.BackColor = System.Drawing.Color.Transparent;
            this.UnassignedNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignedNumber.Location = new System.Drawing.Point(148, 63);
            this.UnassignedNumber.Name = "UnassignedNumber";
            this.UnassignedNumber.Size = new System.Drawing.Size(13, 13);
            this.UnassignedNumber.TabIndex = 5;
            this.UnassignedNumber.Text = "0";
            // 
            // UnassignedButton
            // 
            this.UnassignedButton.FlatAppearance.BorderSize = 0;
            this.UnassignedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.UnassignedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UnassignedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnassignedButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignedButton.Location = new System.Drawing.Point(15, 58);
            this.UnassignedButton.Name = "UnassignedButton";
            this.UnassignedButton.Size = new System.Drawing.Size(124, 23);
            this.UnassignedButton.TabIndex = 4;
            this.UnassignedButton.Text = "Unassigned issues";
            this.UnassignedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UnassignedButton.UseVisualStyleBackColor = true;
            this.UnassignedButton.Click += new System.EventHandler(this.UnassignedButton_ClickAsync);
            // 
            // AssignedNumber
            // 
            this.AssignedNumber.AutoSize = true;
            this.AssignedNumber.BackColor = System.Drawing.Color.Transparent;
            this.AssignedNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedNumber.Location = new System.Drawing.Point(148, 89);
            this.AssignedNumber.Name = "AssignedNumber";
            this.AssignedNumber.Size = new System.Drawing.Size(13, 13);
            this.AssignedNumber.TabIndex = 7;
            this.AssignedNumber.Text = "0";
            // 
            // AssignedButton
            // 
            this.AssignedButton.FlatAppearance.BorderSize = 0;
            this.AssignedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.AssignedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AssignedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignedButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedButton.Location = new System.Drawing.Point(15, 84);
            this.AssignedButton.Name = "AssignedButton";
            this.AssignedButton.Size = new System.Drawing.Size(124, 23);
            this.AssignedButton.TabIndex = 6;
            this.AssignedButton.Text = "Assigned to me";
            this.AssignedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignedButton.UseVisualStyleBackColor = true;
            this.AssignedButton.Click += new System.EventHandler(this.AssignedButton_ClickAsync);
            // 
            // WaitingNumber
            // 
            this.WaitingNumber.AutoSize = true;
            this.WaitingNumber.BackColor = System.Drawing.Color.Transparent;
            this.WaitingNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingNumber.Location = new System.Drawing.Point(148, 115);
            this.WaitingNumber.Name = "WaitingNumber";
            this.WaitingNumber.Size = new System.Drawing.Size(13, 13);
            this.WaitingNumber.TabIndex = 9;
            this.WaitingNumber.Text = "0";
            // 
            // WaitingButton
            // 
            this.WaitingButton.FlatAppearance.BorderSize = 0;
            this.WaitingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.WaitingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.WaitingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WaitingButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingButton.Location = new System.Drawing.Point(15, 110);
            this.WaitingButton.Name = "WaitingButton";
            this.WaitingButton.Size = new System.Drawing.Size(124, 23);
            this.WaitingButton.TabIndex = 8;
            this.WaitingButton.Text = "Waiting on customer";
            this.WaitingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WaitingButton.UseVisualStyleBackColor = true;
            this.WaitingButton.Click += new System.EventHandler(this.WaitingButton_ClickAsync);
            // 
            // RecentNumber
            // 
            this.RecentNumber.AutoSize = true;
            this.RecentNumber.BackColor = System.Drawing.Color.Transparent;
            this.RecentNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentNumber.Location = new System.Drawing.Point(148, 141);
            this.RecentNumber.Name = "RecentNumber";
            this.RecentNumber.Size = new System.Drawing.Size(13, 13);
            this.RecentNumber.TabIndex = 11;
            this.RecentNumber.Text = "0";
            // 
            // RecentButton
            // 
            this.RecentButton.FlatAppearance.BorderSize = 0;
            this.RecentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.RecentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RecentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentButton.Location = new System.Drawing.Point(15, 136);
            this.RecentButton.Name = "RecentButton";
            this.RecentButton.Size = new System.Drawing.Size(124, 23);
            this.RecentButton.TabIndex = 10;
            this.RecentButton.Text = "Recently resolved";
            this.RecentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecentButton.UseVisualStyleBackColor = true;
            this.RecentButton.Click += new System.EventHandler(this.RecentButton_ClickAsync);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.DarkGray;
            this.Splitter.Location = new System.Drawing.Point(173, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(1, 648);
            this.Splitter.TabIndex = 12;
            this.Splitter.Tag = "Foreground";
            // 
            // IssueListPanel
            // 
            this.IssueListPanel.Controls.Add(this.NoIssuesLabel);
            this.IssueListPanel.Controls.Add(this.IssuesList);
            this.IssueListPanel.Controls.Add(this.QueueLabel);
            this.IssueListPanel.Location = new System.Drawing.Point(176, 0);
            this.IssueListPanel.Name = "IssueListPanel";
            this.IssueListPanel.Size = new System.Drawing.Size(397, 65);
            this.IssueListPanel.TabIndex = 14;
            this.IssueListPanel.Resize += new System.EventHandler(this.IssueListPanel_Resize);
            // 
            // NoIssuesLabel
            // 
            this.NoIssuesLabel.AutoSize = true;
            this.NoIssuesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoIssuesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoIssuesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoIssuesLabel.Location = new System.Drawing.Point(201, 253);
            this.NoIssuesLabel.Name = "NoIssuesLabel";
            this.NoIssuesLabel.Size = new System.Drawing.Size(175, 17);
            this.NoIssuesLabel.TabIndex = 163;
            this.NoIssuesLabel.Text = "No issues to be found here";
            this.NoIssuesLabel.Visible = false;
            // 
            // IssuesList
            // 
            this.IssuesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssuesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listKey,
            this.listStatus,
            this.listSummary,
            this.listCreated,
            this.listReporter,
            this.listPriority});
            this.IssuesList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuesList.FullRowSelect = true;
            this.IssuesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.IssuesList.Location = new System.Drawing.Point(9, 31);
            this.IssuesList.MultiSelect = false;
            this.IssuesList.Name = "IssuesList";
            this.IssuesList.OwnerDraw = true;
            this.IssuesList.Size = new System.Drawing.Size(570, 194);
            this.IssuesList.TabIndex = 165;
            this.IssuesList.UseCompatibleStateImageBehavior = false;
            this.IssuesList.View = System.Windows.Forms.View.Details;
            this.IssuesList.Visible = false;
            this.IssuesList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.IssuesList_DrawColumnHeader);
            this.IssuesList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.IssuesList_DrawItem);
            this.IssuesList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.IssuesList_DrawSubItem);
            this.IssuesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IssuesList_MouseDoubleClickAsync);
            // 
            // listKey
            // 
            this.listKey.Text = "Key";
            // 
            // listStatus
            // 
            this.listStatus.Text = "Status";
            this.listStatus.Width = 75;
            // 
            // listSummary
            // 
            this.listSummary.Text = "Summary";
            // 
            // listCreated
            // 
            this.listCreated.Text = "Created";
            // 
            // listReporter
            // 
            this.listReporter.Text = "Reporter";
            // 
            // listPriority
            // 
            this.listPriority.Text = "Priority";
            // 
            // QueueLabel
            // 
            this.QueueLabel.AutoSize = true;
            this.QueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QueueLabel.Location = new System.Drawing.Point(5, 5);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.Size = new System.Drawing.Size(74, 21);
            this.QueueLabel.TabIndex = 161;
            this.QueueLabel.Text = "All open";
            // 
            // MessageBuilderButton
            // 
            this.MessageBuilderButton.FlatAppearance.BorderSize = 0;
            this.MessageBuilderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.MessageBuilderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MessageBuilderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageBuilderButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBuilderButton.Location = new System.Drawing.Point(12, 835);
            this.MessageBuilderButton.Name = "MessageBuilderButton";
            this.MessageBuilderButton.Size = new System.Drawing.Size(106, 23);
            this.MessageBuilderButton.TabIndex = 15;
            this.MessageBuilderButton.Text = "Message Builder";
            this.MessageBuilderButton.UseVisualStyleBackColor = true;
            this.MessageBuilderButton.Click += new System.EventHandler(this.MessageBuilderButton_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "CT-3546";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 30000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // JiraNamesButton
            // 
            this.JiraNamesButton.FlatAppearance.BorderSize = 0;
            this.JiraNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(175)))));
            this.JiraNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.JiraNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JiraNamesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JiraNamesButton.Location = new System.Drawing.Point(12, 806);
            this.JiraNamesButton.Name = "JiraNamesButton";
            this.JiraNamesButton.Size = new System.Drawing.Size(106, 23);
            this.JiraNamesButton.TabIndex = 17;
            this.JiraNamesButton.Text = "Jira Names";
            this.JiraNamesButton.UseVisualStyleBackColor = true;
            this.JiraNamesButton.Click += new System.EventHandler(this.JiraNamesButton_Click);
            // 
            // JiraIssueBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 760);
            this.Controls.Add(this.JiraNamesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageBuilderButton);
            this.Controls.Add(this.IssueListPanel);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.RecentNumber);
            this.Controls.Add(this.RecentButton);
            this.Controls.Add(this.WaitingNumber);
            this.Controls.Add(this.WaitingButton);
            this.Controls.Add(this.AssignedNumber);
            this.Controls.Add(this.AssignedButton);
            this.Controls.Add(this.UnassignedNumber);
            this.Controls.Add(this.UnassignedButton);
            this.Controls.Add(this.AllOpenNumber);
            this.Controls.Add(this.AllOpenButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TicketPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(775, 600);
            this.Name = "JiraIssueBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jira Issue Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JiraIssueBrowser_FormClosing);
            this.Load += new System.EventHandler(this.JiraIssueBrowser_Load);
            this.SizeChanged += new System.EventHandler(this.JiraIssueBrowser_SizeChanged);
            this.TicketPanel.ResumeLayout(false);
            this.TicketPanel.PerformLayout();
            this.AttachmentsPanel.ResumeLayout(false);
            this.AttachmentsPanel.PerformLayout();
            this.IssueListPanel.ResumeLayout(false);
            this.IssueListPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TicketPanel;
        private System.Windows.Forms.Label CreatedDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Reporter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ResolveButton;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.TextBox RespondText;
        private System.Windows.Forms.Label Assignee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel RespondSeperator;
        private System.Windows.Forms.Label RespondLabel;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JiraLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IssueID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AllOpenButton;
        private System.Windows.Forms.Label AllOpenNumber;
        private System.Windows.Forms.Label UnassignedNumber;
        private System.Windows.Forms.Button UnassignedButton;
        private System.Windows.Forms.Label AssignedNumber;
        private System.Windows.Forms.Button AssignedButton;
        private System.Windows.Forms.Label WaitingNumber;
        private System.Windows.Forms.Button WaitingButton;
        private System.Windows.Forms.Label RecentNumber;
        private System.Windows.Forms.Button RecentButton;
        private System.Windows.Forms.Panel Splitter;
        private System.Windows.Forms.Panel CommentsSeperator;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.LinkLabel KeyLink;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel IssueListPanel;
        private System.Windows.Forms.Label QueueLabel;
        private System.Windows.Forms.Label NoIssuesLabel;
        private System.Windows.Forms.Button RespondButton;
        private System.Windows.Forms.Button MessageBuilderButton;
        private System.Windows.Forms.ComboBox Priority;
        private System.Windows.Forms.RichTextBox CommentsText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel AttachmentsPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dropLabel;
        private System.Windows.Forms.ListView IssuesList;
        private System.Windows.Forms.ColumnHeader listKey;
        private System.Windows.Forms.ColumnHeader listStatus;
        private System.Windows.Forms.ColumnHeader listSummary;
        private System.Windows.Forms.ColumnHeader listCreated;
        private System.Windows.Forms.ColumnHeader listReporter;
        private System.Windows.Forms.ColumnHeader listPriority;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button JiraNamesButton;
    }
}