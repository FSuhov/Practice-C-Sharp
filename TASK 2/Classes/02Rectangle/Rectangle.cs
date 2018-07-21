using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double _side1, double _side2)
        {
            this.side1 = _side1;
            this.side2 = _side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }

        public double Area { get { return this.AreaCalculator(); } }

        public double Perimeter { get { return this.PerimeterCalculator(); } }

        public override string ToString()
        {
            return System.String.Format("Этот прямоугольник имеет: \nПериметр {0}\nПлощадь {1}", Perimeter, Area);
        }
    }
}
