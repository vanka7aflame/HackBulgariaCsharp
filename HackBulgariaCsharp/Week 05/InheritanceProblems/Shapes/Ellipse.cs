using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse : Shape
    {
        public virtual double RadiusX { get; set; }
        public virtual double RadiusY { get; set; }

        public Ellipse(double semiAxeA, double semiAxeB)
        {
            this.RadiusX = semiAxeA;
            this.RadiusY = semiAxeB;
        }

        public override double GetArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }

        public override double GetPerimeter()
        {
            return Math.PI * (3 * (RadiusX + RadiusY) - Math.Sqrt((3 * RadiusX - RadiusY) * (RadiusX + 3 * RadiusY)));
        }

        public override string ToString()
        {
            return string.Format("RadiusX {0}, RadiusY {1} Area {2}, Perimeter {3}",RadiusX, RadiusY, GetArea(), GetPerimeter());
        }
    }
}
