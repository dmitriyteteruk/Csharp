using System;
using System.Collections.Generic;
using System.Threading;

namespace exercise05_magic_dates
{
	class Program
	{
		static void Main(string[] args)
		{
			// приветствуем пользователя
			Console.WriteLine("Hello exercise 05 - Magic Dates!\n" +
				"Now you will see all magic  dates for 20th century\n");
			Thread.Sleep(1000);
			Console.WriteLine("5 seconds\n");
			Thread.Sleep(1000);
			Console.WriteLine("4 seconds");
			Thread.Sleep(1000);
			Console.WriteLine("3 seconds");
			Thread.Sleep(1000);
			Console.WriteLine("2 seconds");
			Thread.Sleep(1000);
			Console.WriteLine("1 second");
			Thread.Sleep(1000);
			Console.WriteLine("GO!\n");

			// задаем переменную начала и конца периода для магических дат
			DateTime StartDateTimePeriod = new DateTime(1900, 01, 01);
			DateTime FinishDateTimePeriod = new DateTime(1999, 12, 31);

			// создаем список всех дат
			var dates = new List<DateTime>();

			for (DateTime dt = StartDateTimePeriod; dt <= FinishDateTimePeriod; dt = dt.AddDays(1))	// до тех пор пока 'dt' в диапазоне дат, мы прибавляем по 1 дню
			{
				dates.Add(dt);
				
				int SumDayMonth = dt.Day + dt.Month;	// считаем сумму дня и месяца
				
				string year_full_string = Convert.ToString(dt.Year);				  // преобразуем ГОД из DateTime в String
				string year_short_string = year_full_string.ToString().Substring(2);  // считываем только последние 2 цифры года
				int year_int = Convert.ToInt32(year_short_string);					  // преобразуем последние 2 цифры года из String в Int

				string print_dt = Convert.ToString(dt).Substring(0, 10);			  // оставляем в дате только ДД.ММ.ГГГГ (время отбрасываем)

				if (SumDayMonth == year_int)										  // если сумма ДД + ММ = __ГГ, то выводим в консоль
				{
					Console.WriteLine($"Magic Date {print_dt}");
				}
			}
			
			Console.WriteLine("\n\n\nPress enter to close the program.");   // сообщение пользователю
			Console.ReadKey();

			 

		}


	}
}
