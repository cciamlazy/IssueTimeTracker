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
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
            this.Text = "Add Task Time";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaticHandler._Main != null)
                StaticHandler._Main.AddExtraTaskTime(0.25f);
            if (StaticHandler._ThemedMain != null)
                StaticHandler._ThemedMain.AddExtraTaskTime(0.25f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StaticHandler._Main != null)
                StaticHandler._Main.AddExtraTaskTime(-0.25f);
            if (StaticHandler._ThemedMain != null)
                StaticHandler._ThemedMain.AddExtraTaskTime(-0.25f);
        }

        private void Advanced_Load(object sender, EventArgs e)
        {

        }
    }
}
