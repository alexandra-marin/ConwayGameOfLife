using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Core
{
	public class Cell
	{
		public int Neighbours { get; set;}
		public bool IsDead { get; set;}

		public IList<Func<Cell, bool>> Rules;
		Func<Cell, bool> Underpopolation = cell => cell.Neighbours < 2;
		Func<Cell, bool> Overpopulation = cell => cell.Neighbours > 4;
		Func<Cell, bool> CannotBeRevivied = cell => cell.IsDead ? (cell.Neighbours == 3 ? false : true) : false;

		public Cell()
		{
			Rules = new [] {Underpopolation, Overpopulation, CannotBeRevivied};
		}

		public bool CellSurvives()
		{
			return Rules.All (rule => rule(this) == false);
		}
	}
}

