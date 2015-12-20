using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new AUDI());
            cars.Add(new Honda());
            cars.Add(new Volkswagen());
            foreach (var item in cars)
            {
                Console.WriteLine(item.IsEcoFriendly(false));
            }
        }
    }
}
