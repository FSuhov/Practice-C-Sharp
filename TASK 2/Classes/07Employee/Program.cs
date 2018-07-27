using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать класс Employee.
 * В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
 * инициализирует поля, соответствующие фамилии и имени сотрудника.
 * Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
 * Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и
 * налоговый сбор.
 */

namespace _07Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            init();
            foreach(Employee instance in employees)
            {
                Console.WriteLine(Settings.delimiter);
                Console.WriteLine(instance.ToString());
            }
        }

        public static Employee[] employees = new Employee[4];

        static void init()
        {
            employees[0] = new Employee("Вася", "Пупкин");
            employees[1] = new Employee("Маша", "Попкина");
            employees[2] = new Employee("Петя", "Васечкин");
            employees[3] = new Employee("Жанна", "Пяточкина");
            employees[0].Experience = 0;
            employees[0].position = new Position(Positions.Junior);
            employees[1].Experience = 2;
            employees[1].position = new Position(Positions.Middle);
            employees[2].Experience = 5;
            employees[2].position = new Position(Positions.Senior);
            employees[3].Experience = 10;
            employees[3].position = new Position(Positions.TeamLead);
        }
    }
}
