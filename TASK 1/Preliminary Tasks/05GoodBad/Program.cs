using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо»
/// если пользователь ввел 1 или «Плохо» если пользователь ввел 0
/// </summary>

namespace _05GoodBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 или 0");
            int userNumber;
            string responce;
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out userNumber))
            {                
                Console.WriteLine(responce = userNumber == 1 ? "Хорошо" : "Плохо");
            }
        }
    }
}
