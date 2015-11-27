using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalinDrome
{
    class Program
    {
        public static bool CheckP(int number)
        {
            string a = number.ToString();
            bool check = true;
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        public static void PScore(int n)
        {
            int counter = 1;
            int currentNumber = n;
            while (true)
            {
                if (CheckP(currentNumber))
                {
                    Console.WriteLine(counter);
                    break;
                }
                else
                {
                    string reverse = new string(currentNumber.ToString().Reverse().ToArray());
                    int a = int.Parse(reverse);
                    currentNumber = currentNumber + a;
                    counter++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, which you want to find its PalinDromeScore");
            int n = int.Parse(Console.ReadLine());
            PScore(n);
        }
    }
}
