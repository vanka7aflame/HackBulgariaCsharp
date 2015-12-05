using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsIntersection
{
    class Program
    {
        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            string format = "dd/MM/yyyy hh:mm";
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int k = i + 1; k < startDates.Length ; k++)
                {
                    if (startDates[i] + durations[i] > startDates[k])
                    {
                        Console.WriteLine("The appointment starting at {0} intersects the appointment starting at {1}", 
                            startDates[i].ToString(format), startDates[k].ToString(format));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            DateTime[] startDates = new DateTime[]
            {
                new DateTime(2015, 01, 01, 00, 00, 0),
                new DateTime(2015, 01, 02, 00, 00, 0),
                new DateTime(2015, 01, 03, 00, 00, 0)
            };
            TimeSpan[] duration = new TimeSpan[]
            {
                new TimeSpan(03, 00, 00, 0),
                new TimeSpan(02, 00, 00, 0),
                new TimeSpan(01, 00, 00, 0)
            };
            FindIntersectingAppointments(startDates, duration);
        }
    }
}
