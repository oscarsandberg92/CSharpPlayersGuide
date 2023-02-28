using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Hunting_The_Manticore
{
    internal class HuntingTheManticore: Exercise
    {
        public HuntingTheManticore(string name) : base(name)
        {

        }

        public override void Run()
        {
            while (true)
            {
                var game = new Game();

                game.ManticoreDistance = HandyConsole.GetInputAsInt("Player 1, enter how far away you would like to station the Manticore [1-100]: ", 
                    clearAfter: true, minValue:1, maxValue: 100);

                while (game.CityCurrentHealth > 0 && game.ManticoreCurrentHealth > 0)
                {
                    game.PlayRound();
                }

                if (game.ManticoreCurrentHealth < 1) 
                    HandyConsole.WriteLine($"Player 2 [The City] won in {game.Round} rounds.", ConsoleColor.Green);
                else 
                    HandyConsole.WriteLine($"Player 1 [The Manticore] won in {game.Round} rounds.", ConsoleColor.Red);

                HandyConsole.WaitForUser("\nPress any key to continue..", ConsoleColor.DarkGray);
                
                int choice = HandyConsole.Menu(new[] { "Yes", "No" }, "Would you like to play again?" ,ConsoleColor.Green, builtInExit:false);

                if (choice == 1) break;
            }
        }
    }
}
