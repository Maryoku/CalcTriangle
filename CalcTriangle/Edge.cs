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
                return Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
            }
        }
    }
}
