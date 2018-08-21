namespace IssueTimeTracker.Forms
{
    partial class GenerateUpdateFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateUpdateFile));
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Required = new System.Windows.Forms.CheckBox();
            this.Verify = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReleaseNotes = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.DateFromButton = new System.Windows.Forms.Button();
            this.DateFromTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.ReleaseOrDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(428, 341);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 21);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Generate";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version:";
            // 
            // Version
            // 
            this.Version.Location = new System.Drawing.Point(76, 10);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(100, 22);
            this.Version.TabIndex = 4;
            this.Version.TextChanged += new System.EventHandler(this.Version_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Required:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verify:";
            // 
            // Required
            // 
            this.Required.AutoSize = true;
            this.Required.Location = new System.Drawing.Point(76, 72);
            this.Required.Name = "Required";
            this.Required.Size = new System.Drawing.Size(15, 14);
            this.Required.TabIndex = 8;
            this.Required.UseVisualStyleBackColor = true;
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Location = new System.Drawing.Point(147, 72);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(15, 14);
            this.Verify.TabIndex = 10;
            this.Verify.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Release Notes:";
            // 
            // ReleaseNotes
            // 
            this.ReleaseNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReleaseNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseNotes.Location = new System.Drawing.Point(279, 13);
            this.ReleaseNotes.Multiline = true;
            this.ReleaseNotes.Name = "ReleaseNotes";
            this.ReleaseNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReleaseNotes.Size = new System.Drawing.Size(294, 102);
            this.ReleaseNotes.TabIndex = 12;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 121);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(561, 214);
            this.dataGrid.TabIndex = 13;
            // 
            // DateFromButton
            // 
            this.DateFromButton.BackColor = System.Drawing.Color.Transparent;
            this.DateFromButton.FlatAppearance.BorderSize = 0;
            this.DateFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateFromButton.ForeColor = System.Drawing.Color.Transparent;
            this.DateFromButton.Image = global::IssueTimeTracker.Properties.Resources.Missing;
            this.DateFromButton.Location = new System.Drawing.Point(180, 37);
            this.DateFromButton.Name = "DateFromButton";
            this.DateFromButton.Size = new System.Drawing.Size(21, 20);
            this.DateFromButton.TabIndex = 15;
            this.DateFromButton.UseVisualStyleBackColor = false;
            this.DateFromButton.Click += new System.EventHandler(this.DateFromButton_Click);
            // 
            // DateFromTextBox
            // 
            this.DateFromTextBox.Location = new System.Drawing.Point(76, 38);
            this.DateFromTextBox.Name = "DateFromTextBox";
            this.DateFromTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateFromTextBox.TabIndex = 14;
            this.DateFromTextBox.TextChanged += new System.EventHandler(this.DateFromTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(180, 59);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 17;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 18;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReleaseOrDebug
            // 
            this.ReleaseOrDebug.AutoSize = true;
            this.ReleaseOrDebug.ForeColor = System.Drawing.Color.Red;
            this.ReleaseOrDebug.Location = new System.Drawing.Point(13, 102);
            this.ReleaseOrDebug.Name = "ReleaseOrDebug";
            this.ReleaseOrDebug.Size = new System.Drawing.Size(38, 13);
            this.ReleaseOrDebug.TabIndex = 19;
            this.ReleaseOrDebug.Text = "label3";
            // 
            // GenerateUpdateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.ReleaseOrDebug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateFromButton);
            this.Controls.Add(this.DateFromTextBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.ReleaseNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.Required);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateUpdateFile";
            this.Text = "GenerateUpdateFile";
            this.Load += new System.EventHandler(this.GenerateUpdateFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Required;
        private System.Windows.Forms.CheckBox Verify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReleaseNotes;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button DateFromButton;
        private System.Windows.Forms.TextBox DateFromTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ReleaseOrDebug;
    }
}