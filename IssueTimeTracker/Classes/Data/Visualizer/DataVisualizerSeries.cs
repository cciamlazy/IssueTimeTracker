using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IssueTimeTracker.DataVisualizer
{
    public class DataVisualizerSeries
    {
        public string Name { get; set; } = "New Series";
        [XmlElement(Type = typeof(XmlColor))]
        public Color Color { get; set; } = Color.Red;
        public int Type { get; set; } = 0;
        public int XAxis { get; set; } = 0;
        public int YAxis { get; set; } = 0;
    }
}
