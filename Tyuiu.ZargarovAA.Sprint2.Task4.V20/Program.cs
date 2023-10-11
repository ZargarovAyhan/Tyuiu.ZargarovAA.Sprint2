using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint2.Task4.V20.Lib;
namespace Tyuiu.ZargarovAA.Sprint2.Task4.V20
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
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу находящее значнеие функции                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЫЕ:                                                        *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите значение X: ");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            Double y = Convert.ToDouble(Console.ReadLine());
            Double res = ds.Calculate(x,y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadLine();
        }
    }
}