using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("startValue должно <= stopValue");

            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;

                double denom = Math.Cos(x) - x;
                if (Math.Abs(denom) < 1e-12)
                    throw new InvalidOperationException($"Знаменатель равен нулю или слишком мал для x={x}");

                double y = x / denom + 2.5;
                product *= y;
            }

            return product;
        }
    }
}