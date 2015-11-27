using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        public static Dictionary<char, int> Histogram(string word)
        {
            Dictionary<char, int> histogram = new Dictionary<char, int>();
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char currentChar = word[i];
                    if (histogram.ContainsKey(currentChar))
                    {
                        histogram[currentChar] = histogram[currentChar] + 1;
                    }
                    else
                    {
                        histogram.Add(currentChar, 1);
                    }
                }
            }
            foreach (KeyValuePair<char, int> eachChar in histogram)
            {
                Console.Write("'{0}':'{1}' ; ", eachChar.Key, eachChar.Value);
            }
            Console.WriteLine();
            return histogram;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter somthing and i will show you how many times each char is used ");
            string word = Console.ReadLine();
            Console.WriteLine(Histogram(word));
        }
    }
}
