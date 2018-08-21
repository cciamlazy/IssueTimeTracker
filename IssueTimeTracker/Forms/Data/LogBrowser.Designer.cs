namespace IssueTimeTracker.Forms
{
    partial class LogBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogBrowser));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.toTopButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.TaskFilterButton = new System.Windows.Forms.Button();
            this.exportSelectedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewButton});
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(688, 318);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.DataSourceChanged += new System.EventHandler(this.dataGrid_DataSourceChanged);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // ViewButton
            // 
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewButton.HeaderText = "View Day";
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Width = 58;
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(41, 21);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // toTopButton
            // 
            this.toTopButton.Enabled = false;
            this.toTopButton.FlatAppearance.BorderSize = 0;
            this.toTopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.toTopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toTopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toTopButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.toTopButton.Location = new System.Drawing.Point(45, 1);
            this.toTopButton.Name = "toTopButton";
            this.toTopButton.Size = new System.Drawing.Size(49, 21);
            this.toTopButton.TabIndex = 2;
            this.toTopButton.Text = "To Top";
            this.toTopButton.UseVisualStyleBackColor = true;
            this.toTopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportButton
            // 
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.exportButton.Location = new System.Drawing.Point(606, 1);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(71, 21);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export View";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TaskFilterButton
            // 
            this.TaskFilterButton.FlatAppearance.BorderSize = 0;
            this.TaskFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TaskFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaskFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskFilterButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.TaskFilterButton.Location = new System.Drawing.Point(97, 1);
            this.TaskFilterButton.Name = "TaskFilterButton";
            this.TaskFilterButton.Size = new System.Drawing.Size(81, 21);
            this.TaskFilterButton.TabIndex = 4;
            this.TaskFilterButton.Text = "Filter All Tasks";
            this.TaskFilterButton.UseVisualStyleBackColor = true;
            this.TaskFilterButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exportSelectedButton
            // 
            this.exportSelectedButton.Enabled = false;
            this.exportSelectedButton.FlatAppearance.BorderSize = 0;
            this.exportSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exportSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportSelectedButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.exportSelectedButton.Location = new System.Drawing.Point(512, 1);
            this.exportSelectedButton.Name = "exportSelectedButton";
            this.exportSelectedButton.Size = new System.Drawing.Size(91, 21);
            this.exportSelectedButton.TabIndex = 5;
            this.exportSelectedButton.Text = "Export Selected";
            this.exportSelectedButton.UseVisualStyleBackColor = true;
            this.exportSelectedButton.Visible = false;
            this.exportSelectedButton.Click += new System.EventHandler(this.exportSelectedButton_Click);
            // 
            // LogBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 341);
            this.Controls.Add(this.exportSelectedButton);
            this.Controls.Add(this.TaskFilterButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.toTopButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogBrowser";
            this.Text = "Log Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogBrowser_FormClosing);
            this.Load += new System.EventHandler(this.LogBrowser_Load);
            this.SizeChanged += new System.EventHandler(this.LogBrowser_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button toTopButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button TaskFilterButton;
        private System.Windows.Forms.Button exportSelectedButton;
    }
}