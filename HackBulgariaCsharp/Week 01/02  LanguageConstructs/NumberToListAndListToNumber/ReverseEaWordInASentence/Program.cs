using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEaWordInASentence
{
    class Program
    {
        public static string ReversedSentence(string sentence)
        {
            string newSentence = "";
            foreach (var word in sentence.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = temp + ch;
                }
                newSentence = newSentence + temp + " ";
            }
            return newSentence;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine();
            Console.WriteLine(ReversedSentence(input));
        }
    }
}
