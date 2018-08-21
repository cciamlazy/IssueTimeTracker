using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes
{
    public class MasterClock
    {
        private TimeSpan timeSpan;
        private Stopwatch stopwatch;

        public TimeSpan Elapsed
        {
            get
            {
                return timeSpan.Add(stopwatch.Elapsed);
            }

            set
            {
                timeSpan = value - stopwatch.Elapsed;
            }
        }

        public long ElapsedMilliseconds
        {
            get
            {
                return stopwatch.ElapsedMilliseconds + (long)timeSpan.TotalMilliseconds;
            }
        }

        public bool IsRunning
        {
            get
            {
                return stopwatch.IsRunning;
            }

            set
            {
                if (value)
                    stopwatch.Start();
                else
                    stopwatch.Stop();
            }
        }

        public TimeSpan Offset
        {
            get
            {
                return timeSpan;
            }

            set
            {
                timeSpan = value;
            }
        }

        public MasterClock()
        {
            timeSpan = new TimeSpan();
            stopwatch = new Stopwatch();
        }

        public MasterClock(int hours, int minutes, int seconds)
        {
            timeSpan = new TimeSpan(hours, minutes, seconds);
            stopwatch = new Stopwatch();
            
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public void Reset()
        {
            timeSpan = new TimeSpan();
            stopwatch.Reset();
        }

        public void Restart()
        {
            timeSpan = new TimeSpan();
            stopwatch.Restart();
        }

    }
}
