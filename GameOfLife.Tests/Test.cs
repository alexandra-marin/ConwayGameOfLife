using NUnit.Framework;
using System;
using GameOfLife.Core;

namespace GameOfLife.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void SingleCellDies ()
		{
			Cell cell = new Cell ();
			cell.Neighbours = 1; 

			Assert.IsFalse (cell.CellSurvives());
		}

		[Test ()]
		public void CellWithTwoNeighboursSurvives ()
		{
			Cell cell = new Cell ();
			cell.Neighbours = 2; 

			Assert.IsTrue (cell.CellSurvives());
		}

		[Test ()]
		public void DeadCellWithThreeNeighboursSurvives ()
		{
			Cell cell = new Cell ();
			cell.Neighbours = 3;
			cell.IsDead = true;

			Assert.IsTrue (cell.CellSurvives());
		}

		[Test ()]
		public void LiveCellWithThreeNeighboursSurvives ()
		{
			Cell cell = new Cell ();
			cell.Neighbours = 3;
			cell.IsDead = false;

			Assert.IsTrue (cell.CellSurvives());
		}
	}
}

