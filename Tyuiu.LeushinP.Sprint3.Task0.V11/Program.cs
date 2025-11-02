
using Tyuiu.LeushinP.Sprint2.Task0.V11.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла For                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая  вычисляет сумму         *");
            Console.WriteLine("* ряда по формуле, при n = 5                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"X == Y : {result[0]}");
            Console.WriteLine($"X != Y : {result[1]}");
            Console.WriteLine($"X <  Y : {result[2]}");
            Console.WriteLine($"X >  Y : {result[3]}");
            Console.WriteLine($"X <= Y : {result[4]}");
            Console.WriteLine($"X >= Y : {result[5]}");

            Console.WriteLine("Для завершения нажмите любую клавишу...                                    ");
            Console.ReadKey();
        }
    }
}