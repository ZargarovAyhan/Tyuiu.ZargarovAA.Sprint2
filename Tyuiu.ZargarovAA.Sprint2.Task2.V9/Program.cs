using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint2.Task2.V9.Lib;
namespace Tyuiu.ZargarovAA.Sprint2.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = Console.Title = "Спринт #2| Выполнил: Заргаров А. А. | ИИПб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                           *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу проверяющая закрашена ли точка                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЫЕ:                                                        *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                              *");
            Console.WriteLine("****************************************************************************");
            {
                if (res)
                {
                    Console.WriteLine("Точка находится в заштрихованной области");
                }
                else
                {
                    Console.WriteLine("Точка находится в не заштрихованной области");
                }
                Console.ReadKey();
            }

        }
    }
}
