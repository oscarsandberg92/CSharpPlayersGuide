using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Prototype
{
    internal class ThePrototype : Exercise
    {
        public ThePrototype(string name) : base(name)
        {

        }

        public override void Run()
        {
            int number = HandyConsole.GetInputAsInt("User 1, enter a number between 0 and 100: ",
                minValue: 0, maxValue: 100, clearAfter: true);

            int guessedNumber = HandyConsole.GetInputAsInt("User 2, guess the number: ", minValue: 0, maxValue: 100);
            while(number != guessedNumber)
            {
                if (guessedNumber > number) HandyConsole.WriteLine($"{guessedNumber} is too high.",ConsoleColor.Yellow);
                else if (guessedNumber < number) HandyConsole.WriteLine($"{guessedNumber} is too low.", ConsoleColor.Yellow);

                guessedNumber = HandyConsole.GetInputAsInt("User 2, guess again: ", minValue: 0, maxValue: 100);
            }

            HandyConsole.WriteLine("You guessed the number!", ConsoleColor.Green);

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
