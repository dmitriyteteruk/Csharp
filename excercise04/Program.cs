/* Задание 4
 * Напишите программу, которая определяет корректность хода ферзя, заданного в шахматной нотации, например “e2-e4” – некорректный, а “c2-c3”, “c2-e2”, “c2-f5” – корректные ходы.
 * 1. Определить логику:
 *		- ход по вертикали ОК
 *		- ход по горизонтали ОК
 *		- ход по диагонали ОК
 * 2. получить данные от пользователя
 * 3. проверить, может ли быть выполнен такой код
 * 4. вывести результат
 */
using System;
namespace exercise04

{
	// создаем класс - Point
	public class Point
	{
		public char Letter;	 // буква A, B, C, D, E, F, G, H
		public int Number;	 // цифра 1, 2, 3, 4, 5, 6, 7, 8
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World! Ex 4\n\n\n");

			Point[] points = new Point[2]; // создаем новый массив из 2 точек
			points[0] = GetPointFromUser("From"); // точка начала From - в массиве индекс 0 
			points[1] = GetPointFromUser("To");   // точка начала To - в массиве индекс 1

		}


		// функция или метод 03 получения данных координат от пользователя
		static Point GetPointFromUser(string pointName) // получаем от пользователя строку (string) 'pointName'
		{
			Console.WriteLine($"Enter value FROM for step {pointName}");
			Point point = new Point();      // выделяем место в памяти (в куче)
			string[] inputs = Console.ReadLine().Split(';'); // для разделения используем ; потому что русская консоль

			point.Letter = char.Parse(inputs[0]);
			point.Number = int.Parse(inputs[1]);
			return point;
		}
	}

}