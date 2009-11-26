using System;

namespace travelInsurance
{
    public class AgeModifer
    {
        public double GetRating(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age Must Be Greater Than or Equal to Zero.");

            if (age.InRange(0, 18) || age.InRange(46, 55))
                return 1.2;

            if (age.InRange(19, 45))
                return 1.0;

            if (age.InRange(56, 65))
                return 1.8;

            if (age.InRange(66, 70))
                return 2.0;
            
            throw new DeclinedException();
        }
    }
}