using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Mammals
    {
        public override string Greet()
        {
            return String.Format("Bau bau");
        }
    }
}
