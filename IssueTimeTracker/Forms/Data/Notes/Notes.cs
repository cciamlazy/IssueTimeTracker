using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            if (Classes.Data.AdminControl.Control.View_Mode == Classes.Data.AdminControl.ViewMode.Advanced)
                createDirToolStripMenuItem.Visible = true;

            foreach (string s in Setting.Value.Notes_OpenTabs)
                AddTab(s);
        }

        private static string auth = "n_h$}pGDdGT~";

        List<RichTextBox> RTB = new List<RichTextBox>();

        public void AddTab(string title = "")
        {
            foreach(TabPage t in NoteTabs.TabPages)
                if(t.Text.Trim().ToLower().Equals(title.Trim().ToLower()))
                {
                    NoteTabs.SelectedIndex = NoteTabs.TabPages.IndexOf(t);
                    return;
                }
            TabPage page = new TabPage();
            page.Location = new System.Drawing.Point(4, 22);
            page.Name = "tabPage" + RTB.Count;
            page.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 25);
            page.TabIndex = RTB.Count;
            page.Text = (title == "" ? "New Note " + RTB.Count : title);
            page.UseVisualStyleBackColor = true;

            RTB.Add(new RichTextBox());
            RTB[RTB.Count - 1].AcceptsTab = true;
            RTB[RTB.Count - 1].BorderStyle = BorderStyle.None;
            RTB[RTB.Count - 1].Cursor = Cursors.IBeam;
            RTB[RTB.Count - 1].Location = new Point(0, 0);
            RTB[RTB.Count - 1].Name = "RTB";
            RTB[RTB.Count - 1].Size = page.ClientSize;
            RTB[RTB.Count - 1].TabIndex = 0;
            RTB[RTB.Count - 1].Text = "";
            RTB[RTB.Count - 1].WordWrap = wordWrapToolStripMenuItem.Checked;
            page.Controls.Add(RTB[RTB.Count - 1]);
            NoteTabs.TabPages.Add(page);
            NoteTabs.SelectedIndex = NoteTabs.TabCount - 1;

            if(File.Exists(Path.Combine(Program.DataPath, "Notes", title + ".rtf")))
                RTB[RTB.Count - 1].Rtf = LoadNote(title);

            RTB[RTB.Count - 1].TextChanged += new EventHandler(this.RTB_TextChanged);
        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {
            NoteTabs.TabPages[NoteTabs.SelectedIndex].Text = NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", "") + " *";
        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            this.TopMost = !this.TopMost;
            Setting.Value.Notes_AlwaysOnTop = alwaysOnTopToolStripMenuItem.Checked;
            Setting.Save();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = Setting.Value.Notes_AlwaysOnTop;
            wordWrapToolStripMenuItem.Checked = Setting.Value.Notes_WordWrap;
            if(Setting.Value.Notes_OpenTabs.Count > 0)
            {
                foreach (String s in Setting.Value.Notes_OpenTabs)
                    AddTab(s);
            }
            if (Setting.Value.Notes_SelectedNote < NoteTabs.TabCount)
                NoteTabs.SelectedIndex = Setting.Value.Notes_SelectedNote;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void Notes_Resize(object sender, EventArgs e)
        {
            NoteTabs.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 25);
            foreach(RichTextBox r in RTB)
            {
                r.Size = NoteTabs.Controls[0].ClientSize;
            }
        }

        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(RTB[NoteTabs.SelectedIndex].CanUndo)
                RTB[NoteTabs.SelectedIndex].Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB[NoteTabs.SelectedIndex].CanRedo)
                RTB[NoteTabs.SelectedIndex].Redo();
        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
                RTB[NoteTabs.SelectedIndex].Cut();
        }

        private void copyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB[NoteTabs.SelectedIndex].Copy();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
             RTB[NoteTabs.SelectedIndex].Paste();
        }

        private void deleteDELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB[NoteTabs.SelectedIndex].SelectedText.Length > 0)
                RTB[NoteTabs.SelectedIndex].SelectedText = "";
            else
            {
                int caretPosition = RTB[NoteTabs.SelectedIndex].SelectionStart;
                if (caretPosition != RTB[NoteTabs.SelectedIndex].TextLength)
                {
                    RTB[NoteTabs.SelectedIndex].Select(caretPosition, 1);
                    RTB[NoteTabs.SelectedIndex].SelectedText = "";
                }
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB[NoteTabs.SelectedIndex].SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
            foreach (RichTextBox r in RTB)
                r.WordWrap = wordWrapToolStripMenuItem.Checked;
            Setting.Value.Notes_WordWrap = wordWrapToolStripMenuItem.Checked;
            Setting.Save();
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.Value.Notes_OpenTabs = new List<string>();
            foreach(TabPage s in NoteTabs.TabPages)
            {
                Setting.Value.Notes_OpenTabs.Add(s.Text);
            }
            Setting.Value.Notes_SelectedNote = NoteTabs.SelectedIndex;
            Setting.Save();
            e.Cancel = true;
            this.Hide();
        }

        private void NoteTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting.Value.Notes_OpenTabs = new List<string>();
            foreach (TabPage s in NoteTabs.TabPages)
            {
                Setting.Value.Notes_OpenTabs.Add(s.Text);
            }
            Setting.Value.Notes_SelectedNote = NoteTabs.SelectedIndex;
            Setting.Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Program.DataPath, "Notes", NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", "") + ".rtf")))
                Save(NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", ""), RTB[NoteTabs.SelectedIndex].Rtf);
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        public void Save(string name, string contents)
        {
            if (!Directory.Exists(Path.Combine(Program.DataPath, "Notes")))
                Directory.CreateDirectory(Path.Combine(Program.DataPath, "Notes"));
            File.WriteAllText(Path.Combine(Program.DataPath, "Notes", name + ".rtf"), contents);
            NoteTabs.TabPages[NoteTabs.SelectedIndex].Text = NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", "");
        }

        public string LoadNote(string name)
        {
            return File.ReadAllText(Path.Combine(Program.DataPath, "Notes", name + ".rtf"));
        }

        private void NoteTabs_MouseUp(object sender, MouseEventArgs e)
        {
            // check if the right mouse button was pressed
            if (e.Button == MouseButtons.Right)
            {
                // iterate through all the tab pages
                for (int i = 0; i < NoteTabs.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    Rectangle r = NoteTabs.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        // show the context menu here
                        System.Diagnostics.Debug.WriteLine("TabPressed: " + i);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SaveAs(this, NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", ""), RTB[NoteTabs.SelectedIndex].Rtf).Show();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadFtpFile("Notes", Path.Combine(Program.DataPath, "Notes", NoteTabs.TabPages[NoteTabs.SelectedIndex].Text + ".rtf"));
        }

        public void UploadFtpFile(string folderName, string fileName)
        {
            FtpWebRequest request;
            try
            {
                string absoluteFileName = Path.GetFileName(fileName);
                Console.WriteLine(string.Format(@"ftp://{0}/{1}/{2}", "server237.web-hosting.com/home/csmioyik/csmithut.net/support", folderName, absoluteFileName));
                request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/{2}", "server237.web-hosting.com/home/csmioyik", folderName, absoluteFileName))) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Credentials = new NetworkCredential("support@csmithut.net", auth);
                request.ConnectionGroupName = Path.GetFileNameWithoutExtension(fileName);

                using (FileStream fs = File.OpenRead(fileName))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(buffer, 0, buffer.Length);
                    requestStream.Flush();
                    requestStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " - " + ex.InnerException);
            }
        }

        private void createDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FtpWebRequest request;
            try
            {
                request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", "csmithut.net/support", "Notes"))) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential("support@csmithut.net", auth);
                FtpWebResponse ftpResponse = (FtpWebResponse)request.GetResponse();
                Console.WriteLine(ftpResponse.StatusDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoadNote(this).Show();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", "") != NoteTabs.TabPages[NoteTabs.SelectedIndex].Text)
            {
                DialogResult d = MessageBox.Show("Do you want to save this note?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                if (d == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    if (!File.Exists(Path.Combine(Program.DataPath, "Notes", NoteTabs.TabPages[NoteTabs.SelectedIndex].Text.Replace(" *", "") + ".rtf")))
                        return;
                }
                else if (d == DialogResult.No)
                {
                    NoteTabs.TabPages.RemoveAt(NoteTabs.SelectedIndex);
                }
                else
                    return;
            }
            NoteTabs.TabPages.RemoveAt(NoteTabs.SelectedIndex);
        }
    }
}
