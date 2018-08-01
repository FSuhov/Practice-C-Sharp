using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте структуру с именем - Notebook.
Поля структуры: модель, производитель, цена.
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран
*/
namespace _01Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Experia III", "Lenovo", 26_000);
            Notebook notebook2 = new Notebook("ThinkPad", "IBM", 19_500);
            Console.WriteLine(notebook1.ToString());
            Console.WriteLine(notebook2.ToString());
        }
    }

    struct Notebook
    {
        string model;
        string brand;
        decimal price;

        public Notebook(string _model, string _brand, decimal _price)
        {
            model = _model;
            brand = _brand;
            price = _price;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} price - {2}", brand, model, price);
        }
    }
}
