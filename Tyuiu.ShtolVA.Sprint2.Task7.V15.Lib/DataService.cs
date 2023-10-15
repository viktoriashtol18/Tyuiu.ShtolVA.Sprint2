using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolVA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((((x >= 1) && (x <= 2)) && ((y >= 1) && (y <= 2))) || (((x <= -1) &&( x >= -2 )) && ((y >= 1 ) && ( y <= 2 ))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}