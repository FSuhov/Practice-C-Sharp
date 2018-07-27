using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и
инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также
программа должна производить конвертацию из указанных валют в гривну.
*/

namespace _06Converter
{
    enum Currencies
    {
        USD = 1,
        EUR,
        RUB,
        UAH
    }

    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        private double usd_result;
        private double eur_result;
        private double rub_result;
        private double uah_result;

        public Converter(double _usd, double _eur, double _rub)
        {
            this.usd = _usd;
            this.eur = _eur;
            this.rub = _rub;
        }

        public void ChangeCurrency (double amount, Currencies currency)
        {            
            switch ((int)currency)
            {
                case 1:
                    FromUSD(amount);
                    break;
                case 2:
                    FromEUR(amount);
                    break;
                case 3:
                    FromRUB(amount);
                    break;
                case 4:
                    FromUAH(amount);
                    break;
                default:
                    break;
            }
        }

        public void FromUSD (double amount)
        {
            usd_result = amount;
            eur_result = amount * (usd / eur);
            rub_result = amount * (usd / rub);
            uah_result = amount * usd;
        }

        public void FromEUR(double amount)
        {
            usd_result = amount * (eur / usd);
            eur_result = amount;
            rub_result = amount * (eur / rub);
            uah_result = amount * eur;
        }

        public void FromRUB(double amount)
        {
            usd_result = amount * (rub / usd);
            eur_result = amount * (rub / eur);
            rub_result = amount;
            uah_result = amount * rub;
        }

        public void FromUAH(double amount)
        {
            usd_result = amount / usd;
            eur_result = amount / eur;
            rub_result = amount / rub;
            uah_result = amount;
        }

        public override string ToString()
        {
            return System.String.Format("USD = {0:F2}\nEUR = {1:F2}\nRUB = {2:F2}\nUAH = {3:F2}", usd_result, eur_result, rub_result, uah_result);
        }


    }
}
