using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{	/// <summary>
	/// Book information
	/// </summary>
	public class Book
	{
		public string Title { get; set; }           // свойство класса - название книги

		public int Edition { get; private set; } = 1;	// свойство класса - версия, = 1 это значение по умолчанию. 
													 
		public int IncreaseEditionNumber()			// метод для изменения версии, т.к. в свойстве set установлен в private 
		{
			return ++Edition;
		}

		public override string ToString()
		{
			return $"Title {Title}, edition {Edition}";
		}
	}
}
