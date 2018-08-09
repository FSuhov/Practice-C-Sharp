using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(), 
 который будет порождать экземпляры типа, указанного в качестве параметра типа 
 (указателя места заполнения типом – Т).
*/

/*
 * Возможные ограничители для типа (constrains):
 * where T:Icomparable (implements some interface
 * where T: Product (является типом класса или его наследников
 * where T:struct (явлется типом значений)
 * where T:class (является ссылочным типом)
 * where T:new() - имеет конструктор по умолчанию
 */
namespace _01Fabric
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = MyClass<int>.FactoryMethod();
            Console.WriteLine(x);
            var z = MyClass<double>.FactoryMethod();
            Console.WriteLine(z);
            string y = MyClass<string>.FactoryMethod();
            Console.WriteLine(y);
            Book book = MyClass<Book>.FactoryMethod();
            Console.WriteLine(book.ToString());

            //тестирование второго варианта
            var a = MyClass1<int>.FactoryMethod();
            //var b = MyClass1<string>.FactoryMethod();//нескомпилируется
            var c = MyClass1<Book>.FactoryMethod();
            Console.WriteLine("Тестирование второго варианта решения");
            Console.WriteLine(a);
            Console.WriteLine(c.ToString());


        }

        //Вариант 1:
        class MyClass<T>
        {
            public static T FactoryMethod()
            {
                try
                {
                    var instance =  Activator.CreateInstance<T>();
                    return instance;
                }
                catch(MissingMethodException ex)
                {
                    Console.WriteLine("Для данного типа нет конструктора без параметров");
                    return default(T);
                }                
            }
        }

        //Вариант 2:
        class MyClass1<T> where T : new()
        {
            public static T FactoryMethod()
            {
                return new T();
            }
        }

        class Book
        {
            string author;
            string title;

            public Book()
            {
                author = "Pushkin ";
                title = " Онегин";
            }

            public override string ToString()
            {
                return author + title;
            }
        }
    }
}
