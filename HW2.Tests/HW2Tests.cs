using NUnit.Framework;

namespace HW2.Tests
{
    public class HW2Tests
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, -1, 4)]
        [TestCase(-1, -1, 3)]
        [TestCase(-1, 1, 2)]
        [TestCase(0, 1, 12)]
        [TestCase(0, 0, 1234)]
        public void GetFourthOfPointTest(double pointX, double pointY, double expected)
        {
            //arrange
            //act
            double actual = EntryPoint.HW2.GetFourthOfPoint(pointX, pointY);
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}