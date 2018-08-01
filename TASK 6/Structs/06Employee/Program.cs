using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за
месяц.
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать
или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена
премия*/

namespace _06Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accountant.AskForBonus(Position.ASSISTANT, 160));
            Console.WriteLine(Accountant.AskForBonus(Position.SALES_MANAGER, 180));
        }

        
    }

    enum Position
    {
        SALES_MANAGER = 190,
        MARKETING_DIRECTOR = 210,
        BOOKKEEPER = 170,
        ASSISTANT = 150
    }

    class Accountant
    {
        public static bool AskForBonus(Position worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}
