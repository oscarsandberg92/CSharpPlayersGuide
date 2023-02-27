using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuide
{
    public static class HandyConsole
    {
        //TODO:
        // Fix the GetInputClasses so that it has a bool that sets if the console should be cleared or not.
        //      Current problem is that if the wrong input is entered the SetCursorPositions will be messed up.

        private static ConsoleColor GetCurrentBackgroundColor() => Console.BackgroundColor;
        private static ConsoleColor GetCurrentForegroundColor() => Console.ForegroundColor;

        /// <summary>
        /// Prompts the user to enter a value of type double. Stays in the method until a valid input as been entered and then returns the value
        /// </summary>
        /// <param name="message"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static double GetInputAsDouble(string message, double minValue = double.MinValue, double maxValue = double.MaxValue)
        {
            //Console.Clear();
            Console.Write($"{message}");
            string response = "";
            double result = 0;

            while (true)
            {
                response = Console.ReadLine();

                if (response == "") WriteLine("Input cannot be empty, please try again.".PadRight(Console.BufferWidth), ConsoleColor.Red);
                else if (response == null)
                {
                    WriteLine("Input cannot be null, please try again.".PadRight(Console.BufferWidth), ConsoleColor.Red);
                }
                else
                {
                    try
                    {
                        result = Convert.ToDouble(response);
                        if (result < minValue) WriteLine($"Number cannot be less than {minValue}, please try again.", ConsoleColor.Red);
                        else if (result > maxValue) WriteLine($"Number cannot be higher than {maxValue}, please try again.", ConsoleColor.Red);
                        else
                        {
                            //Console.Clear();
                            return result;
                        }
                    }
                    catch
                    {
                        WriteLine($"Could not convert '{response}' to a double value", ConsoleColor.Red);
                    }
                }

                Console.SetCursorPosition(message.Length, 0);
                Console.Write("".PadRight(response == null ? 2 : response.Length));
                Console.SetCursorPosition(message.Length, 0);
            }
        }

        /// <summary>
        /// Prompts the user to enter a value of type int. Stays in the method until a valid input as been entered and then returns the value
        /// </summary>
        /// <param name="message"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetInputAsInt(string message, bool clearBefore = false, bool clearAfter = false, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {

            if (clearBefore) Console.Clear();
            Console.Write($"{message}");
            string? response = "";
            int result;

            int currentRow = Console.CursorTop;

            while (true)
            {
                response = Console.ReadLine();

                if (response == "") 
                    WriteLine("Input cannot be empty, please try again.".PadRight(Console.BufferWidth), ConsoleColor.Red);
                
                else if (response == null)
                    WriteLine("Input cannot be null, please try again.".PadRight(Console.BufferWidth), ConsoleColor.Red);
                
                else
                {
                    try
                    {
                        result = Convert.ToInt32(response);
                        if (result < minValue) 
                            WriteLine($"Number cannot be less than {minValue}, please try again.", ConsoleColor.Red);
                        
                        else if (result > maxValue) 
                            WriteLine($"Number cannot be higher than {maxValue}, please try again.", ConsoleColor.Red);
                        
                        else 
                        {
                            currentRow = Console.CursorTop;
                            ClearLine(0, currentRow, Console.BufferWidth);
                            
                            if(clearAfter) Console.Clear();
                            
                            return result;
                        }
                    }

                    catch
                    {
                        WriteLine($"Could not convert '{response}' to an integer value".PadRight(Console.BufferWidth), ConsoleColor.Red);
                    }
                }
                int inputRow = Console.CursorTop - 2;
                int lengthToClear = response == null ? 2 : response.Length;
                ClearLine(message.Length, inputRow, lengthToClear);
            }
        }

        private static void ClearLine(int left, int top, int length)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("".PadRight(length));
            Console.SetCursorPosition(left, top);
        }

        /// <summary>
        /// Prompts the user to enter a value of type string. Stays in the method until a valid input as been entered and then returns the value
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string GetInputAsString(string message)
        {
            Console.Clear(); 
            Console.Write($"{message}");
            string response = "";

            while (true)
            {
                response = Console.ReadLine();

                if (response == "") WriteLine("Input cannot be empty, please try again.", ConsoleColor.Red);
                else if (response == null) WriteLine("Input cannot be null, please try again.", ConsoleColor.Red);
                else
                {
                    Console.Clear();
                    return response;
                }

                Console.SetCursorPosition(message.Length, 0);
                Console.Write($"{"".PadRight(10)}");
                Console.SetCursorPosition(message.Length, 0);
            }

        }

        public static void InitializeSettings(ConsoleColor textColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
        }

        public static int Menu(string[] menuOptions) => Menu(menuOptions, "", ConsoleColor.Yellow);

        public static int Menu(string[] menuOptions, string menuHeader) => Menu(menuOptions, menuHeader, ConsoleColor.Yellow);

        public static int Menu(string[] menuOptions, ConsoleColor highlightColor) => Menu(menuOptions, "", highlightColor);

        /// <summary>
        /// Prints an arrowkey driven menu. Return the menuchoice and as integer and if user decides to exit the menu -1 will be returned
        /// Called with  a menuheader, highlight color and menuoptions.
        /// </summary>
        /// <param name="menuOptions"></param>
        /// <returns></returns>
        public static int Menu(string[] menuOptions, string menuHeader, ConsoleColor highlightColor = ConsoleColor.Yellow, bool builtInExit = true, bool wrapAround = true)
        {
            Console.Clear();
            Console.CursorVisible = false;

            ConsoleColor defaultColor = Console.ForegroundColor;
            int currentIndex = 0;
            int lastIndex = 0;
            int longestOption = menuOptions.Max(x => x.Length);
            int rowStart = menuHeader == "" ? 0 : 2;

            if (menuHeader != "") WriteLine($"{menuHeader.ToUpper()}\n");

            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == currentIndex) WriteLine($"{menuOptions[i].PadRight(longestOption)} <-", highlightColor);
                else WriteLine(menuOptions[i]);
            }
            if (builtInExit) WriteLine("\nPress Esc to exit");

            while (true)
            {
                var keyPressed = Console.ReadKey(true);
                

                if (keyPressed.Key == ConsoleKey.DownArrow && menuOptions.Length != 1)
                {
                    if (currentIndex == menuOptions.Length - 1)
                    {
                        if (!wrapAround) continue;
                        currentIndex = 0;
                        lastIndex = menuOptions.Length - 1;
                    }
                    else
                    {
                        currentIndex++;
                        lastIndex = currentIndex - 1;
                    }
                }

                if (keyPressed.Key == ConsoleKey.UpArrow && menuOptions.Length != 1)
                {
                    if (currentIndex == 0)
                    {
                        if (!wrapAround) continue;
                        currentIndex = menuOptions.Length - 1;
                        lastIndex = 0;
                    }
                    else
                    {
                        currentIndex--;
                        lastIndex = currentIndex + 1;
                    }
                }

                if (keyPressed.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return currentIndex;

                }

                if (keyPressed.Key == ConsoleKey.Escape && builtInExit)
                {
                    Console.Clear();
                    return -1;

                }

                if (menuOptions.Length < 2) continue;

                Console.SetCursorPosition(0, currentIndex + rowStart);
                WriteLine($"{menuOptions[currentIndex].PadRight(longestOption)} <-", highlightColor);

                Console.SetCursorPosition(0, lastIndex + rowStart);
                WriteLine($"{menuOptions[lastIndex].PadRight(longestOption + 3)}", defaultColor);
            }
        }


        public static void Write(string message) =>
            Console.Write(message);

        public static void Write(string message, ConsoleColor textColor)
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = textColor;
            Console.Write(message);
            Console.ForegroundColor = previousColor;
        }

        /// <summary>
        /// Writes the string parameter to the console
        /// </summary>
        /// <param name="message"></param>
        public static void WriteLine(string message) =>
            Console.WriteLine(message);

        /// <summary>
        /// Writes the string parameter in the given color
        /// </summary>
        /// <param name="message"></param>
        /// <param name="textColor"></param>
        public static void WriteLine(string message, ConsoleColor textColor)
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = textColor;
            Console.WriteLine(message);
            Console.ForegroundColor = previousColor;
        }

        public static void WaitForUser(string message) => WaitForUser(message, Console.ForegroundColor, false, false);

        public static void WaitForUser(string message, ConsoleColor textColor) => WaitForUser(message, textColor, false, false);

        public static void WaitForUser(string message, bool clearBefore, bool clearAfter)
            => WaitForUser(message, Console.ForegroundColor, clearBefore, clearAfter);

        public static void WaitForUser(string message, ConsoleColor textColor, bool clearBefore, bool clearAfter)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = textColor;

            if (clearBefore) Console.Clear();

            WriteLine(message, textColor);

            Console.ReadKey();

            if (clearAfter) Console.Clear();

            Console.ForegroundColor = defaultColor;
        }
    }
}
