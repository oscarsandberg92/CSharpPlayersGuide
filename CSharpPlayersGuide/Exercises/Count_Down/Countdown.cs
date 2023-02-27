using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Count_Down
{
    internal class Countdown: Exercise
    {
        public Countdown(string name) : base(name)
        {

        }

        public override void Run()
        {
            CountDownToOne(10);
        }

        private void CountDownToOne(int x)
        {
            if (x == 1)
            {
                HandyConsole.WriteLine($"{x}");
                HandyConsole.WriteLine("You've successfully counted down to 1!");

                HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
                return;
            }
            HandyConsole.WriteLine($"{x}");

            CountDownToOne(x - 1);
        }
    }
}
