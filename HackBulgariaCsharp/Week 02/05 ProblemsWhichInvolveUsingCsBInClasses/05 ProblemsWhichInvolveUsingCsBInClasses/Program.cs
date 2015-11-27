using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ProblemsWhichInvolveUsingCsBInClasses
{
    class Program
    {
        public static int UnfortunateFridays(int startYear, int endYear)
        {
            int counterFridays13th = 0;
            DateTime yearStart = new DateTime(startYear, 1, 13);
            while (yearStart.Year <= endYear)
            {
                if (yearStart.DayOfWeek == DayOfWeek.Friday)
                {
                    counterFridays13th++;
                }
                yearStart = yearStart.AddMonths(1);
            }
            return counterFridays13th;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(UnfortunateFridays(2014, 2015));
        }
    }
}
