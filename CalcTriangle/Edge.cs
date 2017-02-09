using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Edge
    {
        Point a;
        Point b;

        public Edge(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }

        public double Lenght
        {
            get
            {
                return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
            }
        }
    }
}
