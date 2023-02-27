using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Magic_Cannon
{
    internal class TheMagicCannon: Exercise
    {
        public TheMagicCannon(string name) : base (name)
        {

        }

        public override void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                HandyConsole.Write($"{i}. ");
                HandyConsole.WriteLine(GetDamageType(i), GetColor(i));
            }

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }

        public string GetDamageType(int round) 
        {
            if (round % 3 == 0 && round % 5 == 0) return "Fire and Electric";
            else if (round % 3 == 0) return "Fire";
            else if (round % 5 == 0) return "Electric";
            else return "Normal";
        }

        public ConsoleColor GetColor (int round)
        {
            if (round % 3 == 0 && round % 5 == 0) return ConsoleColor.Blue;
            else if (round % 3 == 0) return ConsoleColor.Red;
            else if (round % 5 == 0) return ConsoleColor.Yellow;
            else return Console.ForegroundColor;
        }
    }
}
