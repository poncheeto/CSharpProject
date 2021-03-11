using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    // Class will create maze and determine how the player will respond to different characters within the maze.
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

                    if (element == "X")
                    {
                        ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else
                    {
                        ResetColor();
                    }

                    Write(element);
                }
            }
        }

        // Checks for the element at player's position. Used to check if player reached "X" to exit game
        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }

        // Checks if position is walkable for player
        public bool IsPositionWalkable(int x, int y)
        {
            // Check bounds
            if (x < 0 || y < 0 || x >= Columns || y >= Rows)
            {
                return false;
            }

            // Check if grid is walkable tile
            return Grid[y, x] == " " || Grid[y, x] == "X";
        }
    }
}
