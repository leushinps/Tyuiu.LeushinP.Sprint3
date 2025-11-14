using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task0.V11.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task0.V11.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestSumSeries_CorrectCalculation()
        {
            DataService ds = new DataService();

            int n = 5;
            int start = 1;
            int stop = 10;

            double result = ds.GetSumSeries(n, start, stop);


            double expected =
                  1.0
                + 1.0 / 1024
                + 1.0 / 59049
                + 1.0 / 1048576
                + 1.0 / 9765625
                + 1.0 / 60466176
                + 1.0 / 282475249
                + 1.0 / 1073741824
                + 1.0 / 3486784401
                + 1.0 / 10000000000;

            Assert.AreEqual(expected, result, 1e-12);
        }
    }
}