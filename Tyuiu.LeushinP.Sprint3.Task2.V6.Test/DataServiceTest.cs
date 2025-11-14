using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task2.V6.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task2.V6.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double a = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetMultiplySeries(a, startValue, stopValue);


            double expected = -0.074;

            Assert.AreEqual(expected, result, 0.001, "Произведение ряда вычислено неверно");
        }
    }
}