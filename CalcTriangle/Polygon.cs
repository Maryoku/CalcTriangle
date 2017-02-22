using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Polygon
    {
        public readonly  Point[] Points;

        public Polygon(Point[] p)
        {
            this.Points = new Point[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                Points[i] = p[i];
            }
        }

        public double AreaTriangleMethod
        {
            get
            {
                double S = 0;

                for (int i = 1; i < Points.Length - 1; i++)
                {
                    Triangle triangle = new Triangle(Points[0], Points[i], Points[i + 1]);

                    S += triangle.Area;
                }

                return S;
            }
        }

        public double AreaCoordMethod
        {
            get
            {
                double S = 0;

                for (int i = 0; i < Points.Length - 1; i++)
                {
                    S += Points[i].X * Points[i + 1].Y - Points[i + 1].X * Points[i].Y;
                }

                S += Points[Points.Length - 1].X * Points[0].Y - Points[0].X * Points[Points.Length - 1].Y;
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

                for (int i = 0; i < Points.Length - 1; i++)
                {
                    Edge w;
                    w = new Edge(Points[i], Points[i + 1]);
                    P += w.Length;
                }

                Edge v;
                v = new Edge(Points[0], Points[Points.Length - 1]);
                P += v.Length;

                return P;
            }
        }

    }
}
