using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPalinDrome
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

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a polindrome number and I show you the lastes palindrome number before the entered one");
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number - 1;
            int nextPalinDromeNumber;
            if (CheckP(number))
            {
                while (true)
                {
                    if (CheckP(currentNumber))
                    {
                        nextPalinDromeNumber = currentNumber;
                        break;
                    }
                    currentNumber--;
                }
                Console.WriteLine("{0} is the lastest plalindrome number before {1}", nextPalinDromeNumber, number);
            }
            else
            {
                Console.WriteLine("The number you have entered is not a PalinDrome");
            }
        }
    }
}
