using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Figure
{
    class Line
    {
        private Point a;
        private Point b;

        public Line (Point _a, Point _b)
        {
            this.a = _a;
            this.b = _b;
        }

        public bool IsIntersect(Line anotherLine)
        {
            int ax1 = a.X;
            int ay1 = a.Y;
            int ax2 = b.X;
            int ay2 = b.Y;
            int bx1 = anotherLine.a.X;
            int by1 = anotherLine.a.Y;
            int bx2 = anotherLine.b.X;
            int by2 = anotherLine.b.Y;

            int v1 = (bx2 - bx1) * (ay1 - by1) - (by2 - by1) * (ax1 - bx1);
            int v2 = (bx2 - bx1) * (ay2 - by1) - (by2 - by1) * (ax2 - bx1);
            int v3 = (ax2 - ax1) * (by1 - ay1) - (ay2 - ay1) * (bx1 - ax1);
            int v4 = (ax2 - ax1) * (by2 - ay1) - (ay2 - ay1) * (bx2 - ax1);

            return (v1*v2 < 0 && v3*v4 <0);
        }

    }
}
