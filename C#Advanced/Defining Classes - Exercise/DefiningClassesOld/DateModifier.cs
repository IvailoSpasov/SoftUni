using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int GetDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            var first = DateTime.Parse(firstDate);
            var second = DateTime.Parse(secondDate);
            int totalDays = Math.Abs((int)(first - second).TotalDays);
            return totalDays;
        }
    }
}
