using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string appartment;


        // существуют различные особенности названий вроде буквы в номере дома, номера корпуса, и т.д.
        // Почтовый индекс в разных странах имеет разный формат


        public string PostIndex
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Appartment
        {
            get
            {
                return appartment;
            }
            set
            {
                appartment = value;
            }
        }

        public Address()
        {
            index = "";
            country="";
            city="";
            street="";
            house="";
            appartment = "";
        }
        public Address(string inputpostindex, string inputcountry, string inputcity, string inputstreet, string inputhouse, string inputppartment)
        {
            PostIndex=inputpostindex;
            Country = inputcountry;
            City = inputcity;
            Street = inputstreet;
            House = inputhouse;
            Appartment = inputppartment;
        }

        public override string ToString()
        {
            string temporaryStringContainer = PostIndex + ", " + Country + ", " + City + ", ул. " + Street + " " + house + ", кв" + Appartment;
            return temporaryStringContainer;
        }

    }
}
