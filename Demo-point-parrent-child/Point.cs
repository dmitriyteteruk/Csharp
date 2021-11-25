using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_point_parrent_child
{
	public class Point					 // класс Point
	{
		public double X { get; set; }  // свойство класса Point - точка X
		public double Y { get; set; }  // свойство класса Point - точка Y

		public Point (double x, double y)
		{
			X = x;
			Y = y;
		} 
	}
}
