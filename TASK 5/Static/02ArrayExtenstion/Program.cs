using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать расширение для массива челых чисел сортирующее его по возрастанию
//Расширить программу из задачи 2. Расширение должно принимать bool параметер который задает направление сортировки

namespace _02ArrayExtenstion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] simpleArray = { 4, 8, 2, 999, 44, 554, 1 };
            foreach (int item in simpleArray)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();

            simpleArray.SortAscend();

            foreach(int item in simpleArray)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();

            simpleArray.UserSort(false);
            foreach (int item in simpleArray)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static class IntArrayExtension
    {
        public static int[] SortAscend(this int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static int[] UserSort(this int[] array, bool isAscend)
        {
            if (isAscend)
            {
                Array.Sort(array);
                return array;
            }
            else
            {
                Array.Sort(array);
                Array.Reverse(array);
                return array;
            }
        }
    }
}
