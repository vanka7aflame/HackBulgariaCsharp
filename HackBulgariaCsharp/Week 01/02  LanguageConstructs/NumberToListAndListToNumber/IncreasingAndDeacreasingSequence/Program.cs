using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAndDeacreasingSequence
{
    class Program
    {
        public static bool IsIncreasing(int[] sequence)
        {
            bool check = true;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (!(sequence[i] < sequence[i + 1]))
                {
                    check = false;
                    break;
                }
            }
            Console.WriteLine("Is the sequence increasing? {0}", check);
            return check;
        }
        public static bool isDeacreasing(int[] sequence)
        {
            bool check = true;
            for (int i = 1; i > sequence.Length; i++)
            {
                if (!(sequence[i] < sequence[i + 1]))
                {
                    check = false;
                    break;
                }
            }
            Console.WriteLine("Is the sequence decreasing? {0}", check);
            return check;
        }

        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 1 };
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }
            Console.WriteLine();
            IsIncreasing(sequence);
            isDeacreasing(sequence);
        }
    }
}
