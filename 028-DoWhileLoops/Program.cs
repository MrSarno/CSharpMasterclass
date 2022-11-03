using System;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);


            Console.ReadLine();
        }
    }
}