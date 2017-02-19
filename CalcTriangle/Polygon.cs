using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Polygon
    {
        Point[] points;

        public Polygon(Point[] p)
        {
            this.points = new Point[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                points[i] = p[i];
            }
        }

        public double AreaTriangle
        {
            get
            {
                double S = 0;

                for (int i = 1; i < points.Length - 1; i++)
                {
                    Triangle triangle = new Triangle(points[0], points[i], points[i + 1]);

                    S += triangle.Area;
                }

                return S;
            }
        }

        public double AreaCoord
        {
            get
            {
                double S = 0;

                for (int i = 0; i < points.Length - 1; i++)
                {
                    S += points[i].X * points[i + 1].Y - points[i + 1].X * points[i].Y;
                }

                S += points[points.Length - 1].X * points[0].Y - points[0].X * points[points.Length - 1].Y;
                S /= 2;

                if (S < 0)
                {
                    S *= -1;
                }

                return S;
            }
        }

        public double Perimeter
        {
            get
            {
                double P = 0;

                for (int i = 0; i < points.Length - 1; i++)
                {
                    Edge w;
                    w = new Edge(points[i], points[i + 1]);
                    P += w.Length;
                }

                Edge v;
                v = new Edge(points[0], points[points.Length - 1]);
                P += v.Length;

                return P;
            }
        }

    }
}
