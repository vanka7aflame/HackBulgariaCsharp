using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fish : Animal
    {
        public override string Move()
        {
            return String.Format("Im a fish and my way of moving is swimming!");
        }
    }
}
