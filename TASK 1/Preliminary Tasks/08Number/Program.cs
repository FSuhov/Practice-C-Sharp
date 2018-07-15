using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на
//само себя.

namespace _08Number
{
    class Program
    {
        static void Main(string[] args)
        {            
            int number;

            Console.WriteLine("Введите натуральное число, для завершения программы введите -1");
            while (true)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out number))
                {
                    if (number == -1) return;
                    int devider = 3;
                    if (number < 0)
                    {
                        Console.WriteLine(number + " не является натуральным числом");
                        
                    }
                    else if (number <= devider)
                    {
                        Console.WriteLine(number + " является простым числом");
                    }
                    else if((number%10)%2 == 0)
                    {
                        Console.WriteLine(number + " не является простым числом");
                    }

                    else
                    {
                        int squareRoot = (int)(Math.Round(Math.Sqrt((double)number)) + 1);
                        while (devider <= squareRoot)
                        {
                            if (number % devider == 0)
                            {
                                Console.WriteLine(number + " не является простым числом");
                                break;
                            }
                            else devider++;
                        }
                        if (devider > squareRoot)
                        {
                            Console.WriteLine(number + " является простым числом");
                        }
                    }
                }
                else Console.WriteLine("Wrong data");
            }
        }
    }
}
