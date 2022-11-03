using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // while(counter < 10)
            // {
            //     Console.WriteLine(counter);
            //     counter++;
            // }

            string enteredText = "";

            while(enteredText.Equals(""))
            {
                counter++;
                Console.WriteLine("\nPlease press Enter if you wish to keep going.");
                Console.WriteLine("Press any other button, then Enter, to stop.");
                Console.WriteLine("Current count is: {0}.", counter);
                enteredText = Console.ReadLine();
            }
        }
    }
}