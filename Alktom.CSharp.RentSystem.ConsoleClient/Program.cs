using Altkom.CSharp.RentSystem.Calculators;
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
            WriteLine("Witaj w wypożyczalni");

            IProductsService productsService = new MockProductsService();
            var product = productsService.Get("55555");
            Console.WriteLine(product.Name);


            var items = productsService.GetByPrice(100);

            Console.WriteLine("Znalezione produkty foreach");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} {item.PricePerHour}");
            }

            Console.WriteLine("Znalezione produkty ForEach");
            items.ForEach(item => Console.WriteLine($"{item.Name} {item.PricePerHour}"));





            // RentTest();

        }

        private static void RentTest()
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
