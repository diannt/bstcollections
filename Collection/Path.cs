using System;
using System.Collections.Generic;
using System.Text;

namespace BST.Collections.Collection
{
    public class Path
    {
        private string pathBegin;
        private string pathEnd;
        private int number;
        private Driver driver;
        private Time clTime;

        public Path()
        {
            string _pathBegin="", _pathEnd="";
            int _number=0;

            GeneratePath(ref _pathBegin,ref _pathEnd,ref _number);

            pathBegin = _pathBegin;
            pathEnd = _pathEnd;
            number = _number;
            driver = new Driver();
            clTime = new Time();
        }

        private void GeneratePath(ref string pb, ref string pe,ref int n)
        {
            string[] pbs = {"Kovalevo", "Lodochkino", "Mitishi", "Krasniy", "Studench"};
            string[] pes = {"Sadovaya", "Gavai", "Mirnoe", "Volniy", "Karatuz"};

            Random r = new Random();
            pb = pbs[r.Next(0, 4)];
            pe = pes[r.Next(0, 4)];
            n = r.Next(0, 200);
        }

        public string Read()
        {
            string read = pathBegin + " " + pathEnd + " " + Convert.ToString(number) + " " + driver.Read() + " " +
                          clTime.Read();

            return read;
        }
    }

    public class Driver
    {
        private string name;
        private string lastname;
        private int age;

        public Driver()
        {
            string _name="", _lastname="";
            int _age=0;

            GenerateDriver(ref _name,ref _lastname,ref _age);

            name = _name;
            lastname = _lastname;
            age = _age;
        }

        private void GenerateDriver(ref string n, ref string l, ref int a)
        {
            string[] names = {"Valeriy", "Danil", "Sergey", "Afanasiy", "Petr"};
            string[] lastnames = {"Petrov", "Sidorov", "Filimonov", "Terehin", "Kotov"};

            Random r = new Random();
            n = names[r.Next(0, 4)];
            l = lastnames[r.Next(0, 4)];
            a = r.Next(20, 50);
        }

        public string Read()
        {
            string read = name + " " + lastname + " " + Convert.ToString(age);
            return read;
        }
    }

    public class Time
    {
        private int starthour;
        private int endhour;

        public Time()
        {
            Random r = new Random();
            starthour = r.Next(0, 12);
            endhour = r.Next(starthour, 23);
        }

        public string Read()
        {
            string read = Convert.ToString(starthour) + " " + Convert.ToString(endhour);
            return read;
        }
    }
}
