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
            /**** Блок основного задания ****/

            /**** Создание объектов ****/

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

            /****************************************/

            /**** Проверка корректности данных ****/

            for (int i = 0; i < 4; i++)
            {

                if (!triangleNode[i].Exist)
                {
                    Console.WriteLine("Triangle {0} not exist! Check input data.", i);
                    Environment.Exit(0);
                }
            }

            /*************************************/

            /**** Вычисление среднего периметра и средней площади ****/

            double avgPerimeter = 0;
            double avgArea = 0;

            int counterIsos = 0;
            int counterRight = 0;

            for (int i = 0; i < 4; i++)
            {
                if (triangleNode[i].IsIsosceles) {
                    avgArea += triangleNode[i].Area;
                    counterIsos++;   
                }

                if(triangleNode[i].IsRight) {
                    avgPerimeter += triangleNode[i].Perimeter;
                    counterRight++;
                }
            }

            avgPerimeter /= counterIsos;
            avgArea /= counterRight;

            Console.WriteLine("Average P = {0:F2}", avgPerimeter);
            Console.WriteLine("Average S = {0:F2}\n", avgArea);
            
            /*********************************/

            /**** Блок бонусного задания ****/

            Console.Write("Введите количество вершин многоугольника: ");
            int n = int.Parse(Console.ReadLine()); // string to int

            Point[] points = Polygon.Input(n);
            Console.WriteLine("\nПлощадь многоугольника(метод треугольников): {0:F2}", Polygon.AreaTriangle(points, n));
            Console.WriteLine("Площадь многоугольника, координатный метод(корректно для невыпуклых): {0:F2}", Polygon.AreaCoord(points, n));
            Console.WriteLine("Периметр многоугольника: {0:F2}\n", Polygon.Perimeter(points, n));

            /*******************************/
        }
    }

}
