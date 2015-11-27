using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int countDigits = 0, sum = 0, fac = 0;
            while (n > 0)
            {
                fac = fac + Factorial(n % 10);
                sum = sum + n % 10;
                n = n / 10;
                countDigits++;
            }
            Console.WriteLine("!n + !n(n+1) + !n(n+2) ... = {0}", fac);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("count = {0}", countDigits);
        }
    }
}
