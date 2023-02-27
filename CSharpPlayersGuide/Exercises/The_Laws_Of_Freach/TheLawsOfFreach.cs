using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Laws_Of_Freach
{
    internal class TheLawsOfFreach: Exercise
    {
        public TheLawsOfFreach(string name): base(name)
        {

        }

        public override void Run()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int total = 0;
            int smallest = int.MaxValue;

            foreach (int number in array) total += number;

            foreach (int number in array)
            {
                if(number < smallest) smallest= number;
            }

            HandyConsole.WriteLine($"Smallest number is {smallest}.");
            HandyConsole.WriteLine($"Average value is {(double)total / (double)array.Length}");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);

            // Alternative solution with Linq:
            // int lowestNumber = array.Min();
            // double average = array.Average();

        }
    }
}
