using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Variable_Shop
{
    internal class TheVariableShop: Exercise
    {
        public TheVariableShop(string name): base(name)
        {

        }

        public override void Run()
        {
            sbyte sbyteVal= 1;
            byte byteVal = 2;
            short shortVal = 3;
            ushort ushortVal = 4;
            uint uintVal= 5;
            int intVal = 6;
            long longVal = 7;
            ulong ulongVal = 8;
            double doubleVal = 9;
            float floatVal = 10;
            decimal decimalVal = 11;
            string stringVal = "Twelve";
            char charVal = 'X';
            bool boolVal = true;

            HandyConsole.WriteLine($"sbyte: {sbyteVal}");
            HandyConsole.WriteLine($"byte: {byteVal}");
            HandyConsole.WriteLine($"ushort: {ushortVal}");
            HandyConsole.WriteLine($"short: {shortVal}");
            HandyConsole.WriteLine($"uint: {uintVal}");
            HandyConsole.WriteLine($"int: {intVal}");
            HandyConsole.WriteLine($"long: {longVal}");
            HandyConsole.WriteLine($"ulong: {ulongVal}");
            HandyConsole.WriteLine($"double: {doubleVal}");
            HandyConsole.WriteLine($"float: {floatVal}");
            HandyConsole.WriteLine($"decimal: {decimalVal}");
            HandyConsole.WriteLine($"string: {stringVal}");
            HandyConsole.WriteLine($"char: {charVal}");
            HandyConsole.WriteLine($"bool: {boolVal}");

            HandyConsole.WaitForUser("\nPress any key to exit this exercise..", ConsoleColor.DarkGray);
        }
    }
}
