using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loops
            Console.WriteLine("FOR loops run a number of times that depend on the starting value and the increment.");

            // while loops
            Console.WriteLine("\nWHILE loops run a number of times that depend on the condition continuing to be met.");
            Console.WriteLine("Ensure that you are incrementing within the loop!");

            // do while loops
            Console.WriteLine("\nDO WHILE loops run a number of times that depend on the condition being met, but will always run at least once.");

            // foreach loops
            Console.WriteLine("\nFOREACH loops run a number of times that depend on the amount of content.");
            Console.WriteLine("Largely won't be looking at these until we have covered arrays.");

            Console.ReadLine();
        }
    }
}