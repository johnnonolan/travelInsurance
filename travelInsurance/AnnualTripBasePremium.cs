using System;

namespace travelInsurance
{
    public class AnnualTripBasePremium : BasePremium
    {
        public override int GetPremium()
        {
            return 80;
        }
    }
}