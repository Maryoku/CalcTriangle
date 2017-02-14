using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Polygon
    {

        public static Point[] Input(int n)
        {
            Point[] points = new Point[n];
            Console.WriteLine("Кординаты вершины (вводить через пробел):");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите координаты вершины {0}: ", i + 1);
                var input = Console.ReadLine().Split(' ');
                var a = double.Parse(input[0]);
                var b = double.Parse(input[1]);
                points[i] = new Point(a, b);
            }

            return points;
        }

        public static double AreaTriangle(Point[] points, int n)
        {
            double S = 0;

            for (int i = 1; i < n - 1; i++)
            {
                Triangle triangle = new Triangle(points[0], points[i], points[i + 1]);

                S += triangle.Area;
            }

            return S;
        }

        public static double AreaCoord(Point[] points, int n)
        {
            double S = 0;

            for (int i = 0; i < n - 1; i++)
            {
                S += points[i].X * points[i + 1].Y - points[i + 1].X * points[i].Y;
            }

            S += points[n - 1].X * points[0].Y - points[0].X * points[n - 1].Y;
            S /= 2;

            if (S < 0)
            {
                S *= -1;
            }

            return S;
        }

        public static double Perimeter(Point[] points, int n)
        {
            double P = 0;

            for (int i = 0; i < n - 1; i++)
            {
                Edge w;
                w = new Edge(points[i], points[i+1]);
                P += w.Lenght;
            }

            Edge v;
            v = new Edge(points[0], points[n - 1]);
            P += v.Lenght;

            return P;
        }

    }
}
