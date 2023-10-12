using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolVA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d);
            res[1] = (a > d) & (d < b);
            res[2] = (d > c) || (b > a);
            res[3] = (c > a) && (b > c);
            res[4] = !(!res[0]);
            res[5] = (d + 1000 > b) ^ (d < a);

            return res;
        }
    }
}
