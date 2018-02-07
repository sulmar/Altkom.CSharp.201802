using Altkom.CSharp.RentSystem.Models;

namespace Altkom.CSharp.RentSystem.Calculators
{
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
