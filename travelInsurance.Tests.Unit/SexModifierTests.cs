using NUnit.Framework;

namespace travelInsurance
{
    [TestFixture]
    public class SexModifierTests
    {
        [Test]
        public void GetRating_IsMale_ReturnsCorrectValue()
        {
            SexModifier sexModifier = new SexModifier(SexModifier.Sex.Male);

            Assert.AreEqual(1.2,sexModifier.GetRating());
        }

        [Test]
        public void GetRating_IsFemale_ReturnsZeroPointNine()
        {
            var sexModifer = new SexModifier(SexModifier.Sex.Female);

            Assert.AreEqual(0.9, sexModifer.GetRating());
        }
    }
}