using System;

namespace day_3_coverted_parsed
{
	class Program
	{
		static void Main(string[] args)
		{
			{ 
				Console.WriteLine("Hello World!\n\n\n"); 
			}
			{
				Console.WriteLine("Enter a number:");
				string s = Console.ReadLine();
				double converted = Convert.ToInt32(s);
				Console.WriteLine($"double converted ToInt32 = {s}");
				int parsed = (int)double.Parse(s);
				Console.WriteLine($"int parsed to double = {s}");
			}
		}


	}
}
