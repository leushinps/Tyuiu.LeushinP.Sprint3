using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiply = 1;
            int k = startValue;

            do
            {
                double term = value + 1 / Math.Cos(4 * k);
                multiply *= term;
                k++;
            }
            while (k <= stopValue);

            return multiply;
        }
    }
}