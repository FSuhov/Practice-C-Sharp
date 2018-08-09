using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования 
его экземпляра аналогично экземпляру класса List<T>. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
индексатор для получения значения элемента по указанному индексу 
и свойство только для чтения для получения общего количества элементов.

Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, 
разработанному в домашнем задании 2 для данного урока. 
Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().
*/
namespace _02MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strings = new MyList<string>();
            strings.AddItem("Pushking");
            strings.AddItem("Tolstoy");
            Console.WriteLine(strings.GetItem(1));
            Console.WriteLine(strings.Length);
            string[] str_array = MyListExtensions.GetArray(strings);
            foreach(string item in str_array)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyList<T>
    {
        public List<T> listOfItems = new List<T>();

        public int Length { get { return listOfItems.Count; } }

        public void AddItem(T item)
        {
            listOfItems.Add(item);
        }

        public T GetItem(int index)
        {
            return listOfItems[index];
        }
    }

    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.listOfItems.ToArray();
        }
    }
}
