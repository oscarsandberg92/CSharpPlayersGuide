using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Thing_Namer
{
    public class TheThingNamer: Exercise
    {
        public TheThingNamer(string name): base (name)
        {

        }

        public override void Run()
        {
            string thing = HandyConsole.GetInputAsString("What kind of thing are we talking about?: ");
            string adjective = HandyConsole.GetInputAsString("How would you describe it? Big? Azure? Tattered?: ");

            HandyConsole.WriteLine($"The {adjective} {thing} of Doom 3000.");
            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
