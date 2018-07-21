using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//All fields of class are strings becouse in some countries index can be mixed text
//containing numbers and letters. Apartment and house number also may contain letters or other symbols

namespace _01Address
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return this.index; }
            set { this.index = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }

        public string House
        {
            get { return this.house; }
            set { this.house = value; }
        }

        public string Apartment
        {
            get { return this.apartment; }
            set { this.apartment = value; }
        }

        public override string ToString()
        {
            return System.String.Format("{0}, {1}/{2},\n{3}\n{4} {5}",
                                        this.street,
                                        this.house,
                                        this.apartment,
                                        this.city,
                                        this.country, this.index);
        }
    }
}
