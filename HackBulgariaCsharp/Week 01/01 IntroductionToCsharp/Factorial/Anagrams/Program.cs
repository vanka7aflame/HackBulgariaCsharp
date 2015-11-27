using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        public static bool CheckAnagram(string wordA, string wordB)
        {
            Dictionary<char, int> A = new Dictionary<char, int>();
            foreach (var element in wordA)
            {
                if (A.ContainsKey(element))
                {
                    A[element] += 1;
                }
                else
                {
                    A.Add(element, 1);
                }
            }
            Dictionary<char, int> B = new Dictionary<char, int>();
            foreach (var element in wordB)
            {
                if (B.ContainsKey(element))
                {
                    B[element] += 1;
                }
                else
                {
                    B.Add(element, 1);
                }
            }
            bool equalAB = A.OrderBy(r => r.Key).SequenceEqual(B.OrderBy(r => r.Key));
            return equalAB;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter an other word");
            string word2 = Console.ReadLine();
            Console.WriteLine("Are the 2 words anagramic? {0}", CheckAnagram(word1, word2));
        }
    }
}
