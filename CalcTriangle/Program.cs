using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?Обработка некорректных данных при создании объекта. Что подразумевается?
            // ?Реализация алгоритма для n-угольников. Алгоритма вычисления периметра/площади? В этой же программе или отдельной?
            Point p1 = new Point(0, 3);
            Point p2 = new Point(-2, -3);
            Point p3 = new Point(-6, 1);

            Point p7 = new Point(-3, -2);
            Point p8 = new Point(0, -1);
            Point p9 = new Point(-2, 5);

            Triangle[] triangleNode = new Triangle[4];

            triangleNode[0] = new Triangle(p1, p2, p3);
            triangleNode[1] = new Triangle(p1, p2, p3);
            triangleNode[2] = new Triangle(p7, p8, p9);
            triangleNode[3] = new Triangle(p7, p8, p9);

            double avgPerimeter = 0;
            double avgArea = 0;

            int counterIsos = 0;
            int counterRight = 0;

            for (int i = 0; i < 4; i++) {

                if(triangleNode[i].Exist) {
                    Console.WriteLine("Triangle {0} exist", i);
                }
                else
                {
                    Console.WriteLine("Triangle not exist! Check input.");
                    Environment.Exit(0);
                }

                if (triangleNode[i].Isosceles) {
                    avgPerimeter += triangleNode[i].Perimeter;
                    counterIsos++;   
                }

                if(triangleNode[i].Right) {
                    avgArea += triangleNode[i].Area;
                    counterRight++;
                }
            }

            avgPerimeter /= counterIsos;
            avgArea /= counterRight;

            Console.WriteLine("Average P = {0:F2} {1}", avgPerimeter, counterIsos);
            Console.WriteLine("Average S = {0:F2} {1}", avgArea, counterRight);
        }
    }

}
