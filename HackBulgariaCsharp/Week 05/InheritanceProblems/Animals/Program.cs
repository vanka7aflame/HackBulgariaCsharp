using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Animal> animals = new List<Animal>() { new Cat(), new Dog(), new Crocodile(), new Owl(), new Shark()};
            foreach (var animal in animals)
            {
                ILandAnimals landAnimal = animal as ILandAnimals;
                if (landAnimal != null)
                {
                    Console.WriteLine(landAnimal.Greet());
                }
            }
        }
    }
}
