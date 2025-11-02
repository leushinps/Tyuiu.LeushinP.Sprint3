using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task0.V11.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task0.V11.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCompareOperations_WhenXLessThanY()
        {
            DataService ds = new DataService();
            bool[] expected = { false, true, true, false, true, false };
            bool[] result = ds.GetCompareOperations(3, 5);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidCompareOperations_WhenXEqualY()
        {
            DataService ds = new DataService();
            bool[] expected = { true, false, false, false, true, true };
            bool[] result = ds.GetCompareOperations(5, 5);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidCompareOperations_WhenXGreaterThanY()
        {
            DataService ds = new DataService();
            bool[] expected = { false, true, false, true, false, true };
            bool[] result = ds.GetCompareOperations(8, 4);

            Assert.AreEqual(expected, result);
        }
    }
}