using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
namespace _05Anketa
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        private readonly DateTime submitDate;

        public User()
        {
            this.submitDate = DateTime.Today;
        }

        public override string ToString()
        {
            return System.String.Format("{0} {1}, {2} years old\nLogin: {3}\nSumbit Date: {4}", Name, Surname, Age, Login, submitDate.ToString("D"));
        }
    }
}
