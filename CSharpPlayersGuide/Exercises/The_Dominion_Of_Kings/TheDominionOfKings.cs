using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Dominion_Of_Kings
{
    internal class TheDominionOfKings: Exercise
    {
        public TheDominionOfKings(string name) : base(name)
        {
        }

        public override void Run()
        {
            int provinces = HandyConsole.GetInputAsInt("Enter amount of provinces: ");
            int duchies = HandyConsole.GetInputAsInt("Enter amount of duchies: ");
            int estates = HandyConsole.GetInputAsInt("Enter amount of estates: ");

            int score = (provinces * 6) + (duchies * 3) + estates;
            HandyConsole.WriteLine($"Your total score is {score}.", ConsoleColor.Green);

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
