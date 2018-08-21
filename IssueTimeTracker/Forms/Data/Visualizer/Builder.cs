using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTimeTracker.Forms.Data.Visualizer
{
    public partial class Builder : Form
    {
        Dictionary<string, string[]> DataSets = new Dictionary<string, string[]>();

        public Builder()
        {
            InitializeComponent();

            DataSets.Add("Organization", new string[] { "Total Time", "Task Count", "Issue Count" });
            DataSets.Add("Issue #", new string[] { "Total Time" });
            DataSets.Add("Date", new string[] { "Task Count", "Issue Count" });
            DataSets.Add("Total Time", new string[] { "Task Count", "Issue Count" });
        }

        private void Series_Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Series_Color.BackColor = cd.Color;
        }

        private void Builder_Load(object sender, EventArgs e)
        {

        }
    }
}
