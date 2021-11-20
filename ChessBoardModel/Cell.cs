using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
	class Cell
	{
		public int RowNumber { get; set; }
		public int ColumnNumber { get; set; }
		public bool CurrentrlyOccupied { get; set; }
		public bool LegalMove { get; set; }

		public Cell(int x, int y)
		{
			RowNumber = x;
			ColumnNumber = y;
		}
	}
}
