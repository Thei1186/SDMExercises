using System;
using System.IO;

namespace SDMOpgaver
{
    public class Exercise
    {
       public int ToGrade(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new InvalidDataException("Error: Percentage was either below zero or above a hundred");
            }
            else if (percentage >= 0 && percentage <= 5)
            {
                return -3;
            }
            else if (percentage > 5 && percentage <= 49)
            {
                return 0;
            }
            else if (percentage > 49 && percentage <= 59)
            {
                return 2;
            }
            else if (percentage > 59 && percentage <= 79)
            {
                return 4;
            }
            else if (percentage > 79 && percentage <= 84)
            {
                return 7;
            }
            else if (percentage > 84 && percentage <= 94)
            {
                return 10;
            }
            else
            {
                return 12;
            }
            
        }

       public bool IsTeenager(DateTime birthday)
       {
           if (birthday <= DateTime.Now.AddYears(-13) && birthday > DateTime.Now.AddYears(-20))
           {
               return true;
           }
           return false;
       }

       public double TotalCost(int noOfPassengers, int kilometer)
       {
           var initialFee = 130;
           if (noOfPassengers < 0 || kilometer < 0)
           {
               throw new InvalidDataException("The number of passengers or kilometers can't be less than zero");
           }
           if (kilometer < 100)
           {
               return 3.20 * kilometer + initialFee;
           }
           else if (kilometer >= 100 && kilometer < 500 && noOfPassengers < 12)
           {
               return 2.75 * kilometer + initialFee;
           }
           else if (kilometer >= 100 && kilometer < 500 && noOfPassengers >= 12)
           {
               return 3 * kilometer + initialFee;
           }
           else
           {
               return 2.25 * kilometer + initialFee;
           }
       }
    }
}