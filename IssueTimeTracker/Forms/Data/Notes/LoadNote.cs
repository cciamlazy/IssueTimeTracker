using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class LoadNote : Form
    {
        Notes _Parent;
        public LoadNote(Notes parent)
        {
            InitializeComponent();
            _Parent = parent;
        }

        private void LoadNote_Load(object sender, EventArgs e)
        {
            List<string> files = Directory.GetFiles(Path.Combine(Program.DataPath, "Notes")).ToList<string>();
            foreach(string s in files)
            {
                FileInfo f = new FileInfo(s);
                if(f.Extension == ".rtf")
                    loadList.Items.Add(f.Name.Replace(f.Extension, ""));
            }
        }

        private void loadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loadList.SelectedIndex >= 0 && loadList.SelectedIndex <= loadList.Items.Count) 
            {
                OpenButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                OpenButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            _Parent.AddTab(loadList.SelectedItem.ToString());
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string selectedFile = loadList.SelectedItem.ToString() + ".rtf";
            loadList.Items.Clear();
            if (MessageBox.Show("Are you sure you want to delete this note?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                List<string> files = Directory.GetFiles(Path.Combine(Program.DataPath, "Notes")).ToList<string>();
                foreach (string s in files)
                {
                    FileInfo f = new FileInfo(s);
                    if (f.Name == selectedFile)
                        File.Delete(s);
                    else if (f.Extension == ".rtf")
                        loadList.Items.Add(new FileInfo(s).Name.Replace(f.Extension, ""));
                }
            }
        }

        private void loadList_DoubleClick(object sender, EventArgs e)
        {
            OpenButton_Click(sender, e);
        }
    }
}
