using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Employee
{
    static class Settings
    {
        public const decimal TAX_RATE = 0.2m;
        public const decimal BASE_SALARY = 20_000;
        public const decimal EXPERIENCE_COEF = 0.1m;
        public const string delimiter = "+================================+";
    }

    enum Positions
    {
        Junior = 1,
        Middle,
        Senior,
        TeamLead
    }

    class Position
    {
        Positions position;
        public decimal salary_coef;

        public Position(Positions pos)
        {
            this.position = pos;
            switch ((int)pos)
            {
                case 1:
                    salary_coef = 0.5m;
                    break;
                case 2:
                    salary_coef = 1;
                    break;
                case 3:
                    salary_coef = 1.5m;
                    break;
                case 4:
                    salary_coef = 2;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return position.ToString();
        }
    }
}
