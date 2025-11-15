using System;
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task7.V5.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task7.V5.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);


            Assert.AreEqual(11, result.Length, "Длина массива не соответствует ожидаемой");


            Assert.AreEqual(0, result[1], 0.001, "При x = -4 должно быть 0");

            foreach (double value in result)
            {
                string stringValue = value.ToString("F2");
                double roundedValue = double.Parse(stringValue);
                Assert.AreEqual(roundedValue, value, 0.001, $"Значение {value} не округлено до 2 знаков");
            }
        }

        [Test]
        public void GetMassFunctionDivisionByZero()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = -3;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(0, result[1], 0.001, "При делении на ноль должно возвращаться 0");
        }

        [Test]
        public void GetMassFunctionSingleValue()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double expected = Math.Round(-1.0, 2);

            Assert.AreEqual(1, result.Length, "Должен быть один элемент");
            Assert.AreEqual(expected, result[0], 0.001, "Неверное значение для x = 0");
        }

        [Test]
        public void GetMassFunctionRounding()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double[] result = ds.GetMassFunction(startValue, stopValue);


            double value = result[0];
            double roundedValue = Math.Round(value, 2);

            Assert.AreEqual(roundedValue, value, 0.001, "Значение не округлено до 2 знаков после запятой");
        }

        [Test]
        public void GetMassFunctionRange()
        {
            DataService ds = new DataService();

            int startValue = -2;
            int stopValue = 2;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(5, result.Length, "Неверное количество элементов в массиве");
        }
    }
}