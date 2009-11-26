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
    }

    public class SexModifier
    {
        private Sex _sex;

        public SexModifier(Sex sex)
        {
            _sex = sex;
        }

        public enum Sex
        {
            Male,
            Female
        } ;

        public double GetRating()
        {
            if(_sex == Sex.Male)
            {
                return 1.2;
            }

            return -1;
        }
    }
}