using System;
using NUnit.Framework;
namespace travelInsurance
{
    [TestFixture]
    public class AgeModifierTests
    {
        [TestCase(0, 1.2)]
        [TestCase(18,1.2)]
        [TestCase(19,1.0)]
        [TestCase(46,1.2)]
        [TestCase(55,1.2)]
        [TestCase(56,1.8)]
        [TestCase(65,1.8)]
        [TestCase(66,2.0)]
        [TestCase(70,2.0)]
        public void GetRating_ReturnsCorrectRating(int age, double expected)
        {
            AgeModifer ageModifier = new AgeModifer();
            var modifier = ageModifier.GetRating(age);
            Assert.AreEqual(expected,modifier);

        }

        [Test]
        public void GetRating_NegativeOne_ThrowsInvalidArgumentException()
        {
            var age = new AgeModifer();
            Assert.Throws<ArgumentException>(() => age.GetRating(-1));
        }

        [Test]
        public void GetRating_71_ThrowsDeclinedException()
        {
            var age = new AgeModifer();
            Assert.Throws<DeclinedException>(() => age.GetRating(71));
        }
    }
}
