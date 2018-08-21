using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.DataVisualizer
{
    public class DataVisualizerSave
    {
        public enum DataType
        {
            Days,
            Tasks
        }
        public string Name { get; set; } = "";
        public DataType Type { get; set; } = DataType.Days;
        public Filter Filter { get; set; } = new Filter();
        List<DataVisualizerSeries> Series = new List<DataVisualizerSeries>();
    }
}
