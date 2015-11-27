using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ProblemsWhichInvolveWritingMethods
{
    class Program
    {
        public static void ReverseList(ref List<int> input)
        {
            input.ToArray();
            input.Reverse();
        }
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 2, 3, 4 };
            ReverseList(ref input);
            foreach (var c in input)
            {
                Console.WriteLine(c);
            }
        }
    }
}
