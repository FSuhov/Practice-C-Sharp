using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте анонимный метод, который принимает в качестве аргумента массив делегатов 
 и возвращает среднее арифметическое возвращаемых значений методов 
 сообщенных с делегатами в массиве. Методы, сообщенные с делегатами из массива, 
 возвращают случайное значение типа int. 
 */
namespace _03DelegatesArray
{
    class Program
    {
        const int LENGTH = 5;
        public delegate int RandomNumberDelegate(Random random);
        public delegate double CountAverage(RandomNumberDelegate[] arr);

        static void Main(string[] args)
        {
            CountAverage countAverage = delegate (RandomNumberDelegate[] delArray)
            {
                Random random = new Random();
                int count = delArray.Length;
                int sum = 0;
                for (int i = 0; i < count; i++)
                {
                    delArray[i] = (Random) => Random.Next(100);
                    int x = delArray[i](random);
                    sum += x;
                }
                return sum / count;
            };

            RandomNumberDelegate[] delArray1 = new RandomNumberDelegate[LENGTH];

            double result = countAverage(delArray1);
            Console.WriteLine(result);
        }
    }
}
