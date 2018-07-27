using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Employee
{
    class Employee
    {
        string name;
        string surname;

        public Position position { get; set; }
        public int Experience { get; set; } = -1;

        public Employee(string _name, string _surname)
        {
            this.name = _name;
            this.surname = _surname;
        }

        private decimal GetSalary()
        {
            decimal salary = 0;
            if(this.position!=null && this.Experience != -1)
            {
                salary = Settings.BASE_SALARY * this.position.salary_coef +
                         (this.Experience * Settings.BASE_SALARY * Settings.EXPERIENCE_COEF);
            }
            return salary;
        }

        private decimal GetTax()
        {
            return GetSalary() * Settings.TAX_RATE;
        }

        public override string ToString()
        {
            return System.String.Format("{0} {1}\nPosition: {2}\nMonthly wage - {3:F}, tax - {4:F}",
                name, surname, position.ToString(), GetSalary(), GetTax());
        }

    }
}
