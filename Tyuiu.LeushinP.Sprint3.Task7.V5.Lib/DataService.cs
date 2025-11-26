using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double zanamen = 3 * x + 12;
                double y;

                if (zanamen == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(((2 * Math.PI * x) / zanamen) + Math.Cos(x) - 14 * x, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}