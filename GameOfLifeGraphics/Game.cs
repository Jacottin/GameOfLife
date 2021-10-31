using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace GameOfLifeGraphics
{
    public class Game
    {
        private int n; 
        public Grid grid; 
        private List<Coords> _AliveCellsCoords;

        
        private Random rand = new Random();

        //Constructeur de la class Game
        public Game(int nbCells)
        {
            n = nbCells;

            _AliveCellsCoords = new List<Coords>();
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (rand.Next(0,101) <= 50)
                    {
                        _AliveCellsCoords.Add(new Coords(x,y));
                    }
                }
            }
            
            grid = new Grid(n, _AliveCellsCoords);
        }


        public void Paint(Graphics g)
        {
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid.tabCells[j,i].IsAlive)
                    {
                        g.FillRectangle(whiteBrush, j*5,i*5, 5,5);
                    }
                }
            }
        }
    }
}