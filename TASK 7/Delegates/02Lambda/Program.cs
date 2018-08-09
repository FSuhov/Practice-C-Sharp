using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте четыре лямбда оператора для выполнения арифметических действий: 
(Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль.
Написать программу, которая будет выполнять арифметические действия указанные пользователем.
*/

namespace _02Lambda
{
    class Program
    {
        public delegate double MathAction(int left, int right); 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first operand:");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter action:");
            string action = Console.ReadLine();
            Console.WriteLine("Enter second operand:");
            int right = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (action)
            {
                case "+":
                    MathAction Add = (x, y) => x + y;
                    result = Add(left, right);
                    break;
                case "-":
                    MathAction Sub = (x, y) => x - y;
                    result = Sub(left, right);
                    break;
                case "*":
                    MathAction Mul = (x, y) => x * y;
                    result = Mul(left, right);
                    break;
                case "/":
                    MathAction Div = (x, y) => y == 0 ? double.PositiveInfinity : x / y;
                    result = Div(left, right);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Result = " + result);
        }
    }
}
