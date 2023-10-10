using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint2.Task1.V21.Lib;

namespace Tyuiu.ZargarovAA.Sprint2.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations( a, b,  c, d);
            Console.Title = Console.Title = "Спринт #2| Выполнил: Заргаров А. А. | ИИПб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                           *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #21                                                              *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу сравнивающая числа                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЫЕ:                                                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
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
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
