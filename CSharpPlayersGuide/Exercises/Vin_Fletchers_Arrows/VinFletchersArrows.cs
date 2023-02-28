using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Vin_Fletchers_Arrows
{
    internal class VinFletchersArrows: Exercise
    {
        public VinFletchersArrows(string name): base(name) 
        {
            
        }

        public override void Run()
        {
            while(true)
            {
                string[] menuOptions = { "Elite Arrow", "Beginner Arrow", "Marksman Arrow", "Custom Arrow" };

                int menuChoice = HandyConsole.Menu(menuOptions, "Pick an arrow:", ConsoleColor.Green);
                List<Arrow> arrowList = new List<Arrow>();
                if (menuChoice == 0) arrowList.Add(Arrow.EliteArrow());
                if (menuChoice == 1) arrowList.Add(Arrow.BeginnerArrow());
                if (menuChoice == 2) arrowList.Add(Arrow.MarksmanArrow());
                if (menuChoice == 3) arrowList.Add(Arrow.CustomArrow());

                if (menuChoice == -1) return;
                HandyConsole.WriteLine("You've made an arrow with the following details:", ConsoleColor.Green);
                HandyConsole.WriteLine($"Headtype: {arrowList[^1].ArrowHead}\nFletching: {arrowList[^1].Fletching}\nLength: {arrowList[^1].Length}\nPrice: {arrowList[^1].GetCost()}");

                HandyConsole.WaitForUser("\nPress any key to continue..", ConsoleColor.DarkGray);

                int makeAnother = HandyConsole.Menu(new[] { "Yes", "No" }, "Do you want to make another arrow?", ConsoleColor.Green);

                if (makeAnother == 1) return;
            }
            
        }
    }
}
