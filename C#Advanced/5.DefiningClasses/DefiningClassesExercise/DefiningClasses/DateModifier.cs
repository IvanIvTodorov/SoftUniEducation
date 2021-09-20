using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateModifier(string[] firstDate,string[] secondDate)
        {
            FirstDate = new DateTime(int.Parse(firstDate[0]), int.Parse(firstDate[1]), int.Parse(firstDate[2]));
            SecondDate = new DateTime(int.Parse(secondDate[0]), int.Parse(secondDate[1]), int.Parse(secondDate[2]));
        }

        public DateTime FirstDate { get; set; }
        public DateTime SecondDate { get; set; }

        public int DayDifference()
        {
            int difference = Math.Abs((this.FirstDate - this.SecondDate).Days);
            return difference;
        }
    }
}
