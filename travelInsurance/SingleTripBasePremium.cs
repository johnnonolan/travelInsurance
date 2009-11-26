using System;

namespace travelInsurance
{
    public class SingleTripBasePremium : BasePremium
    {
        public override double GetPremium()
        {
            return 20;
        }
    }
}