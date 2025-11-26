using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            int k = startValue;
            while (k <= stopValue)
            {
                res += (Math.Pow(value, k) + 1 / 2) * Math.Cos(k);
                k++;

            }
            return Math.Round(res, 3);
        }
    }
}