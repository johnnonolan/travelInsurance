using System;

namespace travelInsurance
{
    public class SingleTripBasePremium : BasePremium
    {
        public override int GetPremium()
        {
            return 20;
        }
    }
}