using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Создать класс с именем Address.
* В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого поля,
* создать свойство с двумя методами доступа.
* Создать экземпляр класса Address.
* В поля экземпляра записать информацию о почтовом адресе.
* Выведите на экран значения полей, описывающих адрес.
*/

namespace _01Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "95014";
            address.Country = "USA";
            address.City = "Cupertino";
            address.Street = "Infinite Loop";
            address.House = "1";
            address.Apartment = "1A";

            Console.WriteLine(address.ToString());
        }
    }
}
