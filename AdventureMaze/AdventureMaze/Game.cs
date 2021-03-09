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
            WriteLine("Game is starting");

            SetCursorPosition(4, 2);
            Write("X");

            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
