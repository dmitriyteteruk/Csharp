using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_point_parrent_child
{
	public class Triangle : Line
	{
		 public Point Point3 { get; set; }

		public Triangle (double x1, double y1, double x2, double y2, double x3, double y3)
			: base(x1, y1, x2, y2)
		{
			Point3 = new Point(x3, y3);
		}
		
	}
}
