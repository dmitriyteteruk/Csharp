using System;

namespace day_3_cycle_foreach
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello day-3 - cycle foreach!");

			int[] array_with_integers = new int[25]; 
			
			for (int i = 0, j = 0; i < 100; j++)     
			{
				Console.WriteLine($"{i}, {j}");
				array_with_integers[j] = i;
				if (i % 2 == 1)             // если остаток от деления на 2 == 1, то число нечетное
				{
					i += 3;                 // и в это случае прибавляем +3 к i (если i = 5, то остаток равен 1, значит к 5 прибавляем 3 = 8
				}
				else
				{                                   // в другом случае прибавляем 5 к i 
					i += 5;
				}
			}
			foreach (int i in array_with_integers)
			{
				Console.WriteLine(i);
			}
			;

		}
	}
}
