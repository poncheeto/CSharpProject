using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventureMaze
{
    class Player
    {
        
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;

        // Initialize initial position on player construction
        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "O";
            PlayerColor = ConsoleColor.DarkRed;
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
