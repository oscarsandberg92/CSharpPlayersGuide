using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Repairing_The_Clocktower
{
    internal class RepairingTheClocktower: Exercise
    {
        public RepairingTheClocktower(string name) : base(name)
        {
        }

        public override void Run()
        {
            int number = HandyConsole.GetInputAsInt("Enter a number: ");

            HandyConsole.WriteLine($"{(number % 2 == 0 ? "Tick" : "Tock")}");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
