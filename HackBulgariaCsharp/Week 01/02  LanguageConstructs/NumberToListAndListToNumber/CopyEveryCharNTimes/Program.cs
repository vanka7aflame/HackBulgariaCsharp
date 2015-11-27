using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyEveryCharNTimes
{
    class Program
    {
        public static void CopyEachChar(string input, int n)
        {
            char[] chars = input.ToCharArray();
            StringBuilder newInput = new StringBuilder();
            foreach (var c in chars)
            {
                for (int i = 0; i < n; i++)
                {
                    newInput.Append(c);
                }
            }
            Console.WriteLine(newInput);
        }
        static void Main(string[] args)
        {
            CopyEachChar("tldr", 3);
        }
    }
}
