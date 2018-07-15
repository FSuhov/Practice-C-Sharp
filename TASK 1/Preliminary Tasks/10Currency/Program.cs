using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Сделать программу перевода валют. Вводится сумма, потом выбирается вид валюты – гривны
или доллары или евро, программа переводит в две другие валюты. Текущий курс валюты
считать известным.
*/

namespace _10Currency
{
    class Program
    {
        const double uahToUsd = 26.31;
        const double uahToEur = 31.05;
        static double usdToEur = uahToUsd / uahToEur;        

        enum Currencies
        {
            UAH,
            USD,
            EUR
        }

        static void Main(string[] args)
        {
            while (true)
            {
                double amount = 0;
                while (amount == 0)
                {
                    Console.WriteLine("Enter amount");
                    string userInput = Console.ReadLine();
                    amount = ParseToDouble(userInput);
                }

                Currencies currency = PrintAndGetCurrency();
                Console.WriteLine(delimiter);
                switch ((int)currency)
                {
                    case 0:
                        Console.WriteLine(currency.ToString() + " = {0:N2}", amount);
                        Console.WriteLine(Currencies.USD.ToString() + " = {0:N2}", amount / uahToUsd);
                        Console.WriteLine(Currencies.EUR.ToString() + " = {0:N2}", amount / uahToEur);
                        break;
                    case 1:
                        Console.WriteLine(Currencies.UAH.ToString() + " = {0:N2}", amount * uahToUsd);
                        Console.WriteLine(currency.ToString() + " = {0:N2}", amount);
                        Console.WriteLine(Currencies.EUR.ToString() + " = {0:N2}", amount * usdToEur);
                        break;
                    case 2:
                        Console.WriteLine(Currencies.UAH.ToString() + " = {0:N2}", amount * uahToEur);
                        Console.WriteLine(Currencies.USD.ToString() + " = {0:N2}", amount / usdToEur);
                        Console.WriteLine(currency.ToString() + " = {0:N2}", amount);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press Escape to stop application or any other key to continue");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye");
                    return;
                }                
            }
            
        }

        static double ParseToDouble(string str)
        {
            double result;
            if (Double.TryParse(str, out result))
            {
                return result;
            }
            else return 0;
        }

        static Currencies PrintAndGetCurrency()
        {
            int currencyCode = 0;
            while (true)
            {
                Console.WriteLine("Choose currency");
                Console.WriteLine("1." + Currencies.UAH.ToString());
                Console.WriteLine("2." + Currencies.USD.ToString());
                Console.WriteLine("3." + Currencies.EUR.ToString());
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out currencyCode) && (currencyCode > 0 && currencyCode < 4))
                {
                    switch (currencyCode)
                    {
                        case 1:
                            return Currencies.UAH;                            
                        case 2:
                            return Currencies.USD;                            
                        case 3:
                            return Currencies.EUR;                           
                        default:
                            break;
                    }
                }                
            }                  
        }

        const string delimiter = "+=====================================+";
    }
}
