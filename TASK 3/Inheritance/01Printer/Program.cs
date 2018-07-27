using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра,
строки, переданные в качестве аргументов методов, выводились разными цветами.
Обязательно используйте приведение типов.
*/

namespace _01Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = { new Printer(),
                                   new BluePrinter(),
                                   new RedPrinter()
                                 };
            foreach(Printer printer in printers)
            {
                printer.Print("To be or not to be");
            }

            BluePrinter blueprinter = printers[1] as BluePrinter;
            RedPrinter redprinter = printers[2] as RedPrinter;

            blueprinter.Print("Синий принтер приведенный к синему");
            redprinter.Print("Красный принтер приведенный к красному");
        }
    }

    class Printer
    {
        public Printer (){}

        public void Print(string value)
        {           
            Console.WriteLine(value);
        }
    }

    class BluePrinter : Printer
    {       
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print(value);
            Console.ResetColor();
        }
    }

    class RedPrinter : Printer
    {       

        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
