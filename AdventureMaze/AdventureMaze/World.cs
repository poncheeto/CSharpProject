using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    class World
    {
        private string[,] Grid;
        private int Rows;
        private int Columns;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Columns = Grid.GetLength(1);
        }

        // Prints out grid to the console
        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
        }
    }
}
