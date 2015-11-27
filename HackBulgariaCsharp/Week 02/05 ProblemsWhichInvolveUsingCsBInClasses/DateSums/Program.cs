using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSums
{
    class Program
    {
        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime currDate = new DateTime(year, 1, 1);
            int newSum = 0;
            while (currDate.Year == year)
            {
                string currDay = currDate.Day.ToString();
                for (int i = 0; i < currDay.Length; i++)
                {
                    newSum += currDay[i] - '0';
                }
                string currMonth = currDate.Month.ToString();
                for (int i = 0; i < currMonth.Length; i++)
                {
                    newSum += currMonth[i] - '0';
                }
                string currYear = currDate.Year.ToString();
                for (int i = 0; i < currYear.Length; i++)
                {
                    newSum += currYear[i] - '0';
                }
                if (newSum == sum)
                {
                    Console.WriteLine(currDate.ToString("dd/MM/yyyy"));
                }
                currDate = currDate.AddDays(1);
                newSum = 0;
            }
        }
        static void Main(string[] args)
        {
            int year = 2014, sum = 20;
            PrintDatesWithGivenSum(year, sum);
        }
    }
}
}
