/*
 * 4) Написать метод, вычисляющий значение функции G=F(X,Y) 
 * 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
 * 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
 * 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -3
 * -------test_2-------
 * -1,5
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -5,58
 * -------test_2-------
 * -1,50
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Сменить локаль на "ru-RU" для ввода чисел с плавующей точкой.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");


            double x, y;
            // TODO : Считать координаты точки.
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{G(x, y):f2}");

        }

        public static double G(double x, double y)
        {
            double res = 0;

            // TODO : Реализовать вычисление функции G.

            if(x < y && x > 0)
            {
                return (x + Math.Sin(y));
            }
            else if(x > y && x < 0)
            {
                return (y - Math.Cos(x));
            }
            else
            {
                return 0.5 * x * y;
            }

            return res;
        }
        //	* 4) Написать метод, вычисляющий значение функции G=F(X, Y)
        //* 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
        //* 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
        //* 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
        //* (аргументы sin и cos в радианах)
    }
}
