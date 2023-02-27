using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Buying_Inventory
{
    internal class DiscountedInventory: Exercise
    {
        public DiscountedInventory(string name):base(name)
        {

        }
        public override void Run()
        {
            string[] items = { "Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies" };
            string discountedName = "oscar";
            
            while (true)
            {
                int menuChoice = HandyConsole.Menu(items, "Pick one of the following available items to see the price: ", ConsoleColor.Green);
            
                if (menuChoice == -1) break;

                string name = HandyConsole.GetInputAsString("Enter your name: ").ToLower();

                double price = GetPrice(items[menuChoice]);

                if (name == discountedName) HandyConsole.WriteLine($"Since you're my friend the price for {items[menuChoice]} is {price / 2} gold.", ConsoleColor.Green);
                else HandyConsole.WriteLine($"The price for {items[menuChoice]} is {price} gold.");

                HandyConsole.WaitForUser("\nPress any key to return to the menu..", ConsoleColor.DarkGray);
            }
        }

        public int GetPrice(string name) => name switch
        {
            "Rope" => 10,
            "Torches" => 15,
            "Climbing Equipment" => 25,
            "Clean Water" => 1,
            "Machete" => 20,
            "Canoe" => 200,
            _ => 1
        };
    }
}
