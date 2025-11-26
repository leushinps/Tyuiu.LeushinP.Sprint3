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
            Console.WriteLine("* Тема: Оператор цикла Foreach                                            *");
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

            string str = "4n5nvf 56 bgy";
            char replaceChr = 'n';
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Заменить на букву: " + replaceChr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговая строка: " + ds.ReplaceNumOnChar(str, replaceChr));

            Console.ReadKey();

        }
    }
}