﻿/*
 * 5) Написать метод, вычисляющий значение функции G=F(X)
 * 𝐺=sin⁡(𝜋/2),𝑋≤0.5
 * 𝐺=sin⁡((𝜋∙(𝑥−1))/2),𝑋>0.5
 * 
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -------test_2-------
 * 1,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1,00
 * -------test_2-------
 * 0,71
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_05 {
	class Program {
		static void Main(string[] args) {
			// TODO : Сменить локаль на "ru-RU" для ввода чисел с плавующей точкой.
			Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

			double x;
			// TODO : Считать точку.
			x = double.Parse(Console.ReadLine());

			Console.WriteLine($"{G(x):f2}");

		}

		public static double G(double x) {
			

			// TODO : Реализовать вычисление функции G.
			if(x <= 0.5)
            {
				return 1;
            }
            else
            {
				return Math.Sin((Math.PI * (x - 1) / 2));
            }

		}
	}
}
