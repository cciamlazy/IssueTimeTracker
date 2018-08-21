namespace IssueTimeTracker.Forms
{
    partial class MessageBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBuilder));
            this.MessageList = new System.Windows.Forms.ListBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(3, 3);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(278, 104);
            this.MessageList.TabIndex = 0;
            this.MessageList.SelectedIndexChanged += new System.EventHandler(this.MessageList_SelectedIndexChanged);
            this.MessageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MessageList_MouseDoubleClick);
            this.MessageList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageList_MouseDown);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(3, 110);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(278, 136);
            this.Message.TabIndex = 1;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // MessageBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 264);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.MessageList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MessageBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Builder";
            this.Load += new System.EventHandler(this.MessageBuilder_Load);
            this.SizeChanged += new System.EventHandler(this.MessageBuilder_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.TextBox Message;
    }
}