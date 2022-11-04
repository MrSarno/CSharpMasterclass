using MultipleConstructors;
using System;

namespace MultipleConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human("John", "Sweeney", 30, "green");
            john.IntroduceMyself();

            Human basic = new Human();
            basic.IntroduceMyself();

            Human steve = new Human("Steve", "Stevenson", "brown");
            steve.IntroduceMyself();

            Console.ReadLine();
        }
    }
}