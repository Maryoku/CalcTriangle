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
        }

        public double Perimeter
        {
            get
            {
                return u.Lenght + v.Lenght + w.Lenght;
            }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - u.Lenght) * (p - v.Lenght) * (p - w.Lenght));
            }
        }

        public bool Exist
        {
            get
            {
                bool result;
                if ((u.Lenght + v.Lenght > w.Lenght) &&
                    (u.Lenght + w.Lenght > v.Lenght) &&
                    (v.Lenght + w.Lenght > u.Lenght))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;
            }
        }

        public bool IsRight
        {
            get
            {
                bool result;
                if ((Math.Pow(u.Lenght, 2) + Math.Pow(v.Lenght, 2) == Math.Pow(w.Lenght, 2)) ||
                    (Math.Pow(u.Lenght, 2) + Math.Pow(w.Lenght, 2) == Math.Pow(v.Lenght, 2)) ||
                    (Math.Pow(w.Lenght, 2) + Math.Pow(v.Lenght, 2) == Math.Pow(u.Lenght, 2)))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;
            }
        }

        public bool IsIsosceles
        {
            get
            {
                bool result;

                if ((u.Lenght == v.Lenght && u.Lenght != w.Lenght) ||
                    (u.Lenght == w.Lenght && u.Lenght != v.Lenght) ||
                    (v.Lenght == w.Lenght && v.Lenght != u.Lenght))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;
            }
        }
    }
}
