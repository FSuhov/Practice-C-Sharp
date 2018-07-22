using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Figure
{
    class Figure
    {
        Point[] points;
        string name;

        public Figure(Point a, Point b, Point c)
        {
            points = new Point[3];
            name = "Треугольник";
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[4];
            Line line1 = new Line(a, b);
            Line line3 = new Line(c, d);

            if (line1.IsIntersect(line3)){
                Console.WriteLine("Данная фигура не может быть построена в рамках этой программы");
                return;
            }
            else
            {
                name = "Четырехугольник";
                points[0] = a;
                points[1] = b;
                points[2] = c;
                points[3] = d;
            }
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[5];
            Line line1 = new Line(a, b);
            Line line2 = new Line(b, c);
            Line line3 = new Line(c, d);
            Line line4 = new Line(d, e);
            Line line5 = new Line(e, a);

            if (line1.IsIntersect(line3) || line1.IsIntersect(line4) ||
                line2.IsIntersect(line4) || line2.IsIntersect(line5) || line3.IsIntersect(line5))
            {
                Console.WriteLine("Данная фигура не может быть построена в рамках этой программы");
                return;
            }
            else
            {
                name = "Пятиугольник";
                points[0] = a;
                points[1] = b;
                points[2] = c;
                points[3] = d;
                points[4] = e;
            }
        }

        public double SideLength(Point a, Point b)
        {
            double powOfX = Math.Pow((b.X - a.X), 2);
            double powOfY = Math.Pow((b.Y - a.Y), 2);
            return Math.Sqrt(powOfX + powOfY);
        }

        public void PerimeterCalculator()
        {
            Console.Write(name);
            double perimeter = 0;
            for(int i = 0; i < points.Length; i++)
            {
                if(i < points.Length - 1)
                {
                    perimeter += SideLength(points[i], points[i + 1]);
                }
                else
                {
                    perimeter += SideLength(points[i], points[0]);
                }
            }
            Console.WriteLine(" периметр которого " + perimeter);
        }
    }
}
