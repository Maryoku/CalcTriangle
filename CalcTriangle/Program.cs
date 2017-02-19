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

            Triangle[] triangleNode = new Triangle[]
            {
                new Triangle(p1, p2, p3),
                new Triangle(p1, p2, p3),
                new Triangle(p7, p8, p9),
                new Triangle(p7, p8, p9)
            };

            /****************************************/

            /**** Вычисление среднего периметра и средней площади ****/

            double avgPerimeter = 0;
            double avgArea = 0;

            int counterIsos = 0;
            int counterRight = 0;

            for (int i = 0; i < triangleNode.Length; i++)
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

            if (counterIsos == 0)
            {
                avgArea = 0;
            }
            else
            {
                avgArea /= counterIsos;
            }

            if (counterRight == 0)
            {
                avgPerimeter = 0;
            }
            else
            {
                avgPerimeter /= counterRight;
            }
            
            Console.WriteLine("Average P = {0:F2}", avgPerimeter);
            Console.WriteLine("Average S = {0:F2}\n", avgArea);

            /*********************************/

            /**** Блок бонусного задания ****/

            Point[] p = new Point[]
            {
                new Point(0.6, 2.1),
                new Point(1.8, 3.6),
                new Point(2.2, 2.3),
                new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };


            Polygon figure = new Polygon(p);
            Console.WriteLine("Площадь многоугольника(метод треугольников): {0:F2}", figure.AreaTriangle);
            Console.WriteLine("Площадь многоугольника, координатный метод(корректно для невыпуклых): {0:F2}", figure.AreaCoord);
            Console.WriteLine("Периметр многоугольника: {0:F2}\n", figure.Perimeter);

            /*******************************/
        }
    }

}
