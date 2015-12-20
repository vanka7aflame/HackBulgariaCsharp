using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int y, int x)
        {
            this.Y = y;
            this.X = x;
        }

        public override string ToString()
        {
            return string.Format("X {0}, Y {1}", X , Y);
        }
    }
}
