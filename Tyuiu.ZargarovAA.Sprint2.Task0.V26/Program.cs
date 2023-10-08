using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint2.Task0.V26.Lib;

namespace Tyuiu.ZargarovAA.Sprint2.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            int x = 1045;
            int y = 975;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = Console.Title = "Спринт #2| Выполнил: Заргаров А. А. | ИИПб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                           *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");

            Console.WriteLine("* Написать программу сравнивающая x и y                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            //int x;
            //Console.Write("Введите значение X: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //int y;
            //Console.Write("Введите значение Y: ");
            // y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                              *");
            Console.WriteLine("****************************************************************************");
            //Console.WriteLine(ds.GetCompareOperations(x,y));
            //Console.ReadLine();
            for (int i=0; i <6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}