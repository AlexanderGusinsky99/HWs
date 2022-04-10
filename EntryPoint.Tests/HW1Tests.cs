using NUnit.Framework;

namespace EntryPoint.Test
{
    public class HW1Tests
    {
        [TestCase(1, 1, 1)]
        [TestCase(5, -2, -2)]
        [TestCase(0, 1, 0)]
        public void DivideParamsIntegerTest(double numberA, double numberB, int expected)
        {
            int actual = HW1.DivideParamsInteger(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1, 0)]
        [TestCase(5, -2, 1)]
        [TestCase(0, 1, 0)]
        public void DivideParamsLessTest(double numberA, double numberB, int expected)
        {
            int actual = HW1.DivideParamsLess(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }
    }
}