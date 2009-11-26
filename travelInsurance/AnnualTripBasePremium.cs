using System;

namespace travelInsurance
{
    public class AnnualTripBasePremium : BasePremium
    {
        public override double GetPremium()
        {
            return 80;
        }
    }
}