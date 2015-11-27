using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumber
{
    class Program
    {
        public static bool Check(int number)
        {
            var result = Convert.ToString(number, 2);
            bool check = true;
            for (int i = 0; i < result.Length / 2; i++)
            {
                if (result[i] != result[result.Length - 1 - i])
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(number));
            int currentNumber = number + 1;
            int nextHackNumber;
            while (true)
            {
                if (Check(currentNumber))
                {
                    nextHackNumber = currentNumber;
                    break;
                }
                currentNumber++;

            }
            Console.WriteLine("the next hack number is : {0}", nextHackNumber);
        }
    }
}
