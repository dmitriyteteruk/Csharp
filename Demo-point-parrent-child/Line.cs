using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_point_parrent_child
{
	public class Line : Point
	{
		public Point Point2 { get; set; }  // свойство класса Point - точка Point2 добавлена, чтобы можно было получить из координат линию.

		public Line(double x1, double y1, double x2, double y2) : base(x1, y1)
		{
			Point2 = new Point(x2, y2);
		}
	}
}
