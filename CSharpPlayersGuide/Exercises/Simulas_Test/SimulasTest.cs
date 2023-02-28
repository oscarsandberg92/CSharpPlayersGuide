using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Simulas_Test
{
    internal class SimulasTest: Exercise
    {
        public SimulasTest(string name): base(name)
        {

        }

        public override void Run()
        {
            ChestState chest = ChestState.Locked;
            HandyConsole.WriteLine("Type exit if you want to leave the exercise..", ConsoleColor.DarkGray);

            while (true)
            {
                HandyConsole.WriteLine(ChestStateToString(chest));
                string action = HandyConsole.GetInputAsString("What would you like to do?: ");

                if (action == "exit") return; 

                bool isValid = IsValidInput(action.ToLower());

                if(isValid) 
                    chest = UpdateState(chest, action);
                else 
                    HandyConsole.WriteLine($"{action} is not a valid input.", ConsoleColor.Red);
            }
        }

        private string ChestStateToString(ChestState state) => state switch
        {
            ChestState.Locked => "The chest is locked",
            ChestState.Unlocked => "The chest is unlocked",
            _ => "The chest is open."
        };
        

        private bool IsValidInput(string input) =>
            input == "open" || input == "close" || input == "unlock" || input == "lock";

        private ChestState UpdateState (ChestState state, string action)
        {
            if (state == ChestState.Locked)
            {
                if (action != "unlock")
                {
                    HandyConsole.WriteLine("You need to unlock the chest first.", ConsoleColor.Yellow);
                    return state;
                }
                else
                {
                    HandyConsole.WriteLine("You unlocked the chest", ConsoleColor.Green);
                    return ChestState.Unlocked;
                }

            }
            else if (state == ChestState.Unlocked)
            {
                if (action == "open")
                {
                    HandyConsole.WriteLine("You opened the chest.", ConsoleColor.Green);
                    return ChestState.Open;
                }
                else if (action == "lock")
                {
                    HandyConsole.WriteLine("You locked the chest.", ConsoleColor.Green);
                    return ChestState.Locked;
                }
                else
                {
                    HandyConsole.WriteLine("You can only open or lock the chest.", ConsoleColor.Yellow);
                    return state;
                }
            }

            else 
            {
                if (action == "close")
                {
                    HandyConsole.WriteLine("You closed the chest.", ConsoleColor.Green);
                    return ChestState.Unlocked;
                }
                else
                {
                    HandyConsole.WriteLine("You need to close the chest.", ConsoleColor.Yellow);
                    return state;
                }
            }
        }
    }
}
