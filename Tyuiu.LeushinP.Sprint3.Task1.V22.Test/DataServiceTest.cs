using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task1.V22.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task1.V22.Test
{
    [TestFixture]
        public class DataServiceTest
        {
            [Test]
            public void CheckGetSumSeries()
            {
                DataService ds = new DataService();
                var res = ds.GetSumSeries(1.5, 1, 20);
                Assert.AreEqual(res, 3550.301);

            }
        }
    }