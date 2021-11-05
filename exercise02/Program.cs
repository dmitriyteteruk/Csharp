/* Задание №2
Создать программу, рассчитывающую линию наилучшего соответствия для массива двухмерных координат. 
Каждый элемент массива имеет координаты (x, y) (вещественные числа). 
Для расчета коэффициентов линии y = mx + b используются формулы: 
где  x̄, ȳ - средние арифметические значения для координат x, y.
Для массива координат (1, 1), (2, 2.1), (3, 2.9) программа должна рассчитать линию наилучшего соответствия y = 0.95 x + 0.1.
 
 */

using System;
using System.Collections.Generic;

namespace Exercise02
{
	class Program
	{
		static void Main(string[] args)
		{
			// объявлем массив точек - которые получаем от пользователя
			List<double[]> points = GetPointsFromUser();

			// объявляем переменные
			double sumX, sumY, sumX2, sumXY;
			// присваиваем переменными изначальные значения = 0
			sumX = 0;
			sumY = 0;
			sumX2 = 0;
			sumXY = 0;
			
			// запускаем цикл foreach
			foreach (double[] point in points)
			{
				// прибавляем к изначальным значениям значения точек и умножения
				sumX += point[0];
				sumY += point[1];
				sumXY += point[0] * point[1];
				sumX2 += point[0] * point[0];
			}

			// преобразуем формулу с квадратами в понятный машине код
			double n = points.Count; // считаем количество точек
			double m = (sumXY - sumX * sumY / n) / (sumX2 - sumX * sumX / n);
			double xAverage = sumX / n;
			double yAverage = sumY / n;
			double b = yAverage - m * xAverage;

			Console.WriteLine($"y = {m:F3} x + {b:F3}");
		}

		static List<double[]> GetPointsFromUser()
		{
			Console.WriteLine("Укажите координаты Х и Y для точек, в качестве разделитя используйте ';'. Для окончания ввода введите символ 'q' и нажмите Enter:");
			var points = new List<double[]>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "q") break;
				double[] xAndY = new double[2];
				string[] inputsDevided = input.Split(';');
				xAndY[0] = double.Parse(inputsDevided[0]);

				xAndY[1] = double.Parse(inputsDevided[1]);
				points.Add(xAndY);
			}
			return points;
		}
	}

}