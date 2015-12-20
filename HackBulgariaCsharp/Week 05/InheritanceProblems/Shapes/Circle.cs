using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Ellipse
    {
        protected double Radius;
        public Circle(int semiAxeA, int semiAxeB) : base(semiAxeA, semiAxeB)
        {
            this.Radius = semiAxeA*2;
        }

        public override double RadiusX
        {
            get { return base.RadiusX; }
            set
            {
                base.RadiusX = value;
                if (base.RadiusX != base.RadiusY)
                {
                    base.RadiusY = value;
                }
            }
        }

        public override double RadiusY
        {
            get { return base.RadiusY; }
            set
            {
                base.RadiusY = value;
                if (base.RadiusY != RadiusX)
                {
                    base.RadiusX = value;
                }
            }
        }

        public override double GetArea()
        {
            return (Math.PI / 4) * this.RadiusX;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.RadiusX;
        }

        public override string ToString()
        {
            return string.Format("Radius {0}, Area {1}, Perimeter{2}", Radius, GetArea(), GetPerimeter());
        }
    }
}
