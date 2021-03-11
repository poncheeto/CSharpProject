using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    class Game
    {
        // Create variables for objects we will be working with for game
        private World MyWorld;
        private Player CurrentPlayer;

        public void Start()
        {

            Title = "Adventure Maze";
            CursorVisible = false;

            // Assign a maze map to grid
            string[,] grid =
            {
                { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" },
                { "█", " ", "█", " ", " ", " ", "█", " ", "█", " ", "X" },
                { "█", " ", "█", " ", "█", " ", "█", " ", " ", " ", "█" },
                { "█", " ", "█", " ", "█", " ", "█", " ", "█", "█", "█" },
                { " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", "█" },
                { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" },
            };

            MyWorld = new World(grid);

            CurrentPlayer = new Player(0, 4);

            RunGameLoop();
        }

        // Draw World and Player
        private void DrawFrame()
        {
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }

        // Key input from user will move player if IsPositionWalkable method returns true
        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.MovePlayer(0, -1);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.MovePlayer(0, 1);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.MovePlayer(1, 0);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.MovePlayer(-1, 0);
                    }
                    break;
            }
        }

        // Main game loop to be run in this order
        private void RunGameLoop()
        {
            while (true)
            {
                // Update player position
                DrawFrame();
                // Check for player input and move player
                HandlePlayerInput();
                // Check if player has reached exit and end game if so
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);
                if (elementAtPlayerPos == "X")
                {
                    break;
                }
            }
        }
    }
}
