using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        public static void FibonaciNumber(int n)
        {
            int sum = 0;
            int a = 1;
            int b = 1;
            if (n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sum = a;
                    a = b;
                    b = sum + b;
                    Console.Write("{0} ", (sum));
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for N");
            int n = int.Parse(Console.ReadLine());
            FibonaciNumber(n);
        }
    }
}
