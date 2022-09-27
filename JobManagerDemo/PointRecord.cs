using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagerDemo
{
    public class PointRecord
    {
        public TimeSpan ArrivalPointMorning { get; set; }
        public TimeSpan MorningDeparturePoint { get; set; }
        public TimeSpan AfternoonArrivalPoint { get; set; }
        public TimeSpan AfternoonDeparturePoint { get; set; }
    }
}
