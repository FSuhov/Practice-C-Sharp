using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 –
///«Весна»; 6-8 – «Лето»; 9-11 – «Осень». В любом другом случае «На этой планете такого месяца»
/// </summary>
namespace _04Seasons
{
    class Program
    {
        static int[] winter = { 1, 2, 12 };
        static int[] spring = { 3, 4, 5 };
        static int[] summer = { 6, 7, 8 };
        static int[] fall = { 9, 10, 11 };
        static void Main(string[] args)
        {
            int userNumber;
            Console.WriteLine("Введите номер месяца (январь = 1)");
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out userNumber))
            {
                if(userNumber > 0 && userNumber < 13)
                {
                    if (Array.IndexOf(winter, userNumber) != -1) Console.WriteLine("Зима");
                    else if (Array.IndexOf(spring, userNumber) != -1) Console.WriteLine("Весна");
                    else if (Array.IndexOf(summer, userNumber) != -1) Console.WriteLine("Лето");
                    else Console.WriteLine("Осень");
                }
                else Console.WriteLine("На этой планете нет такого месяца");
            }
            else Console.WriteLine("Не могу обработать данные");
        }
    }
}
