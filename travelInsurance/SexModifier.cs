namespace travelInsurance
{
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
            return (_sex == Sex.Male) ? 1.2 : 0.9;
        }
    }
}