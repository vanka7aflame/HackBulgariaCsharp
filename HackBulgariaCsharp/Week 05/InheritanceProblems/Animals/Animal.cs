using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public virtual string Move()
        {
            return String.Format("My way of moving is:");
        }

        public virtual string Eat()
        {
            return String.Format("I can eat");
        }

        public virtual string GiveBirth()
        {
            return String.Format("I can give birth");
        }

    }
}
