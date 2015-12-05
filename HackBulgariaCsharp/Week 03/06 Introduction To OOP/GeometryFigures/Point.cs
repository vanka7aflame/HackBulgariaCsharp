using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Point
    {
        private double xCoor;
        private double yCoor;

        public double X
        {
            get { return xCoor; }
        }
        public double Y
        {
            get { return yCoor; }
        }
        public Point(double xOrigin, double yOrigin)
        {
            this.xCoor = xOrigin;
            this.yCoor = yOrigin;
        }

        public Point(Point p)
        {
            this.xCoor = p.X;
            this.yCoor = p.Y;
        }

        public override string ToString()
        {
            return string.Format("Point ({0},{1})", xCoor, yCoor);
        }
        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if (p != null)
            {
                if (p.X == p.Y)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + xCoor.GetHashCode();
                hash = hash * 23 + yCoor.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static LineSegment operator +(Point p1, Point p2)
        {
            return new LineSegment(p1, p2);
        }

    }
}
