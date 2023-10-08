using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZargarovAA.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < d) | (b == c);

            res[1] = (a == c) & (b < d);
            res[2] = (a < d) || (b == c);
            res[3] = (a == c) && (b < d);
            res[4] = !(a > c);
            res[5] = (a == c) ^ (b > d);

            return res;
        }
    }
}
