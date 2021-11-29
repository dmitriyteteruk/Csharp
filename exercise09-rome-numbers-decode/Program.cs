using System;

namespace exercise09_rome_numbers_decode
{
	class Program
	{
		static void Main(string[] args)
		{
			// приветствие пользователя
			Console.WriteLine("Hello exercise 09 - Rome Numbers Decode!\n");
			Console.WriteLine("Please enter any key to start the program\n");

			string I = "I";
			string V = "V";
			string X = "X";
			string L = "L";
			string C = "C";
			string M = "M";

			string userInput = GetInputFromUser().ToUpper();
			int UserInputLength = userInput.Length;

			string[] new_array = new string[userInput.Length];

			for (int i = 0; i < userInput.Length; i++)
			{
				new_array[i] = Convert.ToString(userInput[i]);
			}

			int Final_Number_1000 = 0;
			int Final_Number_500 = 0;
			int Final_Number_100 = 0;
			int Final_Number_50 = 0;
			int Final_Number_5 = 0;
			int Final_Number_1 = 0;
			int counter = 1;

			for (int i = 0; i < userInput.Length - 1; i++)
			{
				if (new_array[i] == new_array[i + 1] && new_array[i] == M)
				{	
					counter++;
					Final_Number_1000 = counter * 1000;
					counter = 1;
				}

				if (new_array[i] == new_array[i + 1] && new_array[i] == C)
				{
					counter++;
					Final_Number_500 = counter * 500;
					counter = 1;
				}
				
				if (new_array[i] == new_array[i + 1] && new_array[i] == L)
				{
					counter++;
					Final_Number_100 = counter * 100;
					counter = 1;
				}

				if (new_array[i] == new_array[i + 1] && new_array[i] == X)
				{
					counter++;
					Final_Number_50 = counter * 50;
					counter = 1;
				}
				
				if (new_array[i] == new_array[i + 1] && new_array[i] == V)
				{
					counter++;
					Final_Number_5 = counter * 5;
					counter = 1;
				}
				
				if (new_array[i] == new_array[i + 1] && new_array[i] == I)
				{
					counter++;
					Final_Number_1 = counter * 1;
					counter = 1;
				}

			}
			int sum = Final_Number_1000 + Final_Number_500 + Final_Number_100 + Final_Number_50 + Final_Number_5 + Final_Number_1;
			Console.WriteLine(sum);

		}



	//проверка на правильность формата ввода данных даты
	//public static bool CheckRomaDateFormat()
	//	{

	//		bool IsFormatCorrect()
	//		{
	//			for (int i = 0; i < GetInputFromUser().Length; i++)
	//			{
	//				if (Array_With)
	//	}



		// получение названия года от пользователя
		public static string GetInputFromUser()
		{
			Console.WriteLine("Please Enter Number in Rome format using following symbols\n" +
				"I, V, X, L , C, M");
			string NumberInRomeFormat = Console.ReadLine();
			return NumberInRomeFormat;
		}
	}
}
