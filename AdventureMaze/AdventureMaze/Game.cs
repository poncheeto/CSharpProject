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
                { "=", "=", "=", "=", "=", "=", "=" },
                { "=", " ", "=", " ", " ", " ", "X" },
                { "O", " ", "=", " ", "=", " ", "=" },
                { "=", " ", "=", " ", "=", " ", "=" },
                { "=", " ", " ", " ", "=", " ", "=" },
                { "=", "=", "=", "=", "=", "=", "=" },
            };
            World myWorld = new World(grid);
            myWorld.Draw();

            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
