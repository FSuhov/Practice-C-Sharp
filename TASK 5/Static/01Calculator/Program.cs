using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать статический класс – калькулятор

namespace _01Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double left = Util.GetNumber();
                double right = Util.GetNumber();
                string operation = Util.GetOperation();
                if(Calculator.Calculate(left, right, operation))
                {
                    Console.WriteLine("{0} {1} {2} = {3}", left, operation, right, Calculator.result);
                }
                else Console.WriteLine("error");
            }
        }

        static class Calculator
        {
            public static double result;
            static double Add(double left, double right)
            {
                return left + right;
            }

            static double Subtract(double left, double right)
            {
                return left - right;
            }

            static double Multiply (double left, double right)
            {
                return left * right;
            }

            static double Devide(double left, double right)
            {
                return left / right;
            }

            public static bool Calculate(double left, double right, string operation)
            {
                switch (operation)
                {
                    case "+":
                        result = Add(left, right);
                        return true;                       
                    case "-":
                        result = Subtract(left, right);
                        return true;                        
                    case "*":
                        result = Multiply(left, right);
                        return true;                        
                    case "/":
                        result = Devide(left, right);
                        return true;                        
                    default:
                        break;
                }
                return false;
            }
        }

        static class Util
        {
            public const string DELIMITER = "+====================+";

            public static double GetNumber()
            {
                double number = 0;
                bool isReallyNull = false;
                while (number == 0 && !isReallyNull)
                {
                    Console.WriteLine("Enter number");
                    string userInput = Console.ReadLine();
                    if (userInput != "0")
                    {
                        double.TryParse(userInput, out number);
                    }
                    else isReallyNull = true;
                }
                return number;
            }

            public static string GetOperation()
            {
                string operation = "";
                while(operation != "+" && operation != "-" && operation!= "*" && operation != "/")
                {
                    Console.WriteLine("Enter operator (+=*/)");
                    operation = Console.ReadLine();
                }
                return operation;
            }
        }

    }
}
