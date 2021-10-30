using System;
using System.Collections.Generic;

namespace GameOfLife
{
    static class Program
    {
        public static void Main(string[] args)
        {
                List<Coords> aliveCells = new List<Coords>();
                aliveCells.Add(new Coords(1,2));
                aliveCells.Add(new Coords(2,2));
                aliveCells.Add(new Coords(3,2));
                aliveCells.Add(new Coords(4, 2));
                aliveCells.Add(new Coords(5, 2));
                aliveCells.Add(new Coords(6, 2));
                aliveCells.Add(new Coords(7, 2));
                aliveCells.Add(new Coords(8, 2));
                aliveCells.Add(new Coords(9, 2));
                aliveCells.Add(new Coords(10, 2));
                aliveCells.Add(new Coords(1, 3));
                aliveCells.Add(new Coords(2, 3));
                aliveCells.Add(new Coords(3, 3));
                aliveCells.Add(new Coords(4, 4));
                aliveCells.Add(new Coords(5, 4));
                aliveCells.Add(new Coords(6, 4));
                

                Game game = new Game(10, 50, aliveCells);
                game.RunGameConsole();

                Console.ReadLine();
            
        }
    }
}