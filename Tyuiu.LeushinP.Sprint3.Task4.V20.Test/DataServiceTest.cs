using System;
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task3.V20.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task3.V20.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void Calculate_MatchesIndependentLoop()
        {
            var ds = new DataService();

            int from = -5;
            int to = 5;

            double expected = 1.0;
            for (int x = from; x <= to; x++)
            {
                if (x == 0) continue;
                double denom = Math.Cos(x) - x;
                if (Math.Abs(denom) < 1e-12)
                    Assert.Fail($"Знаменатель равен нулю или слишком мал x={x} in independent calculation");
                double y = x / denom + 2.5;
                expected *= y;
            }

            double actual = ds.Calculate(from, to);

            Assert.AreEqual(expected, actual, 1e-9, "Значение произведения не совпадает с независимым вычислением");
        }

        [Test]
        public void Calculate_StartGreaterThanStop_Throws()
        {
            var ds = new DataService();
            Assert.Throws<ArgumentException>(() => ds.Calculate(5, -5));
        }

        [Test]
        public void Calculate_SkipsZero()
        {
            var ds = new DataService();

            double full = ds.Calculate(-2, 2);

            double manual = 1.0;
            for (int x = -2; x <= 2; x++)
            {
                if (x == 0) continue;
                double denom = Math.Cos(x) - x;
                if (Math.Abs(denom) < 1e-12) Assert.Fail($"Знаменатель слишком мал для x={x}");
                manual *= x / denom + 2.5;
            }

            Assert.AreEqual(manual, full, 1e-12);
        }
    }
}