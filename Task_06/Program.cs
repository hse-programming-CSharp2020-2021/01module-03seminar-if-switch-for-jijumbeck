﻿/*
 * (***) Трехзначным целым числом кодируется номер аудитории в учебном корпусе. 
 * Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на 
 * этаже. Из трех аудиторий определить и вывести на экран ту аудиторию, которая 
 * имеет минимальный номер внутри этажа. Если таких аудиторий несколько - вывести 
 * аудиторию с минимальным этажом. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 611 202 204 508 813
 * -------test_2-------
 * 307 507 707 807 907 107
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 202
 * -------test_2-------
 * 107
 * --------------------
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06 {
	class Program {

		static void Main(string[] args) {
			int fl = 10;
			int ka = 100;

			foreach (int level in GetNumbers()) {
				// TODO : Обработать информацию об очередном этаже. Он лежит в переменной level.
				int floor = level / 100;
				int kab = level % 100;
				if (kab < ka)
                {
					ka = kab;
					fl = floor;
                }
				else if(ka == kab)
                {
					if(floor < fl)
                    {
						ka = kab;
						fl = floor;
					}
                }
				
			}

			int answer = fl * 100 + ka;

            // TODO : Вывести получееный этаж.
            Console.WriteLine(answer);
		}

		public static List<int> GetNumbers() {
			return Console.ReadLine().Split(' ').ToList().ConvertAll((x) => int.Parse(x));
		}
	}
}
