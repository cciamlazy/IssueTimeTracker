namespace IssueTimeTracker.Forms.Data.Visualizer
{
    partial class Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Properties_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Series_Color = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Series_YAxis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Series_XAxis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Series_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Series_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.SeriesList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Properties_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Define a filter for the data (Query):";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(218, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Build Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Days",
            "Tasks"});
            this.comboBox1.Location = new System.Drawing.Point(231, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "What type of data would you like to see?";
            // 
            // Properties_Name
            // 
            this.Properties_Name.Location = new System.Drawing.Point(52, 19);
            this.Properties_Name.Name = "Properties_Name";
            this.Properties_Name.Size = new System.Drawing.Size(247, 22);
            this.Properties_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.down);
            this.groupBox2.Controls.Add(this.up);
            this.groupBox2.Controls.Add(this.SeriesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Series";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(159, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(159, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Series_Color);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Series_YAxis);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Series_XAxis);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Series_Name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Series_Type);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(188, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 232);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Series Properties";
            // 
            // Series_Color
            // 
            this.Series_Color.Location = new System.Drawing.Point(166, 43);
            this.Series_Color.Name = "Series_Color";
            this.Series_Color.Size = new System.Drawing.Size(61, 13);
            this.Series_Color.TabIndex = 14;
            this.Series_Color.Click += new System.EventHandler(this.Series_Color_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Color:";
            // 
            // Series_YAxis
            // 
            this.Series_YAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Series_YAxis.FormattingEnabled = true;
            this.Series_YAxis.Items.AddRange(new object[] {
            "Issue Count",
            "Used Time"});
            this.Series_YAxis.Location = new System.Drawing.Point(79, 115);
            this.Series_YAxis.Name = "Series_YAxis";
            this.Series_YAxis.Size = new System.Drawing.Size(148, 21);
            this.Series_YAxis.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y-Axis Data:";
            // 
            // Series_XAxis
            // 
            this.Series_XAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Series_XAxis.FormattingEnabled = true;
            this.Series_XAxis.Items.AddRange(new object[] {
            "Organizations",
            "Time Used"});
            this.Series_XAxis.Location = new System.Drawing.Point(79, 88);
            this.Series_XAxis.Name = "Series_XAxis";
            this.Series_XAxis.Size = new System.Drawing.Size(148, 21);
            this.Series_XAxis.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X-Axis Data:";
            // 
            // Series_Name
            // 
            this.Series_Name.Location = new System.Drawing.Point(51, 15);
            this.Series_Name.Name = "Series_Name";
            this.Series_Name.Size = new System.Drawing.Size(176, 22);
            this.Series_Name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name:";
            // 
            // Series_Type
            // 
            this.Series_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Series_Type.FormattingEnabled = true;
            this.Series_Type.Items.AddRange(new object[] {
            "Days",
            "Tasks"});
            this.Series_Type.Location = new System.Drawing.Point(79, 61);
            this.Series_Type.Name = "Series_Type";
            this.Series_Type.Size = new System.Drawing.Size(148, 21);
            this.Series_Type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Graph Type:";
            // 
            // down
            // 
            this.down.Enabled = false;
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.down.Location = new System.Drawing.Point(159, 105);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(23, 23);
            this.down.TabIndex = 20;
            this.down.Text = "q";
            this.down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.Enabled = false;
            this.up.FlatAppearance.BorderSize = 0;
            this.up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.up.Location = new System.Drawing.Point(159, 76);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(23, 23);
            this.up.TabIndex = 19;
            this.up.Text = "p";
            this.up.UseVisualStyleBackColor = true;
            // 
            // SeriesList
            // 
            this.SeriesList.FormattingEnabled = true;
            this.SeriesList.Location = new System.Drawing.Point(10, 22);
            this.SeriesList.Name = "SeriesList";
            this.SeriesList.Size = new System.Drawing.Size(143, 225);
            this.SeriesList.TabIndex = 0;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Builder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Properties_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SeriesList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Series_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.TextBox Series_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Series_YAxis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Series_XAxis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel Series_Color;
        private System.Windows.Forms.Label label8;
    }
}