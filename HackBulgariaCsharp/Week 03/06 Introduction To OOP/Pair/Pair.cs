using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Pair
    {
        private object k;
        private object v;

        public object Key
        {
            get { return k; }
        }
        public object Value
        {
            get { return v; }
        }
        public void Pairs(object keys, object values)
        {
            this.k = keys;
            this.v = values;
        }
        public override string ToString()
        {
            string asd = "";
            Console.WriteLine("{0}, {1}", k, v);
            return asd;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Pair p1, Pair p2)
        {
            if (p1.Equals(p2))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pair p1, Pair p2)
        {
            if (p1.Equals(p2))
            {
                return false;
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + k.GetHashCode();
                hash = hash * 23 + v.GetHashCode();
                return hash;
            }
        }
    }
}
