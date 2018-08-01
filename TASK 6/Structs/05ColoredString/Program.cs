using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран
строку заданным цветом. Используя перечисление, создайте набор цветов, доступных пользователю. Ввод
строки и выбор цвета предоставьте пользователю.
*/

namespace _05ColoredString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int color = GetColor();
                string data = GetData();
                Print(data, color);
            }
        }

      
        static void Print(string data, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(data);
            Console.ResetColor();
        }

        static int GetColor()
        {
            int color = 0;
            bool isAvailableColor = false;
            Array enumValues = Enum.GetValues(typeof(Colors));
            while (!isAvailableColor)
            {
                foreach(int enumValue in enumValues)
                {
                    Console.WriteLine(enumValue + ":" + Enum.GetName(typeof(Colors), enumValue));
                }
                Console.WriteLine("Choose color");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out color);
                if (Array.IndexOf(enumValues, (Colors)color) != -1)
                {
                    isAvailableColor = true;
                }
            }
            return color;
        }

        static string GetData()
        {
            Console.WriteLine("Введите текст");
            string data = Console.ReadLine();
            return data;
        }
    }

    enum Colors
    {
        BLUE = 1,
        CYAN = 11,
        GREEN = 10,
        MAGENTA = 13,
        RED = 12
    }

    
}
