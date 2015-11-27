using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class Program
    {
        public static List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> Birthdays = new List<int>();
            int counter = 0;
            foreach (var n in ranges)
            {
                for (int i = 0; i < birthdays.Count; i++)
                {
                    if (birthdays[i] >= n.Key && birthdays[i] <= n.Value)
                    {
                        counter++;
                    }
                }
                Birthdays.Add(counter);
                counter = 0;
            }
            foreach (var item in Birthdays)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            return Birthdays;
        }
        static void Main(string[] args)
        {
            List<int> birthdays = new List<int> { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
            ranges.Add(new KeyValuePair<int, int>(4, 9));
            ranges.Add(new KeyValuePair<int, int>(6, 7));
            ranges.Add(new KeyValuePair<int, int>(200, 225));
            ranges.Add(new KeyValuePair<int, int>(300, 365));
            Console.WriteLine(BirthdayRanges(birthdays, ranges));
        }
    }
}
