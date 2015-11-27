using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnAnagramSubsequenceInStringB
{
    class Program
    {
        public static bool HistogramWord(string inputA, string inputB)
        {
            bool isTrue = false;
            Dictionary<char, int> wordInputA = new Dictionary<char, int>();
            for (int i = 0; i < inputA.Length; i++)
            {
                char currChar = inputA[i];
                if (wordInputA.ContainsKey(currChar))
                {
                    wordInputA[currChar] += 1;
                }
                else
                {
                    wordInputA.Add(currChar, 1);
                }
            }
            Dictionary<char, int> wordInputB = new Dictionary<char, int>();
            for (int i = 0; i < inputB.Length; i++)
            {
                char currChar = inputB[i];
                if (wordInputB.ContainsKey(currChar))
                {
                    wordInputB[currChar] += 1;
                }
                else
                {
                    wordInputB.Add(currChar, 1);
                }
            }
            foreach (var k in wordInputA)
            {
                int secondValue;
                if (wordInputB.TryGetValue(k.Key, out secondValue))
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(HistogramWord("Ivan", "AzSeKazvamIvan"));
        }
    }
}
