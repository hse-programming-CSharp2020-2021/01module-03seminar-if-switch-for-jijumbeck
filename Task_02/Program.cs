/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int x;
			// TODO : Ввести X.
			x = int.Parse(Console.ReadLine());

			Console.WriteLine(Reverse(x));
		}

		public static int Reverse(int x) {
            // TODO : Описать логику метода для получения нового числа.
            int countOfDigits = $"{x}".Length;
            int[] digits = new int[countOfDigits];
            for (int i = 0; i < countOfDigits; i++)
            {
                digits[i] = x % 10;
                x /= 10;
            }
            int number = 1;
            int result = 0;
            for (int i = 0; i < countOfDigits; i++)
            {
                result += digits[countOfDigits - 1 - i] * number;
                number *= 10;
            }
            return result;

        }
	}
}
