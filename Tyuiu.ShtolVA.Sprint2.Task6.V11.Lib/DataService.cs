using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolVA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g++;
                            break;
                        default:
                            m++;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 28;
                                    break;
                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    n++;
                    break;
            }
            string func;

            if (n < 10)
            {
                if (m < 10)
                {
                    func = "0" + n + "." + "0" + m + "." + g;
                }
                else
                {
                    func = "0" + n + "." + m + "." + g;
                }

            }
            else
            {
                if (m < 10)
                {
                    func = n + "." + "0" + m + "." + g;

                }
                else
                {
                    func = n + "." + m + "." + g;
                }
            }
            return func;
        }
    }
}
