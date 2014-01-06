using System;

namespace GameOfLife.Core
{
	public class InitialCell
	{
		public int Neighbours { get; set;}
		public bool IsDead { get; set;}
	
		public bool CellSurvives()
		{
			if (this.Neighbours < 2)
			{
				//Underpopulation
				return false;
			} 
			else if (this.Neighbours > 4)
			{
				//Overpopulation
				return false;
			} 
			else if(this.Neighbours == 3 & this.IsDead)
			{
				//Survives by reproduction to next iteration
				return true;
			}
			else
			{
				//Survives to next iteration
				return true;
			}
		}
	}
}

