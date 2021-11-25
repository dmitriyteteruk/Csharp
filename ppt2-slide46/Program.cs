using System;

namespace ppt2_slide46
{
	class Program
	{
		static void Main()
		{
			int[] myArray = { 0, 1, 2, 3, 4, 5 };
			int i;
			for (i = 0; i < 6; i++)
				Console.Write(" " + myArray[i]);
			Console.WriteLine("\nНовый массив: ");
			myArray = new int[] { 9, 1, 10, 8, 7, 3, 16, 5, 87, 4 };
			for (i = 0; i < 10; i++)
				Console.Write(" " + myArray[i]);
		}

	}
}
