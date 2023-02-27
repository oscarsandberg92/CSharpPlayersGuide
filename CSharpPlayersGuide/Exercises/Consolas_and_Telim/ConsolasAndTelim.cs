using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Consolas_and_Telim
{
    internal class ConsolasAndTelim: Exercise
    {
        public ConsolasAndTelim(string name): base(name)
        {

        }

        public override void Run()
        {
            HandyConsole.WriteLine("Bread is ready.");
            string answer = HandyConsole.GetInputAsString("Who is bread for?: ");

            HandyConsole.WriteLine($"Noted: {answer} got bread", ConsoleColor.Green);

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
