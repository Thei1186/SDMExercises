using System.IO;

namespace SDMOpgaver
{
    public class LaMarmotte
    {
        public bool IsGoldTime(int age, int seconds)
        {
            if (age < 18)
            {
                throw new InvalidDataException("Too young to bicycle, get older scrub");
            }
            else if (age >= 18 && age <= 29 && seconds <= 27108)
            {
                return true;
            }

            else if(age >= 30 && age <= 39 && seconds <= 29268)
            {
                return true;
            }

            return false;
        }
    }
}