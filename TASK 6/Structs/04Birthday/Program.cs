using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Реализуйте программу, которая будет принимать от пользователя дату его рождения 
и выводить количество дней до его следующего дня рождения. 
*/

namespace _04Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int day = GetUserDay();
                int month = GetUserMonth();

                try
                {
                    DateTime nextBirthday = GetNextBirthday(month, day);
                    TimeSpan toNextBirthday = (DateTime.Now - DateTime.Now.TimeOfDay) - nextBirthday;
                    Console.WriteLine(toNextBirthday.Days * -1);
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error in date");
                }
            }
        }

        static int GetUserMonth()
        {
            int month = 0;
            while(month <= 0 || month > 12)
            {
                Console.WriteLine("Enter month of birth");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out month);
            }
            return month;
        }

        static int GetUserDay()
        {
            int day = 0;
            while (day <= 0 || day > 31)
            {
                Console.WriteLine("Enter day of birth");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out day);
            }
            return day;
        }

        static bool IsPassedAlready(DateTime datetime)
        {
            return (datetime.CompareTo(DateTime.Now) < 0);
        }

        static DateTime GetNextBirthday(int month, int day)
        {
            if(month==2 && day == 29)
            {
                int year;
                if (DateTime.Now.Month > 2)
                {
                    year = DateTime.Now.Year + 1;
                }
                else year = DateTime.Now.Year;
                while (!DateTime.IsLeapYear(year))
                {
                    year++;
                }
                return new DateTime(year, month, day);

            }
            if (IsPassedAlready(new DateTime(DateTime.Now.Year, month, day)))
            {
                return new DateTime(DateTime.Now.Year + 1, month, day);
            }
            else return new DateTime(DateTime.Now.Year, month, day);
        }
    }
}
