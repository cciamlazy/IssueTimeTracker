using Atlassian.Jira;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker
{
    public class JiraComment : Panel
    {
        JiraCommentController Controller;
        private Comment Comment;
        private Button minimize;
        private Button edit;
        private Button save;
        private Button delete;
        private Label name;
        private RichTextBox text;
        private Panel splitter;

        private bool minimized = false;
        private bool initialized = false;
        private bool editing = false;
        private int margin = 10;

        public JiraComment(JiraCommentController controller, Comment comment) : base()
        {
            this.Controller = controller;
            this.Comment = comment;
        }

        public void Initialize(Control control, int locationY = 0)
        {
            if (initialized)
                return;
            initialized = true;
            
            minimize = new Button();
            delete = new Button();
            edit = new Button();
            save = new Button();
            name = new Label();
            text = new RichTextBox();
            splitter = new Panel();
            this.SuspendLayout();

            int buttonsize = margin * 2;
            
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatAppearance.MouseDownBackColor = Color.White;
            minimize.FlatAppearance.MouseOverBackColor = Color.White;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Location = new Point(margin, margin);
            minimize.Name = "Minimize" + Comment.Id;
            minimize.Size = new Size(buttonsize, buttonsize);
            minimize.Font = new Font("Wingdings 3", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
            minimize.Text = "s";
            minimize.UseVisualStyleBackColor = true;
            minimize.Click += new System.EventHandler(this.minimize_Click);

            delete.FlatAppearance.BorderSize = 0;
            delete.FlatAppearance.MouseDownBackColor = Color.White;
            delete.FlatAppearance.MouseOverBackColor = Color.White;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Size = new Size(buttonsize, buttonsize);
            delete.Location = new Point(control.Width - (margin * 2) - delete.Size.Width, margin);
            delete.Font = new Font("Wingdings 2", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
            delete.Name = "Delete" + Comment.Id;
            delete.Text = "3";
            delete.UseVisualStyleBackColor = true;
            delete.Click += new System.EventHandler(this.delete_Click);

            edit.FlatAppearance.BorderSize = 0;
            edit.FlatAppearance.MouseDownBackColor = Color.White;
            edit.FlatAppearance.MouseOverBackColor = Color.White;
            edit.FlatStyle = FlatStyle.Flat;
            edit.Size = new Size(buttonsize, buttonsize);
            edit.Location = new Point(delete.Location.X - edit.Size.Width, margin);
            edit.Font = new Font("Wingdings", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
            edit.Name = "Edit" + Comment.Id;
            edit.Text = "!";
            edit.UseVisualStyleBackColor = true;
            edit.Visible = false;
            edit.Click += new System.EventHandler(this.edit_Click);

            save.FlatAppearance.BorderSize = 0;
            save.FlatAppearance.MouseDownBackColor = Color.White;
            save.FlatAppearance.MouseOverBackColor = Color.White;
            save.FlatStyle = FlatStyle.Flat;
            save.Size = new Size(buttonsize, buttonsize);
            save.Location = new Point(delete.Location.X - edit.Size.Width, margin);
            save.Font = new Font("Wingdings", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
            save.Name = "Save" + Comment.Id;
            save.Text = "2";
            save.UseVisualStyleBackColor = true;
            save.Visible = false;
            save.Click += new System.EventHandler(this.save_Click);

            name.AutoSize = true;
            name.Font = new System.Drawing.Font("Segoe UI", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            name.Location = new Point(minimize.Location.X + minimize.Size.Width + margin, margin);
            name.Name = "name" + Comment.Id;
            name.MaximumSize = new Size(control.Width - (margin * 2), name.Size.Height);
            name.Text = JiraIssueBrowser.FixJiraName(Comment.Author) + " added a comment - " + Comment.CreatedDate.Value.ToLongDateString() + " " + Comment.CreatedDate.Value.ToShortTimeString()/* + (Comment.UpdateAuthor != null || Comment.UpdateAuthor != "" ? " - edited" : "")*/;
            name.Size = new System.Drawing.Size(TextRenderer.MeasureText(name.Text, name.Font).Width, TextRenderer.MeasureText(name.Text, name.Font).Height);

            text.BorderStyle = BorderStyle.None;
            text.Location = new Point(name.Location.X, name.Location.Y + name.Size.Height + (margin * 2));
            text.Font = new Font("Segoe UI", MainData.Instance.FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            text.Name = "CommentText" + Comment.Id;
            text.ReadOnly = true;
            text.ScrollBars = RichTextBoxScrollBars.None;
            text.BackColor = Color.White;
            text.Size = new Size(control.Width - text.Location.X - (margin * 2), TextRenderer.MeasureText(Comment.Body, text.Font, new Size(control.Width, control.Height), TextFormatFlags.WordBreak).Height);
            text.Text = Comment.Body.Trim();

            splitter.BackColor = Color.DarkGray;
            splitter.Location = new Point(0, text.Location.Y + text.Size.Height + (margin * 2));
            splitter.Name = "Splitter" + Comment.Id;
            splitter.Tag = "Foreground";
            splitter.AutoScroll = false;
            splitter.Size = new Size(control.Width - (margin * 2), 1);

            this.Location = new Point(0, locationY);
            this.Name = "Panel" + Comment.Id;
            this.Size = new Size(control.Width - 20, splitter.Location.Y + splitter.Height);
            this.SizeChanged += new EventHandler(panel_Resize);
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.SizeChanged += new EventHandler(onSizeChanged);

            this.Controls.Add(this.splitter);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.name);
            this.Controls.Add(this.text);


            Setting.Value.CurrentTheme.ApplyTheme(this, new Type[] { typeof(Label), typeof(Button), typeof(Panel), typeof(RichTextBox) });
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void onSizeChanged(object sender, EventArgs e)
        {
            //this.Size = new Size(Controller.Width - 20, splitter.Location.Y + splitter.Height);
            delete.Location = new Point(this.Width - (margin * 2) - delete.Size.Width, margin);
            edit.Location = new Point(delete.Location.X - edit.Size.Width, margin);
            save.Location = new Point(delete.Location.X - edit.Size.Width, margin);
            splitter.Size = new Size(this.Width, 1);
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return Point.Empty;
            //return base.ScrollToControl(activeControl);
        }

        #region Events
        private void panel_Resize(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            minimized = !minimized;
            if (minimized)
            {
                minimize.Text = "w";
                splitter.Location = new Point(0, name.Location.Y + name.Size.Height + (margin * 2));
            }
            else
            {
                minimize.Text = "s";
                splitter.Location = new Point(0, text.Location.Y + text.Size.Height + (margin * 2));
            }
            this.Size = new Size(this.Width, splitter.Location.Y + splitter.Height);
            Controller.UpdatePositions(this);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Controller.DeleteComment(Comment);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            editing = true;
            save.Visible = true;
            edit.Visible = false;
            text.ReadOnly = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!editing)
                return;

            Controller.UpdateComment(Comment, text.Text);

            save.Visible = false;
            editing = false;
            edit.Visible = true;
            text.ReadOnly = true;
        }

        #endregion

        private Size CalculateSize()
        {
            return new Size(0, 0);
        }

        public void DisposeWhole()
        {
            this.Controls.Remove(minimize);
            minimize.Dispose();
            this.Controls.Remove(edit);
            edit.Dispose();
            this.Controls.Remove(delete);
            delete.Dispose();
            this.Controls.Remove(name);
            name.Dispose();
            this.Controls.Remove(text);
            text.Dispose();
            this.Controls.Remove(splitter);
            splitter.Dispose();
        }
    }
}
