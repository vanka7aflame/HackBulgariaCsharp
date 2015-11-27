using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word and i will print it backwards");
            string word = Console.ReadLine();
            string revers = new string(word.Reverse().ToArray());
            Console.WriteLine(revers);
        }
    }
}
