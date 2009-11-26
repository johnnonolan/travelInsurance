using System;
using NUnit.Framework;
namespace travelInsurance
{
    [TestFixture]
    public class AgeModifierTests
    {
        [TestCase(18,1.2)]
        [TestCase(19,1.0)]
        [TestCase(46,1.2)]
        public void GetRating_18Years_ReturnRating(int age, double expected)
        {
            AgeModifer ageModifier = new AgeModifer();
            var modifier = ageModifier.GetRating(age);
            Assert.AreEqual(expected,modifier);

        }


    }

    public class AgeModifer
    {
        public double GetRating(int age)
        {
            if(age < 19)
            return 1.2;

            if (age > 45 && age < 55)
                return 1.2;

            return 1.0;
        }
    }
}
