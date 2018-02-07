using Alktom.CSharp.RentSystem.DbServices;
using Alktom.CSharp.RentSystem.IServices;
using Altkom.CSharp.RentSystem.Calculators;
using Altkom.CSharp.RentSystem.MockServices;
using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Alktom.CSharp.RentSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RentProductTest();

            GetProductsTest();

            CalculateRentTest();

        }

        private static void GetProductsTest()
        {
            IProductsService productsService = new MockProductsService();
            var items = productsService.GetByPrice(100);

            Console.WriteLine("Znalezione produkty foreach");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} {item.PricePerHour}");
            }

            Console.WriteLine("Znalezione produkty ForEach");
            items.ForEach(item => Console.WriteLine($"{item.Name} {item.PricePerHour}"));
        }

        private static void RentProductTest()
        {
            WriteLine("Witaj w wypożyczalni");

            // 1. Wyswietl "Podaj imie i nazwisko"

            WriteLine("Podaj imię i nazwisko");

            // 2. Odczytaj imie i nazwisko

            string fullname = ReadLine();

            // 3. Wyszukaj klienta
            IPersonsService personsService = new DbPersonsService();
            var person = personsService.GetByName(fullname);

            // 4. Podaj kod kreskowy
            WriteLine("Podaj kod kreskowy");
            string barcode = ReadLine();

            // 5. Wyszukaj produkt
            IProductsService productsService = new MockProductsService();
            var product = productsService.Get(barcode);

            Console.WriteLine(product.Name);

            // 6. Wypożycz

            var rent = new Rent(person, product);

            WriteLine($"Wypożyczył: {rent.Rentee.FirstName} Produkt: {rent.Item.Name} Data: {rent.BeginDate}");
        }

        private static void CalculateRentTest()
        {
            Write("Podaj imię: ");
            string firstName = ReadLine();

            Write("Podaj nazwisko: ");
            string lastName = ReadLine();

            var rentee = new Man();
            rentee.FirstName = firstName;
            rentee.LastName = lastName;

            Product item = new CrossCountrySki
            {
                Id = 1,
                PricePerHour = 50,
                Name = "Fisher",
                Size = 150,
            };

            var rent = new Rent(rentee, item)
            {
                Id = 1,
            };

            // zwrot

            Thread.Sleep(TimeSpan.FromSeconds(1));

            rent.Return();

            ICalculatorFactory calculatorFactory = new CalculatorFactory();

            ICostCalculator calculator = calculatorFactory.Create(rent);
            rent.Cost = calculator.Calculate(rent);
        }
    }
}
