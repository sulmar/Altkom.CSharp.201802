using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alktom.CSharp.RentSystem.ConsoleClient
{
    public interface IProductsService
    {
        Product Get(string barcode);

        List<Product> GetByPrice(decimal limitPrice);
    }


    public class MockProductsService : IProductsService
    {
        private List<Product> products = new List<Product>();

        public MockProductsService()
        {
            Product product1 = new CrossCountrySki
            {
                Id = 1,
                PricePerHour = 50,
                Name = "Fisher",
                Size = 150,
                BarCode = "05454"
            };

            Product product2 = new Goggles
            {
                Id = 2,
                PricePerHour = 15,
                Name = "Polsport",
                BarCode = "45454"
            };

            Product product3 = new DownHillSki
            {
                Id = 3,
                PricePerHour = 75,
                Name = "Salomon",
                BarCode = "55555"
            };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

        }


        // SQL: SELECT * FROM dbo.Products WHERE barcode = '056855'

        //public Product Get(string barcode)
        //{
        //    foreach (Product item in products)
        //    {
        //        if (item.BarCode == barcode)
        //        {
        //            return item;
        //        }
        //    }

        //    return null;
        //}

        // SQL: SELECT * FROM dbo.Products WHERE barcode = '056855'
        public Product Get(string barcode)
        {
            Product item = products
                    .Where(p => p.BarCode == barcode)
                    .OrderBy(p => p.Name)
                    .First();


            //Product item = (from product in products
            //                where product.BarCode == barcode
            //                orderby product.Name
            //                select product).SingleOrDefault();

            // Projekcja
            var items = from product in products
                        select new { product.Name, product.PricePerHour };

            return item;
        }

        public List<Product> GetByPrice(decimal limitPrice)
        {
            return products
                .Where(product => product.PricePerHour <= limitPrice)
                .OrderByDescending(product => product.PricePerHour)
                .ThenByDescending(product => product.Name)
                .ThenByDescending(product => product.BarCode)
                .ToList();

            var items = (from product in products
                         where product.PricePerHour <= limitPrice
                         orderby product.PricePerHour descending, product.Name
                         select product).ToList();

        }
    }
}
