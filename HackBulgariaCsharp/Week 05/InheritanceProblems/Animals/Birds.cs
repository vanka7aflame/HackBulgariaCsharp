using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Birds : Animal , ILandAnimals
    {
        public virtual string Greet()
        {
            return String.Format("Meow");
        }
        public void MakeNest()
        {
            Console.WriteLine("I am making a nest!");
        }

        public override string Move()
        {
            return String.Format("My way of moving is flying");
        }
    }
}
