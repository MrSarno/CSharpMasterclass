using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human("John", "Sweeney", 30, "green");
            john.IntroduceMyself();

            Console.ReadLine();
        }
    }
}