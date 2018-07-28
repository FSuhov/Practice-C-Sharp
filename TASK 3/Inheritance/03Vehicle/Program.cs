using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

/*
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/

namespace _03Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles =
            {
                new Plane(Utils.coords[0], 15_000_000, 1240, 2004, 9500, 44),
                new Car(Utils.coords[1], 24_000, 170, 2014),
                new Ship(Utils.coords[2], 9_500_000, 45, 1990, 210, "Athens")
            };

            foreach(Vehicle instance in vehicles)
            {
                Console.WriteLine(Utils.DELIMITER);
                Console.WriteLine(instance.ToString());
            }
        }
    }

    abstract class Vehicle
    {
        public GeoCoordinate Coords { get; set; }
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public int ProductionYear { get; set; }

        public Vehicle (GeoCoordinate _coords, decimal _price, double _speed, int _year)
        {
            this.Coords = _coords;
            this.Price = _price;
            this.Speed = _speed;
            this.ProductionYear = _year;
        }

        public override string ToString()
        {
            return this.GetType() + System.String.Format("\nCoordinates: lat {0}, long {1}\nPrice: {2} | Speed: {3} | Year: {4}", 
                                                            Coords.Latitude, Coords.Longitude, Price, Speed, ProductionYear);
        }
    }

    class Plane : Vehicle
    {   
        public int Altitude { get; set; }
        public int Capacity { get; set; }        

        public Plane(GeoCoordinate _coords, decimal _price, double _speed, int _year, int _altitude, int _capacity) :
                    base(_coords, _price, _speed, _year)
        {
            this.Altitude = _altitude;
            this.Capacity = _capacity;
        }

        public override string ToString()
        {
            return base.ToString() + System.String.Format("\nAltitude: {0} | Capacity: {1}", Altitude, Capacity);
        }
    }

    class Car : Vehicle
    {
        public Car(GeoCoordinate _coords, decimal _price, double _speed, int _year) :
            base(_coords, _price, _speed, _year) { }
    }

    class Ship : Vehicle
    {        
        public int Capacity { get; set; }
        public string HomePort { get; set; }

        public Ship(GeoCoordinate _coords, decimal _price, double _speed, int _year, int _capacity, string _port) :
                    base(_coords, _price, _speed, _year)
        {
            this.HomePort = _port;
            this.Capacity = _capacity;
        }

        public override string ToString()
        {
            return base.ToString() + System.String.Format("\nHome Port: {0} | Capacity: {1}", HomePort, Capacity);
        }
    }

    static class Utils
    {
        public static GeoCoordinate[] coords =
        {
            new GeoCoordinate(77.2167, -28.6667),
            new GeoCoordinate(55.1367, 3.6567),
            new GeoCoordinate(30.0000, 31.2859),
            new GeoCoordinate(-12.2167, 44.6667),
            new GeoCoordinate(25.2167, -77.6667),
            new GeoCoordinate(77.2167, -28.6667),
        };

        public const string DELIMITER = "+===============================+";
    }
}
