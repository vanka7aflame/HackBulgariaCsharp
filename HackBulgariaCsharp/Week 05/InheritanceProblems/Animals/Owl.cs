using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Owl : Birds
    {
        public override string Greet()
        {
            return String.Format("BOOOOOO");
        }
    }
}
