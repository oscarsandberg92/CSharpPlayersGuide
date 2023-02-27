using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Hello_World
{
    internal class HelloWorld : Exercise
    {
        public HelloWorld(string name) : base(name)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Hello world");
            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
