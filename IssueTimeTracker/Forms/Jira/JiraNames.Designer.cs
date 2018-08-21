namespace IssueTimeTracker.Forms.Jira
{
    partial class JiraNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraNames));
            this.jiraNameGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jiraNameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // jiraNameGrid
            // 
            this.jiraNameGrid.BackgroundColor = System.Drawing.Color.White;
            this.jiraNameGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jiraNameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jiraNameGrid.GridColor = System.Drawing.Color.White;
            this.jiraNameGrid.Location = new System.Drawing.Point(13, 29);
            this.jiraNameGrid.Name = "jiraNameGrid";
            this.jiraNameGrid.Size = new System.Drawing.Size(279, 238);
            this.jiraNameGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convert Jira names";
            // 
            // JiraNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jiraNameGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JiraNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JiraNames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JiraNames_FormClosing);
            this.Load += new System.EventHandler(this.JiraNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jiraNameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jiraNameGrid;
        private System.Windows.Forms.Label label1;
    }
}