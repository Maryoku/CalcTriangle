using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Edge
    {
        public readonly Point A;
        public readonly Point B;

        public Edge(Point a, Point b)
        {
            this.A = a;
            this.B = b;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            }
        }

        public static bool operator ==(Edge v, Edge w)
        {
            return w.Length == v.Length;
        }

        public static bool operator !=(Edge v, Edge w)
        {
            return !(w.Length == v.Length);
        }
    }
}
