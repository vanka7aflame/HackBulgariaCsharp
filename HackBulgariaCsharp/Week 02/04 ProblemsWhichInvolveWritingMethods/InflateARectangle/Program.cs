using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InflateARectangle
{
    class Program
    {
        public static void Inflate(ref Rectangle rectangle, Size inflateSize)
        {
            rectangle.X -= inflateSize.Width;
            rectangle.Y -= inflateSize.Height;
            rectangle.Width = rectangle.Width + (2 * inflateSize.Width);
            rectangle.Height = rectangle.Height + (2 * inflateSize.Height);
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(0, 0, 10, 10);
            Size inflateSize = new Size(2, 2);
            Inflate(ref rectangle, inflateSize);
            Console.WriteLine(rectangle);
        }
    }
}
