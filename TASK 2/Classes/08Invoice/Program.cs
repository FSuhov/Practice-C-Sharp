using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider которые должны быть
проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего
изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. 
*/

namespace _08Invoice
{
    class Program
    {
        public static Invoice[] invoices = new Invoice[3];
        public const decimal VAT = 0.2m;
        public const string delimiter = "+================================+";

        static void Main(string[] args)
        {
            init();
            foreach(Invoice invoice in invoices)
            {
                Console.WriteLine(delimiter);
                Console.WriteLine(invoice.ToString());
            }
        }

        

        public static void init()
        {
            invoices[0] = new Invoice(1001, "Microsoft", "ЮЖМАШ");
            invoices[1] = new Invoice(1002, "Apple", "Uber");
            invoices[2] = new Invoice(1003, "HP", "ЧП Кузькин");
            invoices[0].SetArticle("OS Windows 10");
            invoices[0].SetQuantity(55);
            invoices[0].SetPrice(3200);
            invoices[1].SetArticle("iPhone 6S");
            invoices[1].SetQuantity(99);
            invoices[1].SetPrice(22100);
            invoices[2].SetArticle("Printer HP SuperPrint 9G");
            invoices[2].SetQuantity(1);
            invoices[2].SetPrice(3500);
        }
    }


    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        private string article;
        private int quantity;
        private decimal price;

        public Invoice(int _account, string _provider, string _customer)
        {
            account = _account;
            customer = _customer;
            provider = _provider;
        }

        public void SetArticle (string _article)
        {
            this.article = _article;
        }

        public void SetQuantity(int _quantity)
        {
            this.quantity = _quantity;
        }

        public void SetPrice(decimal _price)
        {
            this.price = _price;
        }

        public decimal GetSumNoVAT()
        {
            return price * quantity;
        }

        public decimal GetSumWithVAT()
        {
            return GetSumNoVAT() + GetSumNoVAT() * Program.VAT;
        }

        public override string ToString()
        {
            return System.String.Format("Поставщик: {0} || Покупатель: {1}\n{2} - {3} штук\nСумма без НДС: {4}\nСумма с НДС: {5}",
                provider, customer, article, quantity, GetSumNoVAT(), GetSumWithVAT());
        }
    }    
}
