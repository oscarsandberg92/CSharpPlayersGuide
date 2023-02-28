using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Simulas_Soup
{
    internal class SimulasSoup: Exercise
    {
        public SimulasSoup(string name) : base(name)
        {

        }

        public override void Run()
        {
            while (true)
            {
                (FoodType, MainIngredient, Seasoning) dish;

                int foodType = HandyConsole.Menu(new[] { "Soup", "Stew", "Gumbo" }, "Pick a foodtype", ConsoleColor.Green, builtInExit:false);
                dish.Item1 = (FoodType)foodType;

                int mainIngredient = HandyConsole.Menu(new[] { "Mushrooms", "Chicken", "Potatoes", "Carrots" }, "Pick a main ingredient",ConsoleColor.Green,builtInExit:false);
                dish.Item2 = (MainIngredient)mainIngredient;

                int seasoning = HandyConsole.Menu(new[] { "Salty", "Spicy", "Sweet" }, "Pick a seasoning", ConsoleColor.Green, builtInExit: false);
                dish.Item3 = (Seasoning)seasoning;

                HandyConsole.WriteLine($"You've made a {dish.Item3} {dish.Item2} {dish.Item1}!", ConsoleColor.Green);
                HandyConsole.WaitForUser("\nPress any key to continue..", ConsoleColor.DarkGray);

                int makeAnotherDish = HandyConsole.Menu(new[] { "Yes", "No" }, "Make another dish?", ConsoleColor.Green, builtInExit:false);
                if (makeAnotherDish == 1) return;
            }
        }
    }
}
