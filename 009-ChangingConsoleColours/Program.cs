using System;

namespace ChangingConsoleColours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.Clear(); // Using this to apply the background colour to
            // the entire console window, not just behind the foreground text.

            Console.WriteLine("Hello, colour palette!");
            Console.ReadLine();
        }
    }
}