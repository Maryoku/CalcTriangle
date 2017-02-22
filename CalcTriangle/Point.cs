using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return ((p1.X == p2.X) && (p1.Y == p2.Y));
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !((p1.X == p2.X) && (p1.Y == p2.Y));
        }
    }
}
