using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать классы Point и Figure.
 * Класс Point должен содержать два целочисленных поля и одно строковое поле.
 * Создать три свойства с одним методом доступа get.
 * Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
 * Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
 * Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны
 * многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
 * Написать программу, которая выводит на экран название и периметр многоугольника.
 */

/// <summary>
/// Моя коррекция задания: класс Point не должен содержать строковое поле. Его должен содержать класс Figure
/// и оно задается в зависимости от числа поступивших аргументов типа Point.
/// Кроме того, интересно сделать конструктор фигуры, который будет принимать переменное число аргументов.
/// Этот конструктор реализован в классе FigureMiltiParams
/// Ну и нужен метод, который проверяет точки на возможность построения фигуры: не пересекаются ли получившиеся отрезки?
/// Для этого имеет смысл сделать еще один класс - Отрезок (Line)
/// </summary>
/// 
namespace _04Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            //ТЕСТЫ ДЛЯ КЛАССА Figure
            Figure triangle = new Figure (p1, p2, p3);
            triangle.PerimeterCalculator();

            Figure rectangle = new Figure (p1, p2, p3, p4);
            rectangle.PerimeterCalculator();

            Figure pentagon = new Figure (p1, p2, p3, p4, p5);
            pentagon.PerimeterCalculator();

            Figure pentagoneWrong = new Figure(p1, p2, p3, p4, pWrong);

            //ТЕСТЫ ДЛЯ КЛАССА FigureMultiParams
            FigureMultiParams fig1 = new FigureMultiParams(p1, p2, p3);
            Console.WriteLine(fig1.ToString());

            FigureMultiParams figWrong = new FigureMultiParams(p1, p2, p3, p4, pWrong);
            

            FigureMultiParams fig2 = new FigureMultiParams(p1, p2, p3, p4, p5, p6, p7);
            Console.WriteLine(fig2.ToString());

        }

        //тестовые данные
        //треугольник:
        static Point p1 = new Point(1, 1);
        static Point p2 = new Point(2, 5);
        static Point p3 = new Point(5, 5);

        //четырехугольник
        static Point p4 = new Point(7, 1);

        //пятиугольник
        static Point p5 = new Point(2, -7);

        //неправильная точка для четырехугольника
        static Point pWrong = new Point(-4,4);

        //еще точки для многоугольника
        static Point p6 = new Point(-3, -5);
        static Point p7 = new Point(-5, 1);
    }
}
