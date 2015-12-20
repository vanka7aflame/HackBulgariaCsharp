using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public abstract class Person
    {
        public virtual string Gender(string gender)
        {
            return string.Format("I am a {0}", gender);
        }

        public virtual string DailyStuff()
        {
            return string.Format("");
        }
    }
}
