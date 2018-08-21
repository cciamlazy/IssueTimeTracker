using Atlassian.Jira;
using IssueTimeTracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker
{
    public class JiraCommentController : Panel
    {
        private List<Comment> _commentCollection = new List<Comment>();
        public List<Comment> CommentCollection { get { return _commentCollection; }
            set
            {
                DisposeAll();
                for (int i = 0; i < value.Count; i++)
                {
                    comments.Add(new JiraComment(this, value[i]));
                    comments[i].Initialize(this, (i > 0 ? comments[i - 1].Size.Height + comments[i - 1].Location.Y : 0));
                    this.Controls.Add(comments[i]);
                }
                if (value.Count > 0)
                    this.Size = new Size(this.Size.Width, comments.Last().Location.Y + comments.Last().Size.Height);
                else
                    this.Size = new Size(this.Size.Width, 0);
            }
        }

        private List<JiraComment> comments = new List<JiraComment>();
        public Issue issue;
        private JiraIssueBrowser browser;

        public JiraCommentController(JiraIssueBrowser browser, Issue issue) : base()
        {
            this.issue = issue;
            this.browser = browser;
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
        }

        public void UpdatePositions(Control control)
        {
            Point point = this.AutoScrollPosition;
            this.AutoScrollPosition = Point.Empty;
            for (int i = 0; i < comments.Count; i++)
            {
                comments[i].Location = new Point(comments[i].Location.X, (i > 0 ? comments[i - 1].Size.Height + comments[i - 1].Location.Y : 0));
            }
            if (control != null)
                this.AutoScrollPosition = ScrollToControl(control);
            else
                this.AutoScrollPosition = Point.Empty;

            this.Size = new Size(this.Size.Width, comments.Last().Location.Y + comments.Last().Size.Height);
            browser.UpdateLocations();
        }

        protected override System.Drawing.Point ScrollToControl(System.Windows.Forms.Control activeControl)
        {
            // Returning the current location prevents the panel from
            // scrolling to the active control when the panel loses and regains focus
            return this.DisplayRectangle.Location;
        }

        public async void DeleteComment(Comment comment)
        {
            if (MessageBox.Show("Are you sure you want to delete this comment?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                int pos = _commentCollection.IndexOf(comment);
                await issue.DeleteCommentAsync(comment);
                IEnumerable<Comment> newcomments = await issue.GetCommentsAsync();
                CommentCollection = newcomments.ToList<Comment>();
                UpdatePositions((pos < comments.Count) ? comments[pos] : null);
            }
        }

        public async void UpdateComment(Comment comment, string newBody)
        {
            comment.Body = newBody;
            await issue.SaveChangesAsync();
            IEnumerable<Comment> comments = await issue.GetCommentsAsync();
            CommentCollection = comments.ToList<Comment>();
        }

        public void DisposeAll()
        {
            foreach (JiraComment j in comments)
            {
                this.Controls.Remove(j);
                j.DisposeWhole();
                j.Dispose();
            }
            comments.Clear();
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            Point point = this.AutoScrollPosition;
            this.AutoScroll = false;
            foreach (JiraComment j in comments)
                j.Size = new Size(this.Size.Width, j.Size.Height);
            this.AutoScroll = true;
            this.AutoScrollPosition = point;
        }


    }
}
