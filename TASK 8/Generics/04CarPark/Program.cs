using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс CarCollection<T>. 
Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин 
с названием машины и года ее выпуска, индексатор для получения значения элемента по указанному индексу 
и свойство только для чтения для получения общего количества элементов.
Создайте метод удаления всех машин автопарка.
 
*/
namespace _04CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> garage = new CarCollection<Car>();
            garage.Add(new Car("ZAZ", 1973));
            garage.Add(new Car("Rolls Roys", 1972));
            Console.WriteLine(garage.GetByIndex(1).ToString());
            garage.ClearCars();
            Console.WriteLine(garage.GetCount());            
        }
    }

    public class CarCollection<T> where T : Car
    {
        T[] cars = null;
        int counter = 0;

        public void Add(T newItem)
        {
            counter++;
            Array.Resize(ref cars, counter);
            cars[counter - 1] = newItem;
        }

        public T GetByIndex(int index)
        {           
            if (index < 0) return cars[0];
            if (index < counter)
            {
                return cars[index];
            }
            else return cars[counter - 1];
        }

        public int GetCount()
        {
            return counter;
        }

        public void ClearCars()
        {
            cars = null;
            counter = 0;
        }
    }

    public class Car
    {
        string modelName;
        int productionYear; 
        
        public Car(string _modelName, int _productionYear)
        {
            modelName = _modelName;
            productionYear = _productionYear;
        }

        public override string ToString()
        {
            return "Модель:" + modelName + " Год выпуска: " + productionYear;
        }
    }
}
