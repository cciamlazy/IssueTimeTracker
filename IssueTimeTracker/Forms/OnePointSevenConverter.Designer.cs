namespace IssueTimeTracker
{
    partial class OnePointSevenConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnePointSevenConverter));
            this.DayProgress = new CircularProgressBar.CircularProgressBar();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DayProgress
            // 
            this.DayProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.DayProgress.AnimationSpeed = 500;
            this.DayProgress.BackColor = System.Drawing.Color.White;
            this.DayProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.DayProgress.ForeColor = System.Drawing.Color.Black;
            this.DayProgress.InnerColor = System.Drawing.Color.White;
            this.DayProgress.InnerMargin = 2;
            this.DayProgress.InnerWidth = -1;
            this.DayProgress.Location = new System.Drawing.Point(-2, -2);
            this.DayProgress.MarqueeAnimationSpeed = 2000;
            this.DayProgress.Maximum = 900000;
            this.DayProgress.Name = "DayProgress";
            this.DayProgress.OuterColor = System.Drawing.Color.White;
            this.DayProgress.OuterMargin = -8;
            this.DayProgress.OuterWidth = 10;
            this.DayProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.DayProgress.ProgressWidth = 10;
            this.DayProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DayProgress.Size = new System.Drawing.Size(252, 252);
            this.DayProgress.StartAngle = 270;
            this.DayProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DayProgress.SubscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SubscriptText = "a";
            this.DayProgress.SuperscriptColor = System.Drawing.Color.Black;
            this.DayProgress.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.SuperscriptText = "a";
            this.DayProgress.TabIndex = 0;
            this.DayProgress.TextMargin = new System.Windows.Forms.Padding(0);
            this.DayProgress.Value = 50;
            this.DayProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayProgress_MouseDown);
            this.DayProgress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DayProgress_MouseMove);
            this.DayProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayProgress_MouseUp);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.Location = new System.Drawing.Point(97, 26);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 20);
            this.SettingsButton.TabIndex = 127;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Visible = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-2, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 22);
            this.button4.TabIndex = 9999;
            this.button4.Text = "Click me";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(64, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 30);
            this.button7.TabIndex = 10000;
            this.button7.Text = "Create Backup";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 10001;
            this.button1.Text = "Initialize Conversion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(64, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 30);
            this.button2.TabIndex = 10002;
            this.button2.Text = "Clean Bad Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.Location = new System.Drawing.Point(61, 177);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(125, 23);
            this.MessageLabel.TabIndex = 10003;
            this.MessageLabel.Text = "Not Started";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OnePointSevenConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DayProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnePointSevenConverter";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePointSevenConverter";
            this.Load += new System.EventHandler(this.OnePointSevenConverter_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CircularProgressBar.CircularProgressBar DayProgress;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MessageLabel;
    }
}