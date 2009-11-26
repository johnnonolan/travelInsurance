using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace travelInsurance
{
    [TestFixture]
    public class BasePremiumTests
    {
        [Test]
        public void GetPremium_SingleTrip_Returns20()
        {
            var single = new SingleTripBasePremium();
            Assert.AreEqual(20, single.GetPremium());
        }

        [Test]
        public void GetPremium_AnnualTrip_Returns80()
        {
            var annual = new AnnualTripBasePremium();
            Assert.AreEqual(80, annual.GetPremium());
        }
    }
}
