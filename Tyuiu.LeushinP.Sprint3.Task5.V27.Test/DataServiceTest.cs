using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task5.V27.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task5.V27.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            double expected = -1495.954;

            Assert.AreEqual(expected, res);
        }
    }
}