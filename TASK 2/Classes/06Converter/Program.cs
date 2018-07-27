using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.30, 31.20, 0.407);
            int currencyCode = GetUserCurrnecy();
            double amount = GetUserAmount();
            converter.ChangeCurrency(amount, (Currencies)currencyCode);
            Console.WriteLine(delimiter);
            Console.WriteLine(converter.ToString());
            Console.WriteLine(delimiter);

        }

        public static int GetUserCurrnecy()
        {
            int currency = 0;
            while (currency <= 0 || currency > 4)
            {
                Console.WriteLine("Choose Currency:");
                Console.WriteLine(Currencies.USD.ToString());
                Console.WriteLine(Currencies.EUR.ToString());
                Console.WriteLine(Currencies.RUB.ToString());
                Console.WriteLine(Currencies.UAH.ToString());
                string strCurrency = Console.ReadLine();
                int.TryParse(strCurrency, out currency);
            }            
            return currency;
        }

        public static double GetUserAmount()
        {
            double amount = 0;
            while(amount <= 0)
            {
                Console.WriteLine("Enter amount");
                string strAmount = Console.ReadLine();
                double.TryParse(strAmount, out amount);
            }
            return amount;
        }

        public static string delimiter = "+================================+";
    }
}
