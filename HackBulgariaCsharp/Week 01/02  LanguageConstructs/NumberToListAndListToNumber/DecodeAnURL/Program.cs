using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAnURL
{
    class Program
    {
        public static string DecodeAnURL(string input)
        {
            char[] charInput = input.ToCharArray();
            StringBuilder Decoded = new StringBuilder();
            foreach (var c in charInput)
            {
                Decoded.Append(c);
            }
            Decoded.Replace("%20", " ");
            Decoded.Replace("%3A", ":");
            Decoded.Replace("%3D", "?");
            Decoded.Replace("%2F", "/");

            return Decoded.ToString();
        }
        static void Main(string[] args)
        {
            string input = "kitten%20pic.jpg";
            Console.WriteLine(DecodeAnURL(input));
        }
    }
}
