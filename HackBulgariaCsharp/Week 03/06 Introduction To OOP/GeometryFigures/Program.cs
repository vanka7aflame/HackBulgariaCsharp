using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 1);
            Point point1 = new Point(7, 3);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(7, 3);
            //LineSegment line = new LineSegment(point, point3);
            //LineSegment line1 = new LineSegment(point1, point2);
            //Console.WriteLine(line != line1);
            //Console.WriteLine(line <= line1);
            Rectangle rect = new Rectangle(point, point1);
            Rectangle newRect = new Rectangle(point2, point3);
            Console.WriteLine("Rectangle Parameter = {0}", rect.GetParameter());
            Console.WriteLine("Rectangle Area = {0}",rect.GetArea());
            Console.WriteLine(rect.ToString());
            Console.WriteLine(rect.Equals(newRect));
            //Console.WriteLine(rect == newRect);
        }
    }
}
