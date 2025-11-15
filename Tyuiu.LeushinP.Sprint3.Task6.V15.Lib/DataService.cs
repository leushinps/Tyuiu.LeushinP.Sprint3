using tyuiu.cources.programming.interfaces.Sprint3;

usinusing tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("Стартовое значение не может быть больше конечного");
            }

            int totalSum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {

                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}