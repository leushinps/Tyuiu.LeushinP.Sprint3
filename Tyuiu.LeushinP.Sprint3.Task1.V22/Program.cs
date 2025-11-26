using System;
using Tyuiu.LeushinP.Sprint3.Task1.V22.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму        *");
            Console.WriteLine("* ряда по формуле, при a=1,5                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double a = 1.5;
            Console.WriteLine("A = " + a);
            Console.Write("Стартовое значение = ");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конечное значение = ");
            int Stop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(a, Start, Stop));

            Console.ReadKey();
        }
    }
}