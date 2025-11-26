using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task5.V27.Lib
{
    public class DataService : ISprint3Task5V27
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            for (int t = startValue1; t <= stopValue1; t++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += Math.Pow(k, t) / Math.Cos(k);
                }
            }

            return Math.Round(sumSeries, 3);
        }

        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            throw new NotImplementedException();
        }
    }
}