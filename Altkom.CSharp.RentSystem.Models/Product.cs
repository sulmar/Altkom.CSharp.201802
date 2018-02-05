using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.RentSystem.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerHour { get; set; }
        public ProductType ProductType { get; set; }
    }

    public abstract class Ski : Product
    {
        public byte Size { get; set; }
    }

    public class Biegowe : Ski
    {

    }

    public class Zjazdowe : Ski
    {

    }

    public class Shoes : Product
    {
        public byte Size { get; set; }
    }

    public class Goggles : Product
    {
        public GogglesSize Size { get; set; }

    }

    public enum GogglesSize
    {
        S,
        M,
        L,
        XL,
    }

 


}
