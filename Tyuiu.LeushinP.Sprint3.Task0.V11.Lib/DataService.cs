using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(double x, double y)
        {
            bool[] results = new bool[6];

            results[0] = x == y;   // равно
            results[1] = x != y;   // не равно
            results[2] = x < y;    // меньше
            results[3] = x > y;    // больше
            results[4] = x <= y;   // меньше или равно
            results[5] = x >= y;   // больше или равно

            return results;
        }
    }
}