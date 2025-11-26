using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                double expr = (Math.Cos(x) - x) + 2.5;

                if (expr >= 0)
                {
                    double y = Math.Sqrt(expr);
                    res *= y;
                }
            }

            return Math.Round(res, 3);
        }
    }
}