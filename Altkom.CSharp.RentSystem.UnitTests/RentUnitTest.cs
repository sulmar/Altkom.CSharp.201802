using System;
using Alktom.CSharp.RentSystem.ConsoleClient;
using Alktom.CSharp.RentSystem.DbServices;
using Alktom.CSharp.RentSystem.IServices;
using Altkom.CSharp.RentSystem.MockServices;
using Altkom.CSharp.RentSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.CSharp.RentSystem.UnitTests
{
    [TestClass]
    public class RentUnitTest
    {
        [TestMethod]
        public void CreateRentTest()
        {
            // 1. Dane wejściowe

            string fullname = "Marcin";
            string barcode = "55555";

            // 2. Instraktura

            IPersonsService personsService = new DbPersonsService();
            IProductsService productsService = new MockProductsService();

            // 3. Proces

            var person = personsService.GetByName(fullname);
            var product = productsService.Get(barcode);

            var rent = new Rent(person, product);

            // 4. Sprawdzenie wyników
            Assert.IsNotNull(rent, "Puste wypożyczenie");
            Assert.IsNotNull(rent.Rentee, "Brak osoby");
            Assert.IsNotNull(rent.Item, "Brak produktu");
            Assert.AreEqual(DateTime.Now.Date, rent.BeginDate.Date, "Niepoprawna data");
            Assert.IsFalse(rent.ReturnDate.HasValue, "Data powinna byc pusta");



        }

        [TestMethod]
        public void ReturnTest()
        {
            // 1. Dane wejściowe

            string fullname = "Marcin";
            string barcode = "55555";

            // 2. Instraktura

            IPersonsService personsService = new DbPersonsService();
            IProductsService productsService = new MockProductsService();

            // 3. Proces

            var person = personsService.GetByName(fullname);
            var product = productsService.Get(barcode);

            var rent = new Rent(person, product);

            rent.Return();

            // 4. Sprawdzenie wyników
            Assert.IsNotNull(rent, "Puste wypożyczenie");
            Assert.IsNotNull(rent.Rentee, "Brak osoby");
            Assert.IsNotNull(rent.Item, "Brak produktu");
            Assert.AreEqual(DateTime.Now.Date, rent.BeginDate.Date, "Niepoprawna data");
            Assert.IsFalse(rent.ReturnDate.HasValue, "Data powinna byc pusta");





        }
    }
}
