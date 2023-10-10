using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolVA.Sprint2.Task0.V13.Lib;

namespace Tyuiu.ShtolVA.Sprint2.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1905;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x,y);

            
            Console.WriteLine("Спринт #2 | Выполнила: Штоль В.А. | ИИПБ-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Штоль Виктория Алексеевна | ИИПБ-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x );
            Console.WriteLine("Y = " + y );

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            for (int i=0; i<6; i++)

            Console.WriteLine(res[i]);
            Console.ReadLine();

        
        }
    }
}
