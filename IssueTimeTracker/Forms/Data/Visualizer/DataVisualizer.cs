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
using System.Windows.Forms.DataVisualization.Charting;

namespace IssueTimeTracker.Forms.Data
{
    public partial class DataVisualizer : Form
    {
        public DataVisualizer()
        {
            InitializeComponent();
        }

        List<Day> days = new List<Day>();
        List<Task> tasks = new List<Task>();

        private void DataVisualizer_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Program.DataPath + "\\TaskData\\");

            foreach (String s in files)
                days.Add(TaskTracker.LoadDay(s));

            foreach (Day d in days)
                tasks.AddRange(d.Tasks);

            CalculateOrgTimeUtil();
        }

        Dictionary<string, float> orgTimeDict = new Dictionary<string, float>();

        private void CalculateOrgTimeUtil()
        {
            foreach(Task t in tasks)
            {
                string org = GetOrg(t.IssueNumber);
                float timeUsed = 0.0f;
                bool pass = float.TryParse(t.TimeUsed, out timeUsed);

                if (orgTimeDict.ContainsKey(org))
                {
                    orgTimeDict[org] += timeUsed;
                }
                else
                {
                    orgTimeDict.Add(org, timeUsed);
                }
            }

            var sortedDict = from entry in orgTimeDict orderby entry.Value descending select entry;

            List<DataPoint> points = new List<DataPoint>();
            int i = 0;
            foreach (var v in sortedDict)
                mainChart.Series.First().Points.Add(new DataPoint() { AxisLabel = v.Key, XValue = i++, YValues = new double[] { v.Value }, ToolTip = "Org: " + v.Key + " - Total Time: " + v.Value + " hours" });
        }

        private string GetOrg(string issueNumber)
        {
            return issueNumber.Split('-')[0].Replace("_train", "").Replace("_Train", "").Replace("_dev", "").Replace("_Dev", "").Replace("_test", "").Replace("_Test", "").Replace("Test", "").Trim();
        }

        private void DataVisualizer_SizeChanged(object sender, EventArgs e)
        {
            if(ClientSize.Width >= 24 && ClientSize.Height >= 24)
                mainChart.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 24);
        }
    }
}
