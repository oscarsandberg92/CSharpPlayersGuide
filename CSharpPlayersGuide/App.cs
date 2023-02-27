using CSharpPlayersGuide.Exercises.Buying_Inventory;
using CSharpPlayersGuide.Exercises.Consolas_and_Telim;
using CSharpPlayersGuide.Exercises.Count_Down;
using CSharpPlayersGuide.Exercises.Hello_World;
using CSharpPlayersGuide.Exercises.Hunting_The_Manticore;
using CSharpPlayersGuide.Exercises.Repairing_The_Clocktower;
using CSharpPlayersGuide.Exercises.The_Defence_Of_Consolas;
using CSharpPlayersGuide.Exercises.The_Dominion_Of_Kings;
using CSharpPlayersGuide.Exercises.The_Four_Sisters_And_The_Duckbear;
using CSharpPlayersGuide.Exercises.The_Laws_Of_Freach;
using CSharpPlayersGuide.Exercises.The_Magic_Cannon;
using CSharpPlayersGuide.Exercises.The_Makings_Of_A_Programmer;
using CSharpPlayersGuide.Exercises.The_Prototype;
using CSharpPlayersGuide.Exercises.The_Replicator_Of_Dto;
using CSharpPlayersGuide.Exercises.The_Thing_Namer;
using CSharpPlayersGuide.Exercises.The_Triangle_Farmer;
using CSharpPlayersGuide.Exercises.The_Variable_Shop;
using CSharpPlayersGuide.Exercises.Watchtower;
using CSharpPlayersGuide.Exercises.What_Comes_next;
using System.Reflection;


namespace CSharpPlayersGuide
{
    public class App
    {

        private List<Exercise> exercises;
        public App()
        {
            exercises = new()
            {
                new HelloWorld("Hello, World!"),
                new WhatComesNext("What Comes Next"),
                new TheMakingsOfAProgrammer("The Makings of a Programmer"),
                new ConsolasAndTelim("Consolas and Telim"),
                new TheThingNamer("The Thing Namer 3000"),
                new TheVariableShop("The Variable Shop"),
                new TheVariableShopReturns("The Variable Shop Returns"),
                new TheTriangleFarmer("The Triangle Farmer"),
                new TheFourSistersAndTheDuckbear("The Four Sisters and the Duckbear"),
                new TheDominionOfKings("The Dominion of Kings"),
                new TheDefenceOfConsolas("The Defence of Consolas"),
                new RepairingTheClocktower("Repairing the Clocktower"),
                new WatchTower("Watchtower"),
                new BuyingInventory("Buying Inventory"),
                new DiscountedInventory("Discounted Inventory"),
                new ThePrototype("The Prototype"),
                new TheMagicCannon("The Magic Cannon"),
                new TheReplicatorOfDto("The Replicator of D'To"),
                new TheLawsOfFreach("The Laws of Freach"),
                new Countdown("Countdown"),
                new HuntingTheManticore("Hunting the Manticore")
            };
            exercises = exercises.OrderBy(x => x.Name).ToList();
        }

        public void Run()
        {
            HandyConsole.InitializeSettings(ConsoleColor.White, ConsoleColor.Black);
            int choice;

            while (true)
            {
                string[] menuOptions = GetExerciseNames(exercises);
                
                choice = HandyConsole.Menu(menuOptions, "Pick an exercise to run:", ConsoleColor.Green);
                
                if(choice == -1) Environment.Exit(0);
                else exercises[choice].Run();
            }
        }

        private string[] GetExerciseNames(List<Exercise> exercises) => exercises.Select(x => x.Name).OrderBy(x=> x).ToArray();
    }
}