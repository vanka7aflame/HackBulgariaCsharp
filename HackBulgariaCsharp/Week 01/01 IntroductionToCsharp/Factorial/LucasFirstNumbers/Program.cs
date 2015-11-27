using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasFirstNumbers
{
    class LucasFirstNumbers
    {
        public static int LucasNumber(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            else if (n == 1)
            {
                return 1;
            }

            return LucasNumber(n - 1) + LucasNumber(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(LucasNumber(i));
            }
        }
    }
}
