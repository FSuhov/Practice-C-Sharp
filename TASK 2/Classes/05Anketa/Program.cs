using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения
 * анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании
 * экземпляра данного класса) без возможности его дальнейшего изменения.
 * Реализуйте вывод на экран информации о пользователе.
 */

namespace _05Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Enter name");
            user.Name = Console.ReadLine();

            Console.WriteLine("Enter surname");           
            user.Surname = Console.ReadLine();

            user.Age = GetUserAge();

            Console.WriteLine("Enter login");            
            user.Login = Console.ReadLine();

            Console.WriteLine(user.ToString());
        }

        public static int GetUserAge()
        {
            int age = 0;
            while (age <= 0)
            {
                Console.WriteLine("Enter age");
                string strAge = Console.ReadLine();
                int.TryParse(strAge, out age);
            }
            return age;
        }
    }
}
