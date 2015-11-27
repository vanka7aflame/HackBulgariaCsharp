using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsAndConsonants
{
    class Program
    {
        public static void countVowelsAndConsonants(string word)
        {
            int counter = 0;
            int counter1 = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    counter++;
                }
                else if (char.IsLetter(word[i]))
                {
                    counter1++;
                }
            }
            Console.WriteLine("Vowels = {0}", counter);
            Console.WriteLine("Consonants = {0}", counter1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter somthing and i will show you how many vowels and consonants u have written");
            string word = Console.ReadLine();
            countVowelsAndConsonants(word);
        }
    }
}
