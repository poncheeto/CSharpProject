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
            World myWorld = new World(grid);
            myWorld.Draw();

            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
