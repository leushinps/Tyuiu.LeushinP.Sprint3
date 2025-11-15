using System;
using Tyuiu.LeushinP.Sprint3.Task5.V27.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму сумм ряда по формуле при x=2                            *");
            Console.WriteLine("* с диапазонами i=[1,3] и k=[1,10]                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага i = {start1}");
            Console.WriteLine($"Конец шага i = {stop1}");
            Console.WriteLine($"Старт шага k = {start2}");
            Console.WriteLine($"Конец шага k = {stop2}");

            try
            {
                double result = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Сумма сумм ряда = {result}");
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