﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Mammals
    {
        public override string Greet()
        {
            return String.Format("Meow");
        }
    }
}
