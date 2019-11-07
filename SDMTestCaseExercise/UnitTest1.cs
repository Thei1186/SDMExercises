
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMOpgaver;

namespace SDMTestCaseExercise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIs18GoldTime()
        {
            LaMarmotte testMarmotte = new LaMarmotte();

            int age = 18;
            int sec = 27008;
            bool result = testMarmotte.IsGoldTime(age,sec);
            Assert.IsTrue(result, "YOU ARE WROOoONG!");
        }
        
        [TestMethod]
        public void TestIs18NotGoldTime()
        {
            LaMarmotte testMarmotte = new LaMarmotte();

            int age = 18;
            int sec = 29008;
            bool result = testMarmotte.IsGoldTime(age, sec);
            Assert.IsFalse(result, "YOU ARE WROOOONG!");
        }

        [TestMethod]
        public void TestIs30GoldTime()
        {
            LaMarmotte testMarmotte = new LaMarmotte();

            int age = 39;
            int sec = 29268;
            bool result = testMarmotte.IsGoldTime(age, sec);
            Assert.IsTrue(result, "YOU ARE WROOOONG!");
        }

        [TestMethod]
        public void TestIs30NotGoldTime()
        {
            LaMarmotte testMarmotte = new LaMarmotte();

            int age = 39;
            int sec = 39268;
            bool result = testMarmotte.IsGoldTime(age, sec);
            Assert.IsFalse(result, "YOU ARE WROOOONG!");
        }
    }
}
