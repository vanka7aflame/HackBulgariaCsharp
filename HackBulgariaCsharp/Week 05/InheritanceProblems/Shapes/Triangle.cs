using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        protected Point Vertex1 { get; set; }
        protected Point Vertex2 { get; set; }
        protected Point Vertex3 { get; set; }

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.Vertex1 = p1;
            this.Vertex2 = p2;
            this.Vertex3 = p3;
        }

        public override double GetArea()
        {
            return (Vertex1.X*(Vertex2.Y - Vertex3.Y) + Vertex2.X*(Vertex3.Y - Vertex1.Y) +
                    Vertex3.X*(Vertex1.Y - Vertex2.Y))/ 2;
        }

        public override double GetPerimeter()
        {
            double C = Math.Pow(Math.Max(Vertex1.X, Vertex2.X) - Math.Min(Vertex1.X, Vertex2.X), 2) +
                       Math.Pow(Math.Max(Vertex1.Y, Vertex2.Y) - Math.Max(Vertex1.Y, Vertex2.Y), 2);
            double A = Math.Pow(Math.Max(Vertex2.X, Vertex3.X) - Math.Min(Vertex2.X, Vertex3.X), 2) +
                       Math.Pow(Math.Max(Vertex2.Y, Vertex3.Y) - Math.Min(Vertex2.Y, Vertex3.Y), 2);
            double B = Math.Pow(Math.Max(Vertex1.X, Vertex3.X) - Math.Min(Vertex1.X, Vertex3.X), 2) +
                       Math.Pow(Math.Max(Vertex1.Y, Vertex3.Y) - Math.Max(Vertex1.Y, Vertex3.Y), 2);
            A = Math.Sqrt(A);
            B = Math.Sqrt(B);
            C = Math.Sqrt(C);

            return A + B + C;
        }

        public override string ToString()
        {
            return string.Format("Vertex1 {0}, Vertex2 {1}, Vertex3 {2} Area {3}, Perimeter {4}",Vertex1, Vertex2, Vertex3, GetArea(), GetPerimeter());
        }
    }
}
