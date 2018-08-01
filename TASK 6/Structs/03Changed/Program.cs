using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса. Измените, значения полей экземпляров на «не изменено», 
а затем вызовите методы ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.
*/

namespace _03Changed
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct;

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            Console.WriteLine("Class before method call: " + myClass.change);
            Console.WriteLine("Struct before method call: " + myStruct.change);


            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("Class after method call: " + myClass.change);
            Console.WriteLine("Struct after method call: " + myStruct.change);
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
}
