using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task5.V27.Lib
{
    public class DataService : ISprint3Task5V27
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double denominator = Math.Cos(k) + x;
                    if (Math.Abs(denominator) < 1e-12)
                    {
                        throw new DivideByZeroException($"Знаменатель близок к нулю при x = {x}, k = {k}");
                    }

                    double value = (x * x * Math.Cos(k) + 1) / denominator;
                    totalSum += value;
                }
            }

            return Math.Round(totalSum, 3);
        }
    }
}