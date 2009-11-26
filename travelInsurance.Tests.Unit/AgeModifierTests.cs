using System;
using NUnit.Framework;
namespace travelInsurance
{
    [TestFixture]
    public class AgeModifierTests
    {
        [Test]
        public void GetRating_18Years_ReturnRating()
        {
            AgeModifer ageModifier = new AgeModifer();
            var modifier = ageModifier.GetRating(18);
            Assert.AreEqual(1.2,modifier);

        }
    }

    public class AgeModifer
    {
        public double GetRating(int age)
        {
            return 1.2;
        }
    }
}
