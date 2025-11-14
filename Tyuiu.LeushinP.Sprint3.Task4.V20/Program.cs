using System;
using Tyuiu.LeushinP.Sprint3.Task3.V20.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование оператороов Continue и  break                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
            Console.WriteLine("* значение функции y=x/(cos(x) - x)+2,5                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int from = -5;
            int to = 5;

            try
            {
                double result = ds.Calculate(from, to);
                Console.WriteLine($"Диапазон: x = {from}..{to}, пропустить x = 0");
                Console.WriteLine($"Произведение значений функции = {result:R}");
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