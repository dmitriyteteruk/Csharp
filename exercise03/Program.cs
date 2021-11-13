/*
 * Задача 3.
 * Расчет площади пятиугольника
 * Делим задачу на подзадачи:
 * 1. Функция 1 - Расчет площади треугольников по координатам
 * 2. Функция 2 - суммирование 3 площадей
 * 3. Функция 3 - Ввод координат
 * 4. Функция 4 - Считывание координа и передача в Ф1
 *
 *
 *	контрольные координаты: 
 *	А = 29;84
 *	B = 19;57
 *	C = 37;27
 *	D = 78;49
 *	E = 66;88
 *
 */

using System;

namespace exercise03
{
	// создаем класс - Point
	public class Point
	{
		public double X;
		public double Y;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World! Ex 3\n\n\n");
			Point[] points = new Point[5]; // создаем новый массив из 5 точек (у нас пятиугольник)
			points[0] = GetPointFromUser("A"); // присваиваем значение точки 0 с названием А. 
			points[1] = GetPointFromUser("B");
			points[2] = GetPointFromUser("C");
			points[3] = GetPointFromUser("D");
			points[4] = GetPointFromUser("E");

			// расчет сторон
			// формула вычисления стороны по координатам
			// d = кв.кор из (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)
			double AB = CalcSideLength(points[0], points[1]);
			Console.WriteLine($"Line length AB = {AB}");

			double BC = CalcSideLength(points[1], points[2]);
			Console.WriteLine($"Line length BC = {BC}");

			double CD = CalcSideLength(points[2], points[3]);
			Console.WriteLine($"Line length CD = {CD}");

			double DE = CalcSideLength(points[3], points[4]);
			Console.WriteLine($"Line length DE = {DE}");

			double AE = CalcSideLength(points[4], points[0]);
			Console.WriteLine($"Line length AE = {AE}");

			double AC = CalcSideLength(points[0], points[2]);
			Console.WriteLine($"Line length AC = {AC}");

			double CE = CalcSideLength(points[2], points[4]);
			Console.WriteLine($"Line length CE = {CE}");

			// площадь каждого треугольника
			double ABC = CalcTriangleArea(AB, BC, AC);
			double AEC = CalcTriangleArea(AC, CE, AE);
			double ECD = CalcTriangleArea(CE, CD, DE);

			//общая площадь пятиугольника
			double totalArea = ABC + AEC + ECD;
			Console.WriteLine($"Total square of pentagon ABCDE = {totalArea}");

			// вывод на консоль consolewriteln 

		}
		// функция 01 расчета площади треугльника
		// // расчет площади треугольника по длине сторон
		// формула Герона		 S = √ (a + b + c)/2 * ((a + b + c)/2 − a) * ((a + b + c)/2 − b) * ((a + b + c)/2 − c)
		// где 	p = (a + b + c)/2
		static double CalcTriangleArea(double side1, double side2, double side3) // для использования side - создали класс Side			    
		{
			double halfPerimiter = (side1 + side2 + side3) / 2; // полупериметр
			double CalcTriangleArea = Math.Sqrt(halfPerimiter * (halfPerimiter - side1) * (halfPerimiter - side2) * (halfPerimiter - side3));
			return CalcTriangleArea;
		}


		// функция 02 расчета длины стороны треугольника
		// формула Кв корень из ((X2-X1)²+(Y2-Y1)²)
		static double CalcSideLength(Point point1, Point point2) // здесь Point - это класс, а point1 и point2 - значения.

		{
			double CalcSideLength = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
			return CalcSideLength;
		}

		// функция или метод 03 получения данных координат от пользователя
		static Point GetPointFromUser(string pointName) // получаем от пользователя строку (string) 'pointName'
		{
			Console.WriteLine($"Enter coordinates of point {pointName}");
			Point point = new Point();      // выделяем место в памяти (в куче)
			string[] inputs = Console.ReadLine().Split(';'); // для разделения используем ; потому что русская консоль

			point.X = double.Parse(inputs[0]);
			point.Y = double.Parse(inputs[1]);
			return point;
		}


	}
}