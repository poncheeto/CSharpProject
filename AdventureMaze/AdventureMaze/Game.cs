using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    class Game
    {
        private World MyWorld;
        private Player CurrentPlayer;

        public void Start()
        {
            // Assign a maze map to grid
            string[,] grid =
            {
                { "=", "=", "=", "=", "=", "=", "=" },
                { "=", " ", "=", " ", " ", " ", "X" },
                { " ", " ", "=", " ", "=", " ", "=" },
                { "=", " ", "=", " ", "=", " ", "=" },
                { "=", " ", " ", " ", "=", " ", "=" },
                { "=", "=", "=", "=", "=", "=", "=" },
            };
            MyWorld = new World(grid);

            CurrentPlayer = new Player(0, 2);

            RunGameLoop();
        }

        private void RunGameLoop()
        {
            while(true)
            {
                // Draw player and maze
                break;
            }
        }
    }
}
