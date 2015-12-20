using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy newToy = new Toy(5, "blue");
            Kid kid = new Kid(newToy, "boy");
            Console.WriteLine(kid.ToString());

            Adults adult = new Adults("man", true);
            Console.WriteLine(adult.ToString());
        }
    }
}
