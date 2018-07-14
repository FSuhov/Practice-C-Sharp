using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// TASK 0-1
/// Пользователь вводит два числа. Вывести на экран большее
/// </summary>
namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = readNumber();
            int b = readNumber();
            if (a >= b) Console.WriteLine(a);
            else Console.WriteLine(b);
        }

        static int readNumber()
        {
            int userNumber;
            String userInput;
            do
            {
                Console.WriteLine("Enter integer number");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userNumber));
            return userNumber;
        }
    }
}
