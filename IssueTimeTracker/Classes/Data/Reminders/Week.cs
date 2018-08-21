using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Data.Reminders
{
    public class Week
    {
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public bool IsDayIncluded(DateTime time)
        {
            bool i = false;
            switch(time.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    i = Monday;
                    break;
                case DayOfWeek.Tuesday:
                    i = Tuesday;
                    break;
                case DayOfWeek.Wednesday:
                    i = Wednesday;
                    break;
                case DayOfWeek.Thursday:
                    i = Thursday;
                    break;
                case DayOfWeek.Friday:
                    i = Friday;
                    break;
                case DayOfWeek.Saturday:
                    i = Saturday;
                    break;
                case DayOfWeek.Sunday:
                    i = Sunday;
                    break;
                default:
                    i = false;
                    break;
            }
            return i;
        }
    }
}
