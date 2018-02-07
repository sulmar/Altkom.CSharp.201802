﻿using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.RentSystem.Calculators
{
    public interface ICalculatorFactory
    {
        ICostCalculator Create(Rent rent);
    }
}
