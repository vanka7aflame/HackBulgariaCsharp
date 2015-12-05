using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        private Point A, B, C, D;
        private LineSegment AB, BC;

        public Rectangle(Point p1, Point p2)
        {
            PointA = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            PointB = new Point(Math.Max(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            PointC = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            PointD = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            AB = new LineSegment(A,B);
            BC = new LineSegment(B, C);
        }

        public Rectangle(Rectangle rect)
        {
            rect.A = A;
            rect.B = B;
            rect.C = C;
            rect.D = D;
        }
        
        public Point PointA
        {
            get { return A; }
            set { A = value; }
        }
        public Point PointB
        {
            get { return B; }
            set { B = value; }
        }
        public Point PointC
        {
            get { return C; }
            set
            {
                if (value.X == A.X && value.Y == A.Y)
                {
                    throw new ArgumentException("Invalid Coordinates");
                }
                else
                {
                    C = value;
                }
            }
        }
        public Point PointD
        {
            get { return D; }
            set
            {
                if (value.X == B.X && value.Y == B.Y)
                {
                    throw new ArgumentException("Invalid Coordinates");
                }
                else
                {
                    D = value;
                }
            }
        }
        
        public double Height
        {
            get { return D.Y - A.Y; }
        }
        public double Width
        {
            get { return Math.Max(A.X, B.X) - Math.Min(A.X, B.X); }
        }

        public Point Center
        {
            get { return new Point(A.X + Width / 2, A.Y + Height / 2); }
        }
        public double GetParameter()
        {
            return ((B.X - A.X)+(C.Y - B.Y))*2 ;
        }
        public double GetArea()
        {
            return (B.X - A.X) * (D.Y - A.Y);
        }

        public override string ToString()
        {
            return string.Format("Rectangle[(x = {0}, y = {1})], (Height = {2}, Width = {3})]",
               PointA, PointC , Height, Width);
        }
        public override bool Equals(object obj)
        {
            Rectangle op = obj as Rectangle;
            if (op is Rectangle)
            {
                if (Height == op.Height && Width == op.Width)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            if (r1.A == r2.A && r1.B == r2.B && r1.C == r2.C && r1.D == r2.D)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Height.GetHashCode();
                hash = hash * 23 + Width.GetHashCode();
                return hash;
            }
        }
    }
}
