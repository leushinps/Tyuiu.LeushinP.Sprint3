using System;
using Tyuiu.LeushinP.Sprint3.Task7.V5.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = (2πx)/(3x+12) + cos(x) + 7x - 2                                 *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. При делении на ноль вернуть 0.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");
            Console.WriteLine("Шаг: 1");

            try
            {
                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine("|{0,5}     | {1,8:f2}  |", startValue + i, resultArray[i]);
                }


                Console.WriteLine("Массив значений:");
                Console.Write("[");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i].ToString("F2"));
                    if (i < resultArray.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при вычислении: " + ex.Message);
            }
            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}