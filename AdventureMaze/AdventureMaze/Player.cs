using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    // Class will create player and allow for movement
    class Player
    {
        // Public variables to allow Game class to move player
        public int X { get; set; }
        public int Y { get; set; }
        private readonly string PlayerMarker;
        private readonly ConsoleColor PlayerColor;

        // Initialize initial position on player construction
        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "O";
            PlayerColor = ConsoleColor.DarkRed;
        }

        // Moves player by passing in x or y values to interact with maze array
        public void MovePlayer(int x, int y)
        {
            X += x;
            Y += y;
        }

        // Draw player
        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerMarker);
            ResetColor();
        }
    }
}
