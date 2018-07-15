using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье)
/// </summary>
namespace _06Day_Of_Week
{
    class Program
    {
        static Dictionary<string, int> days = new Dictionary<string, int>()
        {
            {"Понедельник", 1 },
            {"Вторник", 2 },
            {"Среда", 3 },
            {"Четверг", 4 },
            {"Пятница", 5 },
            {"Суббота", 6 },
            {"Воскресенье", 7 }
        };

        static void Main(string[] args)
        {
            int day_number = -1;
            while(day_number <= 0 || day_number > 7)
            {
                Console.WriteLine("Введите номер дня недели:");
                string userInput = Console.ReadLine();
                day_number = ParseToInt(userInput);
            }
            Console.WriteLine(days.FirstOrDefault(x=>x.Value==day_number).Key);
        }

        static int ParseToInt(string str)
        {
            int result;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            else return -1;
        }
    }
}
