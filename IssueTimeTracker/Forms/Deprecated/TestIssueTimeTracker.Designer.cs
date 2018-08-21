namespace IssueTimeTracker
{
    partial class TestIssueTimeTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestIssueTimeTracker));
            this.DayProgress = new CircularProgressBar.CircularProgressBar();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProgressBarSwitcher = new System.Windows.Forms.Timer(this.components);
            this.ProgressbarRegulator = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
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
            this.DayProgress.Name = "DayProgress";
            this.DayProgress.OuterColor = System.Drawing.Color.White;
            this.DayProgress.OuterMargin = -8;
            this.DayProgress.OuterWidth = 10;
            this.DayProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.DayProgress.ProgressWidth = 10;
            this.DayProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DayProgress.Size = new System.Drawing.Size(352, 352);
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
            this.SettingsButton.Location = new System.Drawing.Point(148, 21);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 20);
            this.SettingsButton.TabIndex = 127;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBarSwitcher
            // 
            this.ProgressBarSwitcher.Enabled = true;
            this.ProgressBarSwitcher.Interval = 10000;
            this.ProgressBarSwitcher.Tick += new System.EventHandler(this.ProgressBarSwitcher_Tick);
            // 
            // ProgressbarRegulator
            // 
            this.ProgressbarRegulator.Enabled = true;
            this.ProgressbarRegulator.Tick += new System.EventHandler(this.ProgressbarRegulator_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-2, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 22);
            this.button4.TabIndex = 9999;
            this.button4.Text = "Click me";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TestIssueTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DayProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestIssueTimeTracker";
            this.Opacity = 0.85D;
            this.Text = "TestIssueTimeTracker";
            this.Load += new System.EventHandler(this.TestIssueTimeTracker_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CircularProgressBar.CircularProgressBar DayProgress;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Timer ProgressBarSwitcher;
        private System.Windows.Forms.Timer ProgressbarRegulator;
        private System.Windows.Forms.Button button4;
    }
}