using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide.Exercises.Vin_Fletchers_Arrows
{

    internal class Arrow
    {
        public ArrowHeadType ArrowHead { get; private set; }
        public FletchingType Fletching { get; private set; }
        public int Length { get; private set; }

        public Arrow(ArrowHeadType arrowHead, FletchingType fletching, int length)
        {
            ArrowHead = arrowHead;
            Fletching = fletching;
            Length = length;
        }

        public float GetCost()
        {
            int headPrice = ArrowHead == ArrowHeadType.Steel ? 10 : ArrowHead == ArrowHeadType.Wood ? 3 : 5;

            int fletchingPrice = Fletching == FletchingType.Plastic ? 10 : Fletching == FletchingType.Turkeyfeathers ? 5 : 3;

            float shaftPrice = Length * 0.05f;

            return headPrice + fletchingPrice+ shaftPrice;
        }

        public static Arrow EliteArrow() => new Arrow(ArrowHeadType.Steel, FletchingType.Plastic, 95);
        public static Arrow BeginnerArrow() => new Arrow(ArrowHeadType.Wood, FletchingType.Goosefeathers, 75);
        public static Arrow MarksmanArrow() => new Arrow(ArrowHeadType.Steel, FletchingType.Goosefeathers, 65);
        public static Arrow CustomArrow()
        {
            int headType = HandyConsole.Menu(new[] { "Steel", "Wood", "Obsidian" },
                "Pick a arrow head type:", ConsoleColor.Green, builtInExit: false);

            int fletchingType = HandyConsole.Menu(new[] { "Plastic", "Turkeyfeathers", "Goosefeathers" },
                "Pick a fletching type:", ConsoleColor.Green, builtInExit: false);

            int length = HandyConsole.GetInputAsInt("Enter desired shaft length: ", minValue: 10, maxValue: 100);

            return new((ArrowHeadType)headType, (FletchingType)fletchingType, length);
        }

    }
}
