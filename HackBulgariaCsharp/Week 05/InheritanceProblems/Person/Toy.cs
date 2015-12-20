using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Toy
    {
        protected int size;
        protected string color;

        public Toy(int size, string color)
        {
            this.size = size;
            this.color = color;
        }

        public override string ToString()
        {
            return string.Format("{0} size and {1} color", size, color);
        }
    }
}
