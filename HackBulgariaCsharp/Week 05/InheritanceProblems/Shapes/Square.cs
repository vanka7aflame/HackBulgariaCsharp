using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(Point p1, Point p2, Point p3, Point p4, double width) : base(p1, p2, p3, p4)
        {
            this.Width = width;
        }

        public override double Heigth
        {
            get { return base.Heigth; }
            set
            {
                base.Heigth = value;
                if (base.Heigth != base.Width)
                {
                    base.Width = value;
                }
            }
        }

        public override double Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                if (base.Width != base.Heigth)
                {
                    base.Heigth = value;
                }
            }
        }

        public double Side
        {
            get { return this.Width; }
        }

        public override double GetArea()
        {
            return Width * Width;
        }

        public override double GetPerimeter()
        {
            return Width * 4;
        }

        public override string ToString()
        {
            return string.Format("Height {0}, Width {1}, Side {2}, Area {3}, Perimeter {4}", Heigth, Width, Side, GetArea(), GetPerimeter());
        }
    }
}
