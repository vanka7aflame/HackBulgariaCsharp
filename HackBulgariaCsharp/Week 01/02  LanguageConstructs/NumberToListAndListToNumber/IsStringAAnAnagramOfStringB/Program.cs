using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringAAnAnagramOfStringB
{
    class Program
    {
        public static string SortInput(string input)
        {
            char[] newInput = input.ToCharArray();
            Array.Sort(newInput);
            return new string(newInput);
        }
        public static bool IsAnagram(string inputA, string inputB)
        {
            string sortedInputA = SortInput(inputA);
            string sortedInputB = SortInput(inputB);
            if (inputA.Length == inputB.Length)
            {
                for (int i = 0; i < inputA.Length; i++)
                {
                    if (sortedInputA[i] == sortedInputB[i])
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("asd", "dsa"));
        }
    }
}
