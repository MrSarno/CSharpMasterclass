using System;

namespace Constants
{
    class Program
    {
        // Constants are immutable values
        // which are known at compile time
        // and do not change at any point

        const double Pi = 3.14159265359;
        const int weeks = 52, months = 12;

        static void Main(string[] args)
        {
            Console.WriteLine("Pi is " + Pi + ".");
            Console.WriteLine("There are " + weeks + " weeks in a year.");
            Console.WriteLine("There are " + months + " months in a year.");
            Console.ReadLine();
        }
    }
}