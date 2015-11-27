using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        public static bool CheckIfPrime(int number)
        {
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and i will tell you if its Prime");
            int n = int.Parse(Console.ReadLine());
            List<int> primeList = new List<int>();
            if (CheckIfPrime(n))
            {
                int currentNumber = 2;
                while (currentNumber <= n)
                {
                    if (CheckIfPrime(currentNumber))
                    {
                        primeList.Add(currentNumber);
                    }
                    currentNumber++;
                }
                for (int i = 0; i < primeList.Count; i++)
                {
                    Console.Write("{0} ", primeList[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", n);
            }
        }
    }
}
