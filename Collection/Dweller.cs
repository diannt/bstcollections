using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BST.Collections
{
    public class Dweller
    {
        public Passport passport;
        public string phone;
        public Dweller()
        {
            passport = GeneratePassport();
            phone = GeneratePhone();
        }

        public string Print()
        {
            string t = passport.Print() + " " + phone;
            return t;
        }

        Passport GeneratePassport()
        {
            Passport _passport = new Passport();
            return _passport;
        }

        string GeneratePhone()
        {
           Random random = new Random();
           string _phone = random.Next(1, 100).ToString() + random.Next(100,300).ToString() + random.Next(300, 10000).ToString();
           return _phone;
        }


    }

    public class Passport
    {
        public string name;
        public string secondName;
        public Address registration;
        public BirthDay birthDay;
        public BirthAddress birthAddress;

        public Passport()
        {

            name = GenerateName();
            secondName = GenerateSecondName();
            registration = GenerateAddress();
            birthDay = GenerateBirthDay();
            birthAddress = GenerateBirthAddress();
        }

        public string Print()
        {
            string temp = "";
            temp = name + " " + secondName + " " + registration.Print() + " " + birthDay.Print() + " " + birthAddress.Print();
            return temp;
        }

        string GenerateName()
        {
            string[] names = { "Viktor", "Vitaliy", "Alexander", "Mark", "Bob" };
            Random random = new Random();
            return names[random.Next(0, 4)];
        }

        string GenerateSecondName()
        {
            string[] secondName = { "Andreev", "Bull", "Komarov", "Alexeev", "Korovanskiy" };
            Random random = new Random();
            return secondName[random.Next(0, 4)];
        }

        Address GenerateAddress()
        {
            Address _address = new Address();
            return _address;
        }

        BirthDay GenerateBirthDay()
        {
            BirthDay _birthDay = new BirthDay();
            return _birthDay;
        }

        BirthAddress GenerateBirthAddress()
        {
            BirthAddress _birthAddress = new BirthAddress();
            return _birthAddress;
        }

    }

    public class BirthDay
    {
        public int day;
        public int month;
        public int year;

        public BirthDay()
        {
            int _day =0, _month =0, _year=0;
            GenerateDate(ref _day,ref _month,ref _year);
            day = _day;
            month = _month;
            year = _year;
        }

        private void GenerateDate(ref int _d, ref int _m, ref int _y)
        {
            Random random = new Random();
            _d = random.Next(1, 28);
            _m = random.Next(1, 12);
            _y = random.Next(1970, 2000);
        }

        public string Print()
        {
            string temp = "";
            temp = Convert.ToString(day) + " " + Convert.ToString(month) + " " + Convert.ToString(year);
            return temp;
        }
    }

    public class Address
    {
        public string city;
        public string street;
        public int homenumber;

        public Address()
        {
            string _city = "", _street = "";
            int _homenumber=0;

            GenerateAddress(ref _city,ref _street,ref _homenumber);
            city = _city;
            street = _street;
            homenumber = _homenumber;
        }

        private void GenerateAddress(ref string c, ref string s, ref int h)
        {
            string[] cities = {"Moscow","Novosibirsk","Petersburg","Krigopol","London"};
            string[] streets = {"Jarigina", "Dnepropetrovskaya", "Lenina", "Kopernika", "Snowli"};
            Random random = new Random();

            c = cities[random.Next(1, 4)];
            s = streets[random.Next(1, 4)];
        }
        public string Print()
        {
            string temp = "";
            temp = city + " " + street + " " + Convert.ToString(homenumber);
            return temp;
        }
    }

    public class BirthAddress
    {
        public string city;
        public string bornPlace;

        public BirthAddress()
        {
            string _city="", _bornPlace="";

            GenerateBirthAddress(ref _city, ref _bornPlace);
            city = _city;
            bornPlace = _bornPlace;
        }

        private void GenerateBirthAddress(ref string c, ref string b)
        {
            string[] cities = {"Vladivostok", "Kettler", "Monpassan", "Budapesht", "Chernigov"};
            Random random = new Random();

            c = cities[random.Next(0, 4)];
            b = "№"+random.Next(1,5000);
        }
        public string Print()
        {
            string temp = "";
            temp = city + " " + bornPlace;
            return temp;
        }
    }
}
