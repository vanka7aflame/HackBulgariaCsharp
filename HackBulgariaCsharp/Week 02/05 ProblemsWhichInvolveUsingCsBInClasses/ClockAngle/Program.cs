using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        public static double GetClockHandsAngle(DateTime time)
        {
            var hoursAngle = time.Hour * 30 + time.Minute * 0.5;
            var minutesAngle = time.Minute * 5;
            var clockAngle = hoursAngle - minutesAngle;
            if (clockAngle > 360)
            {
                return Math.Abs(clockAngle - 360) ;
            }
            else if (clockAngle < 180)
            {
                return Math.Abs(clockAngle);
            }
            else
            {
                return Math.Abs(360 - clockAngle);
            }
        }
        static void Main(string[] args)
        {
            DateTime time = new DateTime(2015, 12, 01, 12, 30, 0);
            Console.WriteLine(GetClockHandsAngle(time));
        }
    }
}
