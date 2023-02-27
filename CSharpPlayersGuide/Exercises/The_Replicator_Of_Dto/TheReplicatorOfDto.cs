using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Replicator_Of_Dto
{
    internal class TheReplicatorOfDto: Exercise
    {
        public TheReplicatorOfDto(string name): base(name)
        {

        }

        public override void Run()
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                firstArray[i] = HandyConsole.GetInputAsInt("Enter a number: ");
            }

            for (int i = 0; i < 5; i++)
            {
                secondArray[i] = firstArray[i];
            }

            Console.Clear();

            HandyConsole.WriteLine("First array:", ConsoleColor.Green);
            foreach (int number in firstArray) HandyConsole.WriteLine($"{number}");

            HandyConsole.WriteLine("Second array:", ConsoleColor.Green);
            foreach (int number in secondArray) HandyConsole.WriteLine($"{number}");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
