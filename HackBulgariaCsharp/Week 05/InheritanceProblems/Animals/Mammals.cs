using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Mammals : Animal, ILandAnimals
    {
        public virtual string Greet()
        {
            return String.Format("Meow");
        }
        public override string Move()
        {
            return String.Format("I am a landAnimal and my way of moving is walking or running");
        }
    }
}
