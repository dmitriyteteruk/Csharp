//
// Программа кодирования массива  УРА!
//
using System;
using System.Collections.Generic;

namespace excercise08_array_coding
{
	class Program
	{

		// метод генерации строки со 100 рандомными символами
		public static string Generate_Ranadom_Chars_String(int length = 20)     // генерируем рандомно length символов
		{
			string validChars = "ABC";                                          // генерация из указанных символов
			Random random = new Random();

			char[] array_with_chars = new char[length];
			for (int i = 0; i < length; i++)
			{
				array_with_chars[i] = validChars[random.Next(0, validChars.Length)]; // выполняем операцию с i и символами (random (от 0, до конца массива)
			}

			string all_chars_string = new string(array_with_chars).ToString();      // переводим рандомный массив символов в строку
			return new string(all_chars_string);                                    // возвращаем строку
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Hello excercise 08 - array coding\n");

			// вызываем метод генерации рандомных значений и сохраняем в строку
			string All_Symbols_String = Generate_Ranadom_Chars_String();

			// выводим на экран 20 символов
			Console.WriteLine($"New string is: {All_Symbols_String}\n");

			// создаем массив из символов длинной строки
			char[] Array_With_Symbols = new char[All_Symbols_String.Length + 1]; // длина массива + 1, чтобы была возможность выйти за границу 19 индекса.

			// заполняем массив 20 значениями через цикл for
			for (int i = 0; i < All_Symbols_String.Length; i++)
			{
				Array_With_Symbols[i] = All_Symbols_String[i];
			}

			// сравниваем символы и если совпадают то суммируем

			// создаем двумерный массив типа 'string' максимальной длины
			string[,] Symbol_Count_Array;
			Symbol_Count_Array = new string[All_Symbols_String.Length, 2];

			int counter = 1;     // начальное значения счетчика
			int counter_max_sum = All_Symbols_String.Length; // контроль Exception для счетчика
			Console.WriteLine("Below you can find array with format CHAR:COUNT\n");
			// запускаем перебор всех записей в массиве
			for (int i = 0; i < counter_max_sum; i++)

				if (Array_With_Symbols[i] == Array_With_Symbols[i + 1])
				{
					++counter;                                                   // прибавляем счетчик символов на 1
				}
				else
				{
					string Symbol_a = Array_With_Symbols[i].ToString();
					string Counter_b = counter.ToString();
					Console.WriteLine($"{Symbol_a} = {Counter_b}"); // выводим в консоль символ и количество
					
					
					//Symbol_Count_Array new string[,] { { Symbol_a, Counter_b } };

					counter = 1;                                                 // выставляем счетчик на 1

				}
			Console.WriteLine("\nProgram has end it's process. Please press any key to close the window.");
			Console.ReadKey();
		}
	}
}

