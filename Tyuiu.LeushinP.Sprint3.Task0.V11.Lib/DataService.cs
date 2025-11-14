using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += 1.0 / Math.Pow(k, value * 2);
            }

            return sum;
        }
    }
}