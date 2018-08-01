using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
Написать программу, выполняющую следующие действия:
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
*/

namespace _02Train
{
    class Program
    {
        const int NUMBER_OF_TRAINS = 8;

        static void Main(string[] args)
        {
            //Для упорядоченного добавления поездов можно использовать два подхода:

            //Либо - SortedDictionary, но он медленный
            SortedDictionary<int, Train> listOfTrain = new SortedDictionary<int, Train>();

            //Либо массив, для которого дописать расширяющий метод и для структуры Train - реализовать
            //интерфейс IComparable
            Train[] trains = new Train[NUMBER_OF_TRAINS];
            
            Train train1 = new Train(55, "Киев", TimeSpan.FromHours(23.05));
            Train train2 = new Train(44, "Мариуполь", TimeSpan.FromHours(01.44));
            Train train3 = new Train(99, "Львов", TimeSpan.FromHours(16.00));
            Train train4 = new Train(149, "Черновцы", TimeSpan.FromHours(16.00));
            Train train5 = new Train(1, "Москва", TimeSpan.FromHours(16.00));
            Train train6 = new Train(102, "Одесса", TimeSpan.FromHours(16.00));
            Train train7 = new Train(67, "Ивано-Франковск", TimeSpan.FromHours(16.00));
            Train train8 = new Train(41, "Житомир", TimeSpan.FromHours(16.00));
            Train train9 = new Train(202, "Сумы", TimeSpan.FromHours(16.00));

            trains.InsertTrain(train1);
            trains.InsertTrain(train2);
            trains.InsertTrain(train3);
            trains.InsertTrain(train4);
            trains.InsertTrain(train5);
            trains.InsertTrain(train6);
            trains.InsertTrain(train7);
            trains.InsertTrain(train8);
            trains.InsertTrain(train9);

            foreach (Train train in trains)
            {
                Console.WriteLine(train.ToString());
            }            
        }

        public struct Train : IComparable<Train>
        {
            public int number;
            string destination;
            TimeSpan departure;

            public Train(int n, string d, TimeSpan dep)
            {
                number = n;
                destination = d;
                departure = dep;
            }

            public int CompareTo(Train anotherTrain)
            {
                if (this.number < anotherTrain.number) return -1;
                else if ((this.number > anotherTrain.number)) return 1;
                else return 0;
            }           

            public override string ToString()
            {
                return String.Format("{0} {1} {2}", number, destination, departure.ToString());
            }
        }        
    }
    static class Extensions
    {
        /// <summary>
        /// Метод расширения для массива поездов. Вставит новый поезд на нужную позицию по номеру
        /// </summary>
        /// <param name="listOfTrains"></param>
        /// <param name="train">экземпляр нового поезда</param>
        /// <returns>вернет список поездов</returns>
        public static Program.Train[] InsertTrain(this Program.Train[] listOfTrains, Program.Train train)
        {
            //Частный случай - массив уже полностью заполнен.
            //Если да, то возвращаем массив без изменений
            bool isFullArray = true;
            foreach(Program.Train item in listOfTrains)
            {
                if (item.number == 0) { isFullArray = false; break; }
            }
            if (isFullArray) return listOfTrains;

            //Частный случай - массив поездов пуст. Добавляем на нулевую позицию
            if (listOfTrains[0].number == 0) { listOfTrains[0] = train; return listOfTrains; }

            //Идет по массиву пока номер нового поезда больше, чем существующих
            //или доходим до пустого элемента списка
            int i = 0;
            while (listOfTrains[i].CompareTo(train) == -1 && listOfTrains[i].number != 0)
            {
                i++;
            }

            //Переписываем элементы массива с конца до найденной позиции
            for(int j = listOfTrains.Length - 1; j > i; j--)
            {
                listOfTrains[j] = listOfTrains[j - 1];
            }

            //Вставляем новый поезд
            listOfTrains[i] = train;

            return listOfTrains;
        }
    }
}
