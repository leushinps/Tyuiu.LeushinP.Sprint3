using System;
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task6.V15.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task6.V15.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 6;
            int stopValue = 15;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 168;

            Assert.AreEqual(wait, result, "Сумма делителей вычислена неверно");
        }

        [Test]
        public void GetSumTheDivisorsSingleNumber()
        {
            DataService ds = new DataService();

            int startValue = 6;
            int stopValue = 6;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int expected = 12;

            Assert.AreEqual(expected, result, "Неверный расчет для одного числа");
        }

        [Test]
        public void GetSumTheDivisorsForPrimeNumber()
        {
            DataService ds = new DataService();

            int startValue = 7;
            int stopValue = 7;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int expected = 8;

            Assert.AreEqual(expected, result, "Неверный расчет для простого числа");
        }

        [Test]
        public void GetSumTheDivisorsRangeValidation()
        {
            DataService ds = new DataService();


            Assert.Throws<ArgumentException>(() =>
                ds.GetSumTheDivisors(15, 6));
        }

        [Test]
        public void GetSumTheDivisorsSmallRange()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 3;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int expected = 8;

            Assert.AreEqual(expected, result, "Неверный расчет для малого диапазона");
        }
    }
}