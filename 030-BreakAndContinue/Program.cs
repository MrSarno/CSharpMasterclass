using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("The first counter is at {0}", i);
                if(i == 3)
                {
                    Console.WriteLine("\nAt three we stop!\n\n");
                    break;
                }
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 3)
                {
                    Console.WriteLine("\nWe skip number three!\n");
                    continue;
                }
                Console.WriteLine("The second counter is at {0}", j);
            }

            Console.ReadLine();
        }
    }
}