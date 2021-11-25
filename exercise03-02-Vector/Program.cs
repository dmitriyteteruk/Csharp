using System;

namespace exercise03_02_Vector
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello exercise 03-02 - Vector!\n\n\n");
			Vector vector_name = new Vector();
			vector_name.Append(-5);
			vector_name.Append(4.8);
			vector_name.Append(1.2E5);
			Console.WriteLine(vector_name);
			Console.ReadKey();
			;

		}
	}
}
