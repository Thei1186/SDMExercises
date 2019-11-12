using System;
using System.IO;
using SDMOpgaver;
using Xunit;

namespace SDMBusExerciseTest
{
    public class BusCompanyTest
    {
        [Theory]
        //Below 100km test cases
        [InlineData(10,1, (1 * 3.20 + 130))]
        [InlineData(11, 45, (45 * 3.20 + 130))]
        [InlineData(50,99, (99 * 3.20 + 130))]

        //Above 100km below 500km and less than 12 passenger test cases
        [InlineData(11,100, (100 * 2.75 + 130))]
        [InlineData(5, 250, (250 * 2.75 + 130))]
        [InlineData(2, 499, (499 * 2.75 + 130))]

        //Above 100km below 500km and more than 12 passenger test cases
        [InlineData(12, 100, (100 * 3 + 130))]
        [InlineData(16, 250, (250 * 3 + 130))]
        [InlineData(20, 499, (499 * 3 + 130))]

        //Above 500km
        [InlineData(11, 500, (500 * 2.25 + 130))]
        [InlineData(22, 750, (750 * 2.25 + 130))]
        public void TestTotalPrice(int noOfPassengers, int kilometer, double expected)
        {
            Exercise bTest = new Exercise();
            var totalCost = bTest.TotalCost(noOfPassengers, kilometer);
            Assert.Equal(expected, totalCost);
        }

        [Theory]
        [InlineData(11, -1)]
        [InlineData(-1, 100)]
        [InlineData(1, 1)]
        public void TestIfIncorrectInput(int noOfPassengers, int kilometer)
        {
            Exercise bTest = new Exercise();
            Assert.Throws<InvalidDataException>(() => bTest.TotalCost(noOfPassengers, kilometer));
        }
    }
}
