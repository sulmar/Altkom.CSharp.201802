using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Altkom.CSharp.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new Sender();

            sender.Send("Hello");

            sender.Send(DateTime.Now);




            MethodTest();


            VarTest();


            // camel "wielbladzia"
            int myNumber = 10;

            // Pascalowa

            //HelloWorld();

            //DisplayUser();

            //SplitUser();

            CreatePerson();

            ReadKey();

        }

        private static void MethodTest()
        {

            var user = new Person("Marcin", "Sulecki");

            user.Age = 18;

            user.Display();
        }

        // var - typ określony na podstawie wnioskowania
        private static void VarTest()
        {
            var age = (byte) 99;

            var price = 10.44m;

            var person = new Person("Marcin", "Sulecki");

            //PersonInfo personInfo = new PersonInfo
            //{
            //    lastName = person.lastName,
            //    age = person.age
            //};


            // typ anonimowy
            var personInfo = new
            {
                Imie = person.FirstName,
                Wiek = person.Age
            };

            Console.WriteLine($"{personInfo.Imie} {personInfo.Wiek}");
        }

        private static void CreatePerson()
        {
            Person user = new Person("Marcin", "Sulecki", 18);
            //user.firstName = "Marcin";
            //user.lastName = "Sulecki";
            // user.age = 18;

            Console.WriteLine($"Witaj {user.FirstName} {user.LastName} {user.Age}");

        }

        private static void CreatePerson2()
        {
            // inicjalizator
            Person user = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Age = 18,
            };
        }

        private static void HelloWorld()
        {
            WriteLine("Hello World!");
        }

        private static void SplitUser()
        {
            WriteLine("Podaj imię i nazwisko");

            string fullName = ReadLine();

            char sign = 'A';
            string text = "A";

            string[] names = fullName.Split(' ');

            // Console.WriteLine("Witaj " + names[0] + " " + names[1]);

            WriteLine("Witaj {0} {1}", names[0], names[1]);
        }

     


        static void DisplayUser()
        {
            WriteLine("Podaj imię: ");

            string firstName = ReadLine();

            char initial = firstName.Last();

            WriteLine("Podaj nazwisko: ");

            string lastName = Console.ReadLine();

            // zła praktyka
            // Console.WriteLine("Witaj " + firstName + " " + lastName);

            // Console.WriteLine("Witaj {0} {1}", firstName, lastName);

            // Interpolacja
            WriteLine($"Witaj {firstName} {lastName}");
        }
    }
}
