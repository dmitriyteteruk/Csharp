using System;


namespace day3_random
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello random!\n\n\n");

			Random rand = new Random();
			for (double i = 0; i <= 20; i++)
			{
				double randomint = rand.Next(1, 20);
				Console.WriteLine($"{i}. {randomint}");
			}
			Console.Read();
		}
	}
}
