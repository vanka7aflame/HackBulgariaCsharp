using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBomb
{
    class Program
    {
        public static int SpanNumber(List<int> inputNumbers)
        {
            List<int> spanNumbers = new List<int>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers.LastIndexOf(inputNumbers[i]) >= 0)
                {
                    int span = (inputNumbers.LastIndexOf(inputNumbers[i]) - i) + 1;
                    spanNumbers.Add(span);
                }
            }

            spanNumbers.Sort((a, b) => -1 * a.CompareTo(b));

            return spanNumbers[0];
        }
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int> { 1, 4, 2, 1, 4, 1, 4 };
            Console.WriteLine("MaxSpan is {0}", SpanNumber(inputNumbers));
        }
    }
}
