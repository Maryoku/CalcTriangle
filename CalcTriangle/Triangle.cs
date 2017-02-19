using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Triangle
    {
        Point a;
        Point b;
        Point c;

        Edge u;
        Edge v;
        Edge w;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            this.u = new Edge(a, b);
            this.v = new Edge(b, c);
            this.w = new Edge(c, a);

            try
            {
                if (!((u.Length + v.Length > w.Length) && (u.Length + w.Length > v.Length) && (v.Length + w.Length > u.Length)))
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Triangle ({0},{1}):({2},{3}):({4},{5}) not exists!", a.X, a.Y, b.X, b.Y, c.X, c.Y);
                Environment.Exit(0);
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
    }
}
