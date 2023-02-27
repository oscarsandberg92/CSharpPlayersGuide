using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.What_Comes_next
{
    internal class WhatComesNext: Exercise
    {
        public WhatComesNext(string name): base(name)
        {

        }

        public override void Run()
        {
            HandyConsole.WriteLine("Another text, with color this time!", ConsoleColor.Green);
            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
