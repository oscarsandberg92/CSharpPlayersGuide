using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Triangle_Farmer
{
    public class TheTriangleFarmer: Exercise
    {
        public TheTriangleFarmer(string name): base(name)
        {
        }

        public override void Run()
        {
            double width = HandyConsole.GetInputAsInt("Enter the base of the triangle: ");
            double height = HandyConsole.GetInputAsInt("Enter the height of the triangle: ");

            HandyConsole.WriteLine("The area of your triangle is: " + CalculateTriangleArea(width, height) + ".", ConsoleColor.Green);
            
            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }

        private double CalculateTriangleArea(double width, double height) => (width * height) / 2;
    }
}
