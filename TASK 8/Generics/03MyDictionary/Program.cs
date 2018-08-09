using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс MyDictionary<TKey,TValue>. 
Реализуйте в простейшем приближении возможность использования его экземпляра 
Минимально требуемый интерфейс взаимодействия с экземпляром, 
должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу 
и свойство только для чтения для получения общего количества пар элементов.
*/
namespace _03MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> myDictionary = new MyDictionary<string, double>();
            myDictionary.Add("iPhone 6S", 18500.00);
            myDictionary.Add("Samsung Galaxy 5", 22499.00);
            myDictionary.Add("iPhone 6S", 19000.00);
            Console.WriteLine(myDictionary.Counter);
            Console.WriteLine(myDictionary.GetKeyByIndex(0));
            Console.WriteLine(myDictionary.GetPairByIndex(1).key);
        }
    }

    class MyDictionary<TKey, TValue> where TKey:IComparable
    {
        private TKey[] keys = null;
        private TValue[] values = null;
        private int counter = 0;

        public int Counter
        {
            get { return this.counter; }
        }

        public void Add(TKey key, TValue value)
        {
            if (!IsKeyExists(key))
            {
                counter++;
                Array.Resize(ref keys, counter);
                Array.Resize(ref values, counter);
                keys[counter - 1] = key;
                values[counter - 1] = value;
            }
            else Console.WriteLine("Key already exists, pair can not be added");
        }

        public TKey GetKeyByIndex(int index)
        {
            if (index < counter)
            {
                return keys[index];
            }
            else return keys[counter - 1];
        }

        public MyPair<TKey, TValue> GetPairByIndex(int index)
        {
            if (index < counter)
            {                
                return new MyPair<TKey, TValue>(keys[index], values[index]);
            }
            else return new MyPair<TKey, TValue>(keys[counter - 1], values[counter - 1]);
        }

        public TValue GetValueByIndex(int index)
        {
            if (index < counter)
            {
                return values[index];
            }
            else return values[counter - 1];
        }

        private bool IsKeyExists(TKey key)
        {
            for(int i = 0; i < counter; i++)
            {
                if (key.CompareTo(keys[i]) == 0) return true;
            }
            return false;
        }
    }

    public struct MyPair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public MyPair(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }
    }
}
