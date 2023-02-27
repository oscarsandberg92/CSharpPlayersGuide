using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.The_Variable_Shop
{
    internal class TheVariableShopReturns: Exercise
    {
        public TheVariableShopReturns(string name): base(name)
        {

        }

        public override void Run()
        {
            sbyte sbyteVal = 127;
            byte byteVal = 255;
            short shortVal = short.MaxValue;
            ushort ushortVal = ushort.MaxValue;
            uint uintVal = uint.MaxValue;
            int intVal = int.MaxValue;
            long longVal = long.MaxValue;
            ulong ulongVal = ulong.MaxValue;
            double doubleVal = double.MaxValue;
            float floatVal = float.MaxValue;
            decimal decimalVal = decimal.MaxValue;
            string stringVal = "Another string";
            char charVal = 'Y';
            bool boolVal = false;

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
