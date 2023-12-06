using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calendar
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void PrintWeekdays()
        {
            Console.WriteLine("Weekdays:");
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (day != DaysOfWeek.Saturday && day != DaysOfWeek.Sunday)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
