using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZargarovAA.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[,] res =
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 },
                { 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            return Convert.ToBoolean(res[y - 1, x - 1]);

        }
    }
}
