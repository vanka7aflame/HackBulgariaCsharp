using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(5, 1);
            Point p3 = new Point(3, 5);
            Point p4 = new Point(1, 5);
            Triangle triangle = new Triangle(p1, p2, p3);
            //Console.WriteLine(triangle.GetArea());
            //Console.WriteLine(triangle.GetPerimeter());
            Console.WriteLine(triangle.ToString());
            Ellipse ellipse = new Ellipse(5, 10);
            //Console.WriteLine(ellipse.GetPerimeter());
            //Console.WriteLine(ellipse.GetArea());
            Console.WriteLine(ellipse.ToString());
            Rectangle rectangle = new Rectangle(p1,p2,p3,p4);
            //Console.WriteLine(rectangle.Width);
            //Console.WriteLine(rectangle.Heigth);
            //Console.WriteLine(rectangle.GetArea());
            //Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.ToString());
        }
    }
}
