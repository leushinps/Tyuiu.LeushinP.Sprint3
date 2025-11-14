using System;
using Tyuiu.LeushinP.Sprint3.Task3.V18.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке:4n5nvf 56 bgy *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string input = "4n5nvf 56 bgy";
            char replaceWith = 'n';

            Console.WriteLine($"Исходная строка: {input}");
            string result = ds.ReplaceNumOnChar(input, replaceWith);
            Console.WriteLine($"Преобразованная строка: {result}");

            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}