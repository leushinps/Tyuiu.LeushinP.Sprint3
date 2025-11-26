using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 1.5 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}