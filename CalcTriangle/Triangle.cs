using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Triangle
    {
        public readonly Point A;
        public readonly Point B;
        public readonly Point C;

        Edge u;
        Edge v;
        Edge w;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            this.u = new Edge(a, b);
            this.v = new Edge(b, c);
            this.w = new Edge(c, a);


            if (!((u.Length + v.Length > w.Length) && (u.Length + w.Length > v.Length) && (v.Length + w.Length > u.Length)))
            {
                throw new ArgumentException();
            }
        }

        public double Perimeter
        {
            get
            {
                return u.Length + v.Length + w.Length;
            }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - u.Length) * (p - v.Length) * (p - w.Length));
            }
        }

        public bool IsRight
        {
            get
            {
                return ((Math.Pow(u.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(w.Length, 2)) ||
                        (Math.Pow(u.Length, 2) + Math.Pow(w.Length, 2) == Math.Pow(v.Length, 2)) ||
                        (Math.Pow(w.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(u.Length, 2)));
            }
        }

        public bool IsIsosceles
        {
            get
            {
                return ((u.Length == v.Length && u.Length != w.Length) ||
                        (u.Length == w.Length && u.Length != v.Length) ||
                        (v.Length == w.Length && v.Length != u.Length));
            }
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return ((t1.A == t2.A) && (t1.B == t2.B) && (t1.C == t2.C));
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return (!((t1.A == t2.A) && (t1.B == t2.B) && (t1.C == t2.C)));
        }
    }
}
