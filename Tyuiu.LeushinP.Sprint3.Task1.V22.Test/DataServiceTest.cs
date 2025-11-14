using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task1.V22.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task1.V22.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 1.5;
            int startValue = 1;
            int stopValue = 20;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            double expected = -0.189;

            Assert.AreEqual(expected, result, 0.001, "Сумма ряда вычислена неверно");
        }
    }
}