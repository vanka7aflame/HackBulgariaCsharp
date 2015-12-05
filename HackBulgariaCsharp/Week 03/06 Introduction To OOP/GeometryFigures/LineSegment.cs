using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        private Point start;
        private Point end;
        private double length;

        public LineSegment(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this.length = GetLength();
            if (Check(start, end))
            {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }
        }
        public bool Check(Point p1, Point p2)
        {
            if (p1 == p2)
            {
                return true;
            }
            return false;
        }

        public Point Start
        {
            get { return start; }
            private set { start = value; }        
        }
        public Point End
        {
            get { return end; }
            private set { end = value; }
        }

        public double GetLength()
        {
            double length = Math.Pow(Math.Max(start.X, start.Y) - Math.Min(start.X, start.Y), 2) -
                Math.Pow(Math.Max(end.X,end.Y) - Math.Min(end.X,end.Y), 2);
            return Math.Sqrt(length);
        }
        public override string ToString()
        {
            return string.Format("Line[({0},{1}) , ({2},{3})]", start.X, end.X, start.Y, end.Y);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + start.GetHashCode();
                hash = hash * 23 + end.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (start.X == end.X && start.Y == end.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(LineSegment line, LineSegment line1)
        {
            if (line.GetLength() == line1.GetLength())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(LineSegment line, LineSegment line1)
        {
            return !(line == line1);
        }

        public static bool operator >(LineSegment line, LineSegment line1)
        {
            if (line.GetLength() > line1.GetLength())
            {
                return true;
            }
            return false;
        }
        public static bool operator <(LineSegment line, LineSegment line1)
        {
            return !(line > line1);
        }
        public static bool operator >=(LineSegment line, LineSegment line1)
        {
            if (line.GetLength() >= line1.GetLength())
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(LineSegment line, LineSegment line1)
        {
            return !(line >= line1);
        }

        public static bool operator >(LineSegment line, double line1)
        {
            if (line.GetLength() > line1)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(LineSegment line, double line1)
        {
            if (line.GetLength() < line1)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(LineSegment line, double line1)
        {
            if (line.GetLength() >= line1)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(LineSegment line, double line1)
        {
            if (line.GetLength() <= line1)
            {
                return true;
            }
            return false;
        }
    }
}
