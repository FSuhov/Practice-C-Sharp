using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Figure
{
    class FigureMultiParams
    {
        List<Point> points = new List<Point>();
        string name;

        public FigureMultiParams(params Point[] values)
        {
            int numberOfPoints = values.Length;
            if(numberOfPoints < 3)
            {
                Console.WriteLine("Невозможно построить фигуру из менее чем трех точек");
                return;
            }            
            
            Line[] lines = new Line[numberOfPoints];
            for(int i = 0; i < numberOfPoints; i++)
            {
                if (i < numberOfPoints - 1)
                {
                    lines[i] = new Line(values[i], values[i + 1]);
                }
                else lines[i] = new Line(values[i], values[0]);
            }
            
            for(int i = lines.Length - 1; i >= 0; i--)
            {
                Line curLine = lines[i];
                for(int j = i-2; j >= 0; j--)
                {
                    if (curLine.IsIntersect(lines[j]))
                    {
                        Console.WriteLine("Невозможно построить фигуру из этих точек - стороны пересекаются");
                        return;
                    }
                }
            }

            name = numberOfPoints + "угольник";
            for(int i = 0; i < numberOfPoints; i++)
            {
                points.Add(values[i]);
            }
        }

        public static double SideLength(Point a, Point b)
        {
            double powOfX = Math.Pow((b.X - a.X), 2);
            double powOfY = Math.Pow((b.Y - a.Y), 2);
            return Math.Sqrt(powOfX + powOfY);
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (i < points.Count - 1)
                {
                    perimeter += SideLength(points[i], points[i + 1]);
                }
                else
                {
                    perimeter += SideLength(points[i], points[0]);
                }
            }
            return perimeter;
        }

        public override string ToString()
        {
            return System.String.Format("Это {0} с периметром {1}", name, CalculatePerimeter());
        }
    }
}
