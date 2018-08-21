namespace IssueTimeTracker.Forms
{
    partial class FirstTimeSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.JiraYesNo = new System.Windows.Forms.ComboBox();
            this.APSYesNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // Position
            // 
            this.Position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Technical Support",
            "Account Manager",
            "Implementation Engineer",
            "Business Analyst ",
            "Other"});
            this.Position.Location = new System.Drawing.Point(71, 10);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(203, 25);
            this.Position.TabIndex = 1;
            this.Position.SelectedIndexChanged += new System.EventHandler(this.Position_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(208, 103);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 31);
            this.SaveButton.TabIndex = 126;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 127;
            this.label2.Text = "Do you have access to Jira?";
            // 
            // JiraYesNo
            // 
            this.JiraYesNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JiraYesNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JiraYesNo.FormattingEnabled = true;
            this.JiraYesNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.JiraYesNo.Location = new System.Drawing.Point(216, 41);
            this.JiraYesNo.Name = "JiraYesNo";
            this.JiraYesNo.Size = new System.Drawing.Size(58, 25);
            this.JiraYesNo.TabIndex = 128;
            this.JiraYesNo.SelectedIndexChanged += new System.EventHandler(this.JiraYesNo_SelectedIndexChanged);
            // 
            // APSYesNo
            // 
            this.APSYesNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APSYesNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.APSYesNo.FormattingEnabled = true;
            this.APSYesNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.APSYesNo.Location = new System.Drawing.Point(216, 72);
            this.APSYesNo.Name = "APSYesNo";
            this.APSYesNo.Size = new System.Drawing.Size(58, 25);
            this.APSYesNo.TabIndex = 130;
            this.APSYesNo.SelectedIndexChanged += new System.EventHandler(this.APSYesNo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 129;
            this.label3.Text = "Will you be utilizing APS hours?";
            // 
            // FirstTimeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 141);
            this.Controls.Add(this.APSYesNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JiraYesNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstTimeSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Time Setup";
            this.Load += new System.EventHandler(this.FirstTimeSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JiraYesNo;
        private System.Windows.Forms.ComboBox APSYesNo;
        private System.Windows.Forms.Label label3;
    }
}