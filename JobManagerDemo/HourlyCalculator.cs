using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagerDemo
{
    public class HourlyCalculator
    {
        public List<PointRecord> PointsRecords { get; private set; }

        public TimeSpan TotalHoursWork
        {
            get
            {
                var totalHours = this.PointsRecords.Sum(p => (p.MorningDeparturePoint - p.ArrivalPointMorning).Ticks + (p.AfternoonDeparturePoint - p.AfternoonArrivalPoint).Ticks);
                return TimeSpan.FromTicks(totalHours);
            }
        }

        public HourlyCalculator()
        {
            this.PointsRecords = new List<PointRecord>();
        }

        public void AddPointRecord(string firstPoint, string secondPoint, string thirdPoint, string fourthPoint)
        {
            TimeSpan firstPointConverted = TimeSpan.Parse(firstPoint);
            TimeSpan secondPointConverted = TimeSpan.Parse(secondPoint);
            TimeSpan thirdPointConverted = TimeSpan.Parse(thirdPoint);
            TimeSpan fourthPointConverted = TimeSpan.Parse(fourthPoint);

            PointsRecords.Add(new PointRecord()
            {
                ArrivalPointMorning = firstPointConverted,
                MorningDeparturePoint = secondPointConverted,
                AfternoonArrivalPoint = thirdPointConverted,
                AfternoonDeparturePoint = fourthPointConverted
            });
        }

        public void RemovePointRecord(int index)
        {
            this.PointsRecords.RemoveAt(index);
        }
    }
}
