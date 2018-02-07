using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alktom.CSharp.RentSystem.IServices
{
    public interface IProductsService
    {
        Product Get(string barcode);

        List<Product> GetByPrice(decimal limitPrice);
    }


   
}
