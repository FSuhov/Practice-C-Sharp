using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Требуется: Создать класс с именем Rectangle.
 * В теле класса создать два поля, описывающие длины сторон double side1, side2.
 * Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля
 * side1 и side2 инициализируются значениями аргументов.
 * Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
 * прямоугольника - double PerimeterCalculator().
 * Создать два свойства double Area и double Perimeter с одним методом доступа get.
 * Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на
 * экран периметр и площадь.
*/

namespace _02Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {            
            double length, width;
            while (true)
            {
                Console.WriteLine(delimiter);
                length = -1;
                width = -1;

                Console.Write("Enter side 1 => ");
                length = readNumber();
                Console.Write("Enter side 2 => ");
                width = readNumber();
               
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine(rectangle.ToString());
                Console.WriteLine("Press Escape to stop application or any other key to calculate another rectangle");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye");
                    return;
                }
            }
        }

        static double readNumber()
        {
            double userNumber = 0;
            String userInput;
            while(userNumber <= 0)
            {
                userInput = Console.ReadLine();
                double.TryParse(userInput, out userNumber);
                if (userNumber <= 0) Console.WriteLine("Number must be positive and not 0");               
            }           
            return userNumber;
        }

        static string delimiter = "+===================================+";
    }
}
