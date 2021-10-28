using System.Collections.Generic;

namespace GameOfLife
{
    public class Grid
    {
        private int _n { get; set; }
        public Cell[,] TabCells;

        public void Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            
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