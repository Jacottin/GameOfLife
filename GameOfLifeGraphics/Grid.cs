using System;
using System.Collections.Generic;

namespace GameOfLifeGraphics
{
	public class Grid
	{
		public int GridSize { get; } //taille de la grille
		public Cell[,] tabCells;

		public Grid(int gridSize, List<Coords> aliveCellsCoords)
		{
			GridSize = gridSize;
			tabCells = new Cell[GridSize, GridSize];

			for (int y = 0; y < GridSize; y++)
			{
				for (int x = 0; x < GridSize; x++)
				{
					bool cellState = false;
					foreach (Coords coords in aliveCellsCoords)
					{
						if (coords._x == x && coords._y == y)
						{
							cellState = true;
							break;
						}
					}

					tabCells[x, y] = new Cell(cellState);
				}
			}

		}

		private int GetNbAliveNeighboor(int i, int j)
		{
			List<Coords> neighboors = GetCoordsNeighboor(i, j);
			List<Coords> aliveCells = GetCoordsAliveCells();
			int nbAlive = 0;

			foreach (Coords neighboor in neighboors)
			{
				foreach (Coords aliveCell in aliveCells)
				{
					if (neighboor._x == aliveCell._x && neighboor._y == aliveCell._y)
						++nbAlive;
				}
			}

			return nbAlive;
		}

		private List<Coords> GetCoordsNeighboor(int i, int j)
		{
			List<Coords> coords = new List<Coords>();
			coords.Add(new Coords(i - 1, j - 1));
			coords.Add(new Coords(i - 1, j));
			coords.Add(new Coords(i - 1, j + 1));
			coords.Add(new Coords(i, j - 1));
			coords.Add(new Coords(i, j + 1));
			coords.Add(new Coords(i + 1, j - 1));
			coords.Add(new Coords(i + 1, j));
			coords.Add(new Coords(i + 1, j + 1));
			return coords;
		}

		private List<Coords> GetCoordsAliveCells()
		{
			List<Coords> aliveCells = new List<Coords>();
			for (int y = 0; y < GridSize; y++)
			{
				for (int x = 0; x < GridSize; x++)
				{
					if (tabCells[x, y].IsAlive)
						aliveCells.Add(new Coords(x, y));
				}
			}

			return aliveCells;
		}

		public void DisplayGrid()
		{
			List<Coords> aliveCells = GetCoordsAliveCells();
			for (int y = 0; y < GridSize; y++)
			{
				for (int i = 0; i < GridSize; i++)
				{
					Console.Write("+---");
				}

				Console.Write("+\n");

				for (int x = 0; x < GridSize; x++)
				{
					string cellState = " ";
					foreach (Coords coords in aliveCells)
					{
						if (x == coords._x && y == coords._y)
						{
							cellState = "O";
							break;
						}
					}

					Console.Write($"| {cellState} ");
				}

				Console.Write("|\n");
			}

			for (int i = 0; i < GridSize; i++)
			{
				Console.Write("+---");
			}

			Console.Write("+\n");
		}

		public void UpdateGrid()
		{
			List<Coords> aliveCells = GetCoordsAliveCells();
			for (int y = 0; y < GridSize; y++)
			{
				for (int x = 0; x < GridSize; x++)
				{
					bool isCurrentCellALive = tabCells[x, y].IsAlive;

					if (!isCurrentCellALive && GetNbAliveNeighboor(x, y) == 3)
						tabCells[x, y].ComeAlive();
					else if (isCurrentCellALive && (GetNbAliveNeighboor(x, y) == 2 || GetNbAliveNeighboor(x, y) == 3))
						tabCells[x, y].ComeAlive();
					else
						tabCells[x, y].PassAway();
				}
			}

			foreach (Cell cell in tabCells)
			{
				cell.Update();
			}
		}
	}
}