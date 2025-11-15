using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {

                if (3 * x + 12 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {

                    double numerator = 2 * Math.PI * x;
                    double denominator = 3 * x + 12;
                    double term1 = numerator / denominator;
                    double term2 = Math.Cos(x);
                    double term3 = 14 * x; 

                    valueArray[count] = Math.Round(term1 + term2 - term3, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}