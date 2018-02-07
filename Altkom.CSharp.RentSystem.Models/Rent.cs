using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.RentSystem.Models
{
    public class Rent : Base
    {
        public int Id { get; set; }

        public DateTime BeginDate { get; set; }

        public Person Rentee { get; set; }

        public Product Item { get; set; }

        public DateTime? ReturnDate { get; set; }

        public decimal? Cost { get; set; }

        public TimeSpan? Duration
        {
            get
            {
                if (ReturnDate.HasValue)
                {
                    return ReturnDate.Value.Subtract(BeginDate);
                }
                else
                    return null;
            }
        }

        public Rent(Person rentee, Product item)
        {
            this.Rentee = rentee;
            this.Item = item;
            this.BeginDate = DateTime.Now;
        }

        // Hermetyzacja
        public void Return()
        {
            this.ReturnDate = DateTime.Now;
        }

    }
}
