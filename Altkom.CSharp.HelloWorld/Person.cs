using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.HelloWorld
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get; set; }

        public string EyesColor { get; set; }

        // back field
        private byte? age;

        // Właściwość (property)
        public byte? Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }

           
        }

        //public void SetAge(byte wiek)
        //{
        //    age = wiek;
        //}

        //public byte? GetAge()
        //{
        //    return age;
        //}

        public DateTime Birthday;

        public Person()
        {
        }

        // Konstruktor
        public Person(string imie, string nazwisko)
        {
            firstName = imie;
            
            LastName = nazwisko;
        }

        // Przeciążanie konstruktora
        public Person(string imie, string nazwisko, byte wiek)
        {
            firstName = imie;
            LastName = nazwisko;
            age = wiek;
        }


        public void Display()
        {
            Console.WriteLine($"{firstName} {LastName}");
        }

        public void DoWork()
        {
            Console.WriteLine("working...");
        }

        public decimal Calculate()
        {
            return 100;
        }
    }
}
