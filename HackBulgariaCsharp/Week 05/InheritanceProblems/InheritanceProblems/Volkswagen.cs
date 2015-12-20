using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProblems
{
    public class Volkswagen : GermanCar
    {
        public override bool IsEcoFriendly(bool testing)
        {
            if (testing == true)
            {
                return true;
            }
            return false;
        }
    }
}
