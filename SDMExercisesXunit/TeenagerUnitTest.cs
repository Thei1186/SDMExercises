using System;
using SDMOpgaver;
using Xunit;

namespace SDMExercisesXunit
{

    public class TeenagerUnitTest
    {

        [Fact]
        public void TestIsNotATeenager()
        {
            Exercise e2 = new Exercise();
            DateTime birthdate = DateTime.Now.AddYears(-12);
            var result = e2.IsTeenager(birthdate);
            Assert.False(result);
        }

        [Fact]
        public void TestIsATeenager()
        {
            Exercise e2 = new Exercise();
            DateTime birthdate = DateTime.Now.AddYears(-13);
            var result = e2.IsTeenager(birthdate);
            Assert.True(result);
        }

        [Fact]
        public void TestIsBarelyATeenager()
        {
            Exercise e2 = new Exercise();
            DateTime birthdate = DateTime.Now.AddYears(-19);
            var result = e2.IsTeenager(birthdate);
            Assert.True(result);
        }

        [Fact]
        public void TestIsAlsoNotTeenager()
        {
            Exercise e2 = new Exercise();
            DateTime birthdate = DateTime.Now.AddYears(-20);
            var result = e2.IsTeenager(birthdate);
            Assert.False(result);
        }

    }
}