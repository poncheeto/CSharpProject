using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    class Game
    {
        public void Start()
        {
            // Assign a maze map to grid
            string[,] grid =
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" },
            };

            // Prints out grid to the console
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    string element = grid[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }

            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
