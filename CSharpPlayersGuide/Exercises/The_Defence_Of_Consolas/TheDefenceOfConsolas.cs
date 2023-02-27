using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Defence_Of_Consolas
{
    internal class TheDefenceOfConsolas: Exercise
    {
        public TheDefenceOfConsolas(string name) : base(name)
        {
        }

        public override void Run()
        {
            int targetRow = HandyConsole.GetInputAsInt("Enter target row: ");
            int targetCol = HandyConsole.GetInputAsInt("Enter target column: ", clearAfter: true);

            HandyConsole.WriteLine($"To defend ({targetRow}, {targetCol}) deploy defence to:", ConsoleColor.Green);
            foreach (var location in GetDefenceLocations(targetRow, targetCol))
            {
                HandyConsole.WriteLine($"({location.Item1}, {location.Item2})");
            }

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }

        public List<(int, int)> GetDefenceLocations(int row, int col)
        {
            List<(int, int)> defenceList = new()
            {
                (row, col - 1),
                (row, col + 1),
                (row - 1, col),
                (row + 1, col),
            };

            return defenceList; ;
        }

    }
}
