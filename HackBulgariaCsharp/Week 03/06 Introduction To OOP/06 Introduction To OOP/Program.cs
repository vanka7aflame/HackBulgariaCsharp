using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Introduction_To_OOP
{
    class Time
    {
        private int year, month, day, hour, minutes, seconds;
        public Time(DateTime time)
        {
            year = time.Year;
            month = time.Month;
            day = time.Day;
            hour = time.Hour;
            minutes = time.Minute;
            seconds = time.Second;
        }
        public void toString()
        {
            Console.WriteLine("The time you have set is {0}:{1}:{2} {3}.{4}.{5}", hour, minutes, seconds, day, month, year);
        }
        public void Now()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current time is {0}:{1}:{2} {3}.{4}.{5}", now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(2015, 12, 1, 20, 36, 25);
            Time obj1 = new Time(time);
            obj1.toString();
            obj1.Now();
        }
    }
}
