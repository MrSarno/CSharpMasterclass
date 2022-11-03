using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOP ONE

            Console.WriteLine("For loop #1 is about to begin.\n");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); // I am deliberately putting them on new lines
            }

            Console.WriteLine("\nFor loop #1 has finished.");

            // LOOP TWO

            Console.WriteLine("\n\nFor loop #2 is about to begin.\n");

            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("\nFor loop #2 has finished.");

            // LOOP THREE

            Console.WriteLine("\n\nFor loop #3 is about to begin.\n");

            for (int k = 0; k < 26; k+=5)
            {
                Console.WriteLine(k + " is lower than " + (k+5) +".");
            }

            Console.WriteLine("\nFor loop #3 has finished.");



            Console.ReadLine();
        }
    }
}