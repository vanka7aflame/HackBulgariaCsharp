using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Heigth { get; set; }
        public double Center { get; set; }

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.Width = p2.X - p1.X;
            this.Heigth = p4.Y - p1.Y;
            this.Center = (Width/2) + (Heigth/2);
        }

        public override double GetPerimeter()
        {
            return (Heigth + Width) * 2;
        }

        public override double GetArea()
        {
            return Heigth*Width;
        }

        public override string ToString()
        {
            return string.Format("Heigth {0}, Width {1}, Area {2}, Perimeter {3}", Width, Heigth, GetArea(), GetPerimeter());
        }
    }
}
