using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeElementsInAList
{
    class Program
    {
        public static int Min(int[] array)
        {
            Console.WriteLine("The min element is {0}", array.Min());
            return array.Min();
        }
        public static int Max(int[] array)
        {
            Console.WriteLine("The max element is {0}", array.Max());
            return array.Max();
        }
        public static int Maxth(int n, int[] array)
        {
            array = array.OrderByDescending(c => c).ToArray();
            Console.WriteLine("The N Max element in the array is {0}", array[n - 1]);
            return array[n - 1];
        }
        public static int Minth(int n, int[] array)
        {
            Array.Sort<int>(array);
            Console.WriteLine("The N Minth element in the array is {0}", array[n - 1]);
            return array[n - 1];
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, -1 };
            int n = 2;
            Min(array);
            Max(array);
            Minth(n, array);
            Maxth(n, array);
        }
    }
}
