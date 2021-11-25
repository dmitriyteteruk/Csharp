using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_point_parrent_child
{
	public class Shape : Point // : Point означает, что мы наследуюем свойства класса Point
	{
		public double Z { get; set; } // добавляем новое свойство - точку Z - в постранстве

		// конструктор
		public Shape(double x, double y, double z) : base(x, y)
		{
			Z = z;
		}
	}

	
	  
}
