using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FIO
{
    class Program
    {
        const char stringStart = '+';
        const char delimiter = '=';
        const char separator = '|';
        const string fio = "Сухов Федор Ильич";
        static void Main(string[] args)
        {
            int length = fio.Length;
            Console.Write(stringStart);
            for(int i = 0; i < length; i++)
            {
                Console.Write(delimiter);
            }
            Console.WriteLine(stringStart);
            Console.WriteLine(separator + fio + separator);
            Console.Write(stringStart);
            for (int i = 0; i < length; i++)
            {
                Console.Write(delimiter);
            }
            Console.WriteLine(stringStart);
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
