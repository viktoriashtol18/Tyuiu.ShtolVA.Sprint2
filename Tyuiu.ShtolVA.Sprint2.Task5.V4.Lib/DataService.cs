using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolVA.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string res;
            switch (value)
            {
                case 1:
                    res = "пики";
                    break;
                case 2:
                    res = "трефы";
                    break;
                case 3:
                    res = "бубны";
                    break;
                case 4:
                    res = "черви";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть от 1 до 4 . Значение {value}");
            }
            return res;
        }
    }
}


    

