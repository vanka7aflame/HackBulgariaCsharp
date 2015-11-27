using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningStrings
{
    class Program
    {
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == strings[strings.Length - 1])
                {
                    newString.Append(strings[i]);
                }
                else
                {
                    newString.Append(strings[i]);
                    newString.Append(separator);
                }
            }
            return newString.ToString();
        }
        static void Main(string[] args)
        {
            string separator = ",";
            string[] strings = { "az", "se", "kazvam", "IvanoluPetrovelio" };
            Console.WriteLine(JoinStrings(separator, strings));
        }
    }
}
