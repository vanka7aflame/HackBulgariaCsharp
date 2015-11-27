using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToListAndListToNumber
{
    class Program
    {
        public static List<int> newList(int n)
        {
            List<int> newList = new List<int>();

            while (n > 0)
            {
                newList.Add(n % 10);
                n = n / 10;
            }
            foreach (var element in newList)
            {
                Console.WriteLine(element);
            }
            return newList;
        }

        public static int ListToNumber(string digits)
        {
            int counter = 0;
            List<char> stringList = new List<char>();
            for (int i = 0; i < digits.Length; i++)
            {
                stringList.Add(digits[i]);
            }
            foreach (var c in stringList)
            {
                counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            newList(n);
            Console.WriteLine("Enter something");
            string digits = Console.ReadLine();
            Console.WriteLine(ListToNumber(digits));
        }
    }
}
