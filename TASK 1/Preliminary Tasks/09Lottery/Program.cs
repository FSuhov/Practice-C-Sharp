using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик. Если
выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8,
пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает
двойную ставку, а если выпало 12 - ставку умноженную на 10. После окончания игры покажите
пользователю, сколько он выиграл.
*/ 

namespace _09Lottery
{
    class Program
    {
        static Random _r = new Random();
        const decimal startCapital = 100.00m;

        static void Main(string[] args)
        {            
            decimal account = startCapital;
            int turn = 0;
            Console.WriteLine("Добро пожаловать в казино \"У Степы\"");
            while(true)
            {
                turn++;
                Console.WriteLine(delimiter);
                Console.WriteLine("Ход {0}, у вас на счету {1} денег", turn, account);
                decimal bet = 0_00;
                do
                {                    
                    Console.WriteLine("Введите ставку или -1 для завершения игры");
                    string userInput = Console.ReadLine();
                    bet = ParseToDecimal(userInput);
                    if (bet == -1) break;
                    else if(bet <= account)
                    {                      
                        Console.WriteLine("Ставка {0} принятя", bet);
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно денег на счету, у вас есть {0} денег", account);
                        bet = 0;
                    }
                } while (bet == 0);

                if (bet == -1) break;

                int dice = _r.Next(13);
                Console.WriteLine("Выпало " + dice);
                if (dice <= 5)
                {
                    account -= bet;
                }
                else if (dice == 12)
                {
                    account += (bet * 10);
                }
                else if (dice >= 9 && dice < 12)
                {
                    account += bet*2;
                }               
                
                if (account <= 0)
                {
                    Console.WriteLine("Проиграны все деньги");
                    break;
                }
            }
            Console.WriteLine(delimiter);
            Console.WriteLine("Сыграно {0} ходов, резльтат {1} денег", turn, (account - startCapital));
            Console.WriteLine("Досвидули...");
        }

        static decimal ParseToDecimal(string str)
        {
            decimal result;
            if (Decimal.TryParse(str, out result) && result > 0)
            {
                return result;
            }
            else return 0;
        }

        const string delimiter = "+=====================================+";
    }
}
