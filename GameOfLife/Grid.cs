using System.Collections.Generic;

namespace GameOfLife
{
    public class Grid
    {
        private int _n;
        public Cell[,] TabCells;

        public int n
        {
            get { return _n; }
            set { _n = value; }
        }

        public void Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            this.n = nbCells;
            TabCells = new Cell[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (expr)
                    {
                        
                    }
                }
            }
        }

        public int GetNbAliveNeighboor(int i, int j)
        {
            return i;
        }

        public List<Coords> GetCoordsCellsAlive()
        {
            return new List<Coords>();
        }

        public void DisplayGrid()
        {
            
        }

        public void UpdateGrid()
        {
            
        }
    }
}