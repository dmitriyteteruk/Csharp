using System;
using System.Collections.Generic;

namespace excercise06_random_password_generator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello to Random Password Generator Program!\n\n\n");

			Console.WriteLine(CreateRandomPassword());

			// сообщение пользователю
			Console.WriteLine("\n\n\nPress enter to close the program.");   // сообщение пользователю
			Console.ReadKey();
		
		}

		// генерация пароля   
		static string CreateRandomPassword(int length = 10)		// длина в 10 смиволов
		{
			// строка с символами, которые мы используем  
			string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			Random random = new Random();

			// делаем массив 10 символами     
			char[] password_symbols = new char[length];
			for (int i = 0; i < length; i++)			 // задаем условие if до 10
			{
				password_symbols[i] = validChars[random.Next(0, validChars.Length)]; // выполняем операцию с i и символами (random (от 0, до конца массива)
			}
			
			string password_new = new string(password_symbols);	

			string password_lower = password_new.ToString().Substring(0, 4).ToLower();  // делаем принудительное понижение регистра
			string password_upper = password_new.ToString().Substring(4, 4).ToUpper();  // делаем принудительное повышение регистра
			Random password_last2_ran = new Random();                                   // рандомно герериурем посоедние 2 цифры 
			int password_last_2 = password_last2_ran.Next(10, 99);                      // от 10 до 99 (будет мало)
			string password_ints_string = Convert.ToString(password_last_2);            // преобразуем рандомные цифры в строку
			string password_new_updated = password_lower + password_upper + password_ints_string;  // склииваем все строики
			return new string(password_new_updated);									// возвращаем строки 
		}
	}
}
