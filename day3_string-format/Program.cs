using System;

namespace day3_string_format
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello string format!\n\n\n");

			string s = "e2-f4";
			string sLower = s.ToLower();					// приводит все элементы s к нижнему регистру, затем в строках 13 и 14 можно убрать .ToLower
			string cell_1 = s.Substring(0, 2).ToLower();	 // разбиваем строку на элементы и приводим к нижнему регистру
			string cell_2 = s.Substring(3, 2).ToLower();
			
			char cell_1_Row = cell_1.ToCharArray()[0] ;		 // преобразовываем нашу строку с массив 
			char cell_1_Column = cell_1.ToCharArray()[1];
			int cell_1_Row_Int = (int)cell_1_Row;            // преобразовываем в char в int для вычислений

			char cell_2_Row = cell_2.ToCharArray()[0];       // преобразовываем нашу строку с массив 
			char cell_2_Column = cell_2.ToCharArray()[1];
			int cell_2_Row_Int = (int)cell_2_Row;
			 ;
		}
	}
}
