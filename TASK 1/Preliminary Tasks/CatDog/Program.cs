using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Task 2
/// Пользователь вводит слово «мяу» или слово «гав» если слово введенное пользователем
///«мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»
/// </summary>
namespace CatDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = chooseAnimal();
            if (animal == Animal.Dog) Console.WriteLine("Погуляй с собакой");
            else Console.WriteLine("Покорми кота");
            
        }

        static Animal chooseAnimal()
        {
            string userInput;
            do
            {
                Console.WriteLine("Enter sound");
                userInput = Console.ReadLine();
            } while (userInput != "Мяу" && userInput != "Гав");
            if (userInput == "Мяу") return Animal.Cat;
            else return Animal.Dog;
        }
    }

    enum Animal
    {
        Cat,
        Dog
    }   
}
