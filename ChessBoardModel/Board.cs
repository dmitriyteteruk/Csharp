using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
	class Board
	{
		// the size of the board 8x8
		public int Size { get; set; }
		
		// 2d array of type cell
		public Cell[,] theGrid { get; set; }

		// констуркто доски
		public Board  (int s)
		{
			// изначальный размер доски Size = s.
			Size = s;

			// сощдаем новый двумерный массив
			theGrid = new Cell[Size, Size];

			// заполняем массив из 64 ячеек
			for (int i = 0; i< Size; i++)
			{
				for (int j=0; j < 0; j++)
				{
					theGrid[i, j] = new Cell(i, j);
				}
			}
		}
	}
}
