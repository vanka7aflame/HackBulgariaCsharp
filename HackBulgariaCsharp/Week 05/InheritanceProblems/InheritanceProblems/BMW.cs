﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProblems
{
    public class BMW : GermanCar
    {
        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
