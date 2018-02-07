using Altkom.CSharp.RentSystem.Models;

namespace Altkom.CSharp.RentSystem.Calculators
{
    // wzorzec fabryki klas
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICostCalculator Create(Rent rent)
        {
            // TODO: add logic
            return new HappyHoursCostCalculator();
        }
    }
}
