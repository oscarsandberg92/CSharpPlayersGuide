using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Watchtower
{
    internal class WatchTower: Exercise
    {
        public WatchTower(string name) : base(name)
        {
        }

        public override void Run()
        {
            int x = HandyConsole.GetInputAsInt("Enter an X-value: ");
            int y = HandyConsole.GetInputAsInt("Enter an Y-value: ");

            HandyConsole.WriteLine(DirectionToString(x, y), ConsoleColor.Green);

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }

        private string DirectionToString(int x, int y)
        {
            if (x == 0 && y == 0) return "The enemy is here!";

            string result = $"{(y == 0 ? "": y > 0? "north": "south")}{(x == 0 ? "" : x > 0 ? "east" : "west")}";
            return $"The enemy is to the {result}!";
        }
    }
}
