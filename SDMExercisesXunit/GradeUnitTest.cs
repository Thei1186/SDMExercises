using System;
using System.IO;
using SDMOpgaver;
using Xunit;
using Xunit.Sdk;

namespace SDMExercisesXunit
{
    public class GradeUnitTest
    {
        [Theory]
        [InlineData(0, -3)]
        [InlineData(1, -3)]
        [InlineData(6, 0)]
        [InlineData(7, 0)]
        [InlineData(50, 2)]
        [InlineData(51, 2)]
        [InlineData(60, 4)]
        [InlineData(61, 4)]
        [InlineData(80, 7)]
        [InlineData(81, 7)]
        [InlineData(85, 10)]
        [InlineData(86, 10)]
        [InlineData(95, 12)]
        [InlineData(100, 12)]
        public void TestIfValid(int percentage, int expected)
        {
        Exercise e1 = new Exercise();
        var result = e1.ToGrade(percentage);
        Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        [InlineData(500)]
        public void TestIfInvalid(int num)
        {
            var e1 = new Exercise();
            Assert.Throws<InvalidDataException>(() => e1.ToGrade(num));
        }
    }
}
