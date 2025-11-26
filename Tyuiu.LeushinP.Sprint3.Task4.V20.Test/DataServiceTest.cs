using System;
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task4.V20.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task4.V20.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            double res = ds.Calculate(startValue, endValue);

            double wait = 0;

            Assert.AreEqual(res, wait);
        }
    }
}