using System;

namespace GameOfLife
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game(4, 10);
            game.RunGameConsole();
        }
    }
}