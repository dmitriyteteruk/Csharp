using System;

namespace day_3_cycle_for
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello day-3 cycle for!");

			for (int i = 0, j = 100; i < 100 && j > 0; j --)		// цикл for int i равной = 0 для значения меньше 100
			{
				Console.WriteLine($"{i}, {j}");		// выводим значение i в консоль
				if (i % 2 == 1)				// если остаток от деления на 2 == 1, то число нечетное
				{
					i += 3;					// и в это случае прибавляем +3 к i (если i = 5, то остаток равен 1, значит к 5 прибавляем 3 = 8
				}
				else 
				{									// в другом случае прибавляем 5 к i 
					i += 5;
				}
			}
		}
	}
}
