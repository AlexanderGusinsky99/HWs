using NUnit.Framework;
using EntryPoint;
namespace HW1.Test
{
    public class HW1Tests
    {
        [Test]
        public void DivideParamsIntegerTest()
        {
            int expected = 2;
            int actual = EntryPoint.HW1.DivideParamsInteger(10, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}