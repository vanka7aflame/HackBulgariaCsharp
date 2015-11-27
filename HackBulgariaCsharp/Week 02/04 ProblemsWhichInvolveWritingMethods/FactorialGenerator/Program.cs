using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialGenerator
{
    class Program
    {
        public static IEnumerable<int> GenerateFactorials(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                yield return factorial;
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(string.Join("\n", GenerateFactorials(n)));
        }
    }
}
