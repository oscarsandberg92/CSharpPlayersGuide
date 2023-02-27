using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Makings_Of_A_Programmer
{
    internal class TheMakingsOfAProgrammer: Exercise
    {
        public TheMakingsOfAProgrammer(string name): base(name)
        {

        }

        public override void Run()
        {
            HandyConsole.WriteLine("This time they told me to make 5 WriteLine statements, so");
            HandyConsole.WriteLine("that's");
            HandyConsole.WriteLine("what");
            HandyConsole.WriteLine("I");
            HandyConsole.WriteLine("did.");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
