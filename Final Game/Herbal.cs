using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class Herbal
    {
        string Name;
        string Type;
        ConsoleColor Color;
        double Price;

        public Herbal(string name, string type, ConsoleColor color, double price)
        {
            Name = name;
            Type = type;
            Color = color;
            Price = price;
        }

        public void buyItem()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"{Name}, do you want to buy {Type} herbal?");

            string playerResponse = ReadLine().Trim().ToLower();
            if (playerResponse == "yes")
            {
                WriteLine("Sure. There you go.");
            }
            else
            {
                WriteLine("Ok. Thank you for visit");
            }
        }
    }
}
