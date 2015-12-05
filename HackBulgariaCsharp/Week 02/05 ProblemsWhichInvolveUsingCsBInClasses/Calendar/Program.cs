using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        public static void PrintDaysOfWeek(int month, int year, CultureInfo culture)
        {
            DateTime calendar = new DateTime(year, month, 1);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", culture.DateTimeFormat.GetDayName((DayOfWeek)i));
            }
        }
        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            DateTime calendar = new DateTime(year, month, 1);
            Console.WriteLine(calendar.ToString("MMMM", culture));
            PrintDaysOfWeek(month, year, culture);
            Console.WriteLine();
            for (int i = 0; i < (int)calendar.DayOfWeek; i++)
            {
                int length = culture.DateTimeFormat.GetDayName((DayOfWeek) i).Length + 1;
                Console.Write("{0, "+ length +"}",' ');
            }
            while (calendar.Month == month)
            {
                Console.Write("{0, "+ (culture.DateTimeFormat.GetDayName((calendar.DayOfWeek)).Length) + "} ",calendar.Day);
                
                if (calendar.DayOfWeek == DayOfWeek.Saturday )
                {
                    Console.WriteLine();
                }
                calendar = calendar.AddDays(1);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("bg-BG");
            int month = 12, year = 2015;
            PrintCalendar(month, year, culture);
        }
    }
}
