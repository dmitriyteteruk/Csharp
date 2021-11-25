using System;

namespace Book
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Book!\n\n\n");

			Book WarAndPeace = new Book { Title = "War And Peace" };
			Console.WriteLine(WarAndPeace);
			WarAndPeace.IncreaseEditionNumber();
			Console.WriteLine(WarAndPeace);
		}
	}
}
