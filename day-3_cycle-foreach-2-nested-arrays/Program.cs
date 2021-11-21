using System;

namespace day_3_cycle_foreach_2_nested_arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello day-3 cycle foreach with nested !");

			int[][] twin_array_with_integers = new int[5][];
			for (int i = 0, j = 0; i <100; j++)
			{
				if (j % 5 == 0)
				{
					twin_array_with_integers[j / 5] = new int[5];
				}
				
				twin_array_with_integers[j / 5][j % 5] = i;
				
				if (i % 2 == 1)
				{
					i += 3; 
				}
				else
				{
					i += 5;
				}
			}
			foreach(int[] external in twin_array_with_integers)
			{
				foreach (int intern in external)
				{
					Console.Write(intern);
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}
