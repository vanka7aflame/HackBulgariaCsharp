using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction obj = new Fraction(5, 4);
            Fraction obj1 = new Fraction(3, 2);
            Console.WriteLine(obj == obj1);
            //Console.WriteLine(obj != obj1);
            //Console.WriteLine(obj + obj1);
            //Console.WriteLine(obj - obj1);
            //Console.WriteLine(obj * obj1);
            //Console.WriteLine(obj / obj1);
            //Console.WriteLine(obj.Equals(obj1));
            Console.WriteLine(obj.ToString());

        }
    }
}
