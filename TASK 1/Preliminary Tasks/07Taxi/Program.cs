using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Служба такси заказала вам программу, которая спрашивает количество километров и
//количество минут простоя, а дальше считает так: первые 5 километров(или до 5 км) 20
//гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту.Программа
//должна посчитать и сказать общую сумму оплаты за поездку.

namespace _07Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = -1;
            int time = -1;
            string userInput;
            
            while(distance <= 0)
            {
                Console.WriteLine("Введите длину маршрута в километрах");
                userInput = Console.ReadLine();
                distance = ParseToInt(userInput);
            }
            while(time < 0)
            {
                Console.WriteLine("Введите длительность простоя в минутах");
                userInput = Console.ReadLine();
                time = ParseToInt(userInput);
            }

            Console.WriteLine("Стоимость поездки составит {0:N2}", CostOfTrip(distance, time));
        }

        static decimal CostOfTrip(int distance, int time)
        {
            decimal costOfDistance = distance <= 5 ? 20 : (20 + (distance - 5) * 3);
            return costOfDistance + time;
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
