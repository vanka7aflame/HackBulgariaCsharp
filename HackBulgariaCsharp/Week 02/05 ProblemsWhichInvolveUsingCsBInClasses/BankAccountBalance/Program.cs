using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBalance
{
    class Program
    {
        public static void AccountBalance()
        {
            CultureInfo culture = new CultureInfo("bg-BG");
            foreach (var line in File.ReadLines(@"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 02\05 ProblemsWhichInvolveUsingCsBInClasses\BankAccountBalance\AccountBalance.txt"))
            {
                Console.WriteLine(line.ToString(culture));
            }

        }
        static void Main(string[] args)
        {
            AccountBalance();
        }
    }
}
