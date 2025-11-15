using System;
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

            int x = 2;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;

            double result = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);
            double wait = 91.524;

            Assert.AreEqual(wait, result, 0.001, "Сумма сумм ряда вычислена неверно");
        }

        [Test]
        public void GetSumSumSeriesWithDifferentRanges()
        {
            DataService ds = new DataService();

            int x = 2;
            int start1 = 1;
            int stop1 = 1;
            int start2 = 1;
            int stop2 = 1;

            double result = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);


            double expected = (4 * Math.Cos(1) + 1) / (Math.Cos(1) + 2);
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001, "Неверный расчет для одного элемента");
        }

        [Test]
        public void GetSumSumSeriesWithZeroDenominator()
        {
            DataService ds = new DataService();

            int x = -1;
            int start1 = 1;
            int stop1 = 1;
            int start2 = 1;
            int stop2 = 1;

            Assert.DoesNotThrow(() => ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
        }

        [Test]
        public void GetSumSumSeriesRangeValidation()
        {
            DataService ds = new DataService();

            Assert.Throws<ArgumentException>(() =>
                ds.GetSumSumSeries(2, 5, 1, 1, 1));
        }
    }
}