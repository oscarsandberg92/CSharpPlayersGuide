using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Four_Sisters_And_The_Duckbear
{
    internal class TheFourSistersAndTheDuckbear: Exercise
    {
        public TheFourSistersAndTheDuckbear(string name):base(name)
        {

        }

        public override void Run()
        {
            int eggs= HandyConsole.GetInputAsInt("Enter amount of eggs gathered today: ");

            int eggsPerSister = EggsPerSister(eggs);
            int eggsForDuckbear = EggsForDuckBear(eggs); 
            HandyConsole.WriteLine($"{eggsForDuckbear} {(eggsForDuckbear == 1? "egg": "eggs")} for the duckbear.");
            HandyConsole.WriteLine($"{eggsPerSister} {(eggsPerSister == 1 ? "egg" : "eggs")} per sister");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }

        private int EggsPerSister(int eggs) => (eggs - (eggs % 4)) / 4;

        private int EggsForDuckBear(int eggs) => eggs % 4;
    }
}
