using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Crocodile : Reptiels
    {
        public override string Greet()
        {
            return String.Format("Grrrrr");
        }
    }
}
