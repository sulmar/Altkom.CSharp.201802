﻿using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.RentSystem.Calculators
{
    public class CostCalculator : ICostCalculator
    {
        public bool CanCalculate(Rent rent)
        {
            return true;
        }

        public decimal Calculate(Rent rent)
        {
            return rent.Item.PricePerHour * (byte)Math.Ceiling(rent.Duration.Value.TotalHours);
        }
    }

    public class HappyHoursCostCalculator : ICostCalculator
    {
        public bool CanCalculate(Rent rent)
        {
            return rent.ReturnDate.Value.Hour >= 20 &&
                rent.ReturnDate.Value.Hour <= 23;
        }

        public decimal Calculate(Rent rent)
        {            
            return 100;
        }

        public void Get()
        {

        }
    }


    
}
