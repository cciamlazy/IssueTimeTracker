using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Helper
{
    /// <summary>
    /// This class was created to reduce the amount of CPU usage
    /// </summary>
    public class TimerHelper
    {
        public bool MillisecondChanged { get; private set; }
        private int _milliseconds = -1;
        public int Milliseconds { get { return _milliseconds; } set { if (_milliseconds != value) { MillisecondChanged = true; _milliseconds = value; } else MillisecondChanged = false; } }

        public bool SecondChanged { get; private set; }
        private int _seconds = -1;
        public int Seconds { get { return _seconds; } set { if (_seconds != value) { SecondChanged = true; _seconds = value; } else SecondChanged = false; } }

        public bool MinuteChanged { get; private set; }
        private int _minutes = -1;
        public int Minutes { get { return _minutes; } set { if (_minutes != value) { MinuteChanged = true; _minutes = value; } else MinuteChanged = false; } }

        public bool HourChanged { get; private set; }
        private int _hours = -1;
        public int Hours { get { return _hours; } set { if (_hours != value) { HourChanged = true; _hours = value; } else HourChanged = false; } }
    }
}
