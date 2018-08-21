using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms
{
    public partial class SaveAs : Form
    {
        Notes parent;
        string _contents;
        public SaveAs(Notes notes, string name, string contents)
        {
            InitializeComponent();
            NameText.Text = name;
            parent = notes;
            _contents = contents;
        }

        private void SaveAs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Save(NameText.Text, _contents);
            parent.NoteTabs.TabPages[parent.NoteTabs.SelectedIndex].Text = NameText.Text;
            this.Close();
        }
    }
}
