using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Threading.Thread;

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
                { "█", " ", " ", " ", "█", " ", " ", " ", " ", " ", "█"},
                { " ", " ", "█", "█", "█", "█", "█", "█", "█", "█", "█" },
            };

            MyWorld = new World(grid);

            CurrentPlayer = new Player(0, 5);

            RunGameLoop();
        }

        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if(MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void RunGameLoop()
        {
            while (true)
            {
                // Draw player and maze
                DrawFrame();
                // Check for player input and move player
                HandlePlayerInput();
                // Check if player has reached exit and end game if so
                string elementAtPlayePos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);
                if (elementAtPlayePos == "X")
                {
                    break;
                }
                // Give the console chance to render
                Sleep(20);
            }
        }
    }
}
