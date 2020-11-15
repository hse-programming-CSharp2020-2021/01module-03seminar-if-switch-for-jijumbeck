/* 
 * 1) Написать метод, находящий четырёхзначное десятичное число s, все цифры которого одинаковы 
 * и которое представляет собой сумму арифметической прогресии с шагом 1 и первым членом l,
 * то есть s = l + (l+1) + (l+2) + ...
 * Вывести полученное число.
 * Или сообщить о том, что такого числа нет.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 555
 * -------test_2-------
 * 300
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1111
 * -------test_2-------
 * 0
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            // TODO : Считать l;
            l = int.Parse(Console.ReadLine());
            int result = CalcS(l);

            // TODO : вывести результат или 0, если его не было получено.
            if (result < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static int CalcS(int l)
        {
            int res = -1;
            res = l;
            int i = 1;
            // TODO : Написать логику для метода вычисления S и 
            // если вычислить удалось, поместить в res полученное S.

            while (res < 1000 || !CheckNumber(l))
            {
                if(res > 10000)
                {
                    break;
                }
                res += l + i++;
            }

            if (CheckNumber(res))
            {
                return res;
            }
            return -1;
        }

        public static bool CheckNumber(int x)
        {
            bool check = true;
            while (check && x > 10)
            {
                check &= ((x % 100) / 10) == x % 10;
                x /= 10;
            }
            return check;
        }
    }
}
