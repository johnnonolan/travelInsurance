namespace travelInsurance
{
    public static class DoubleExtensions
    {
        public static bool InRange(this int value, int min, int max)
        {
            return (value >= min && value <= max);
        }
    }
}
