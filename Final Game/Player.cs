using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class Player
    {
        string Name;
        string Level;
        ConsoleColor Color;

        public int X { get; set;}
        public int Y { get; set;}
        private string PlayerMarker;
        private ConsoleColor PlayerColor;


        public Player(string name, ConsoleColor color, string level)
        {
            Name = name;
            Level = level;           
            Color = color;
        }

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "P";
            PlayerColor = ConsoleColor.Green;
        }

        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerMarker);
            ResetColor();
        }

        
    }
}
