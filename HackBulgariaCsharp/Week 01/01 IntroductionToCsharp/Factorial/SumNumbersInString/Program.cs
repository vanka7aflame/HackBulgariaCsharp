using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbersInString
{
    class Program
    {
        public static int SumNums(string input)
        {
            int sum = 0;
            var temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    int digit = input[i] - '0';
                    temp = temp * 10 + digit;
                }
                else
                {
                    sum += temp;
                    temp = 0;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumNums("1asd23asd34asd"));
        }
    }
}
