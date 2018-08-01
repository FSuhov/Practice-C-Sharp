using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте анонимный метод, который принимает 
в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов*/

namespace _01Anonimus
{
    class Program
    {
        delegate int AverageDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            AverageDelegate ad = delegate (int a, int b, int c)
            {
                return ((a + b + c) / 3);
            };

            AverageDelegate sum = delegate (int a, int b, int c)
            {
                return (a + b + c);
            };

            Console.WriteLine(ad(2, 4, 12));
            Console.WriteLine(sum(2, 4, 12));
        }
    }
}
