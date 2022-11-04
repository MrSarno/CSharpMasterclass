using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human();

            // acces public variable from outside, and even change it
            john.firstName = "John";
            john.IntroduceMyself();

            Human andrew = new Human();
            andrew.IntroduceMyself();
            // I haven't set andrew.firstName

            Console.ReadLine();
        }
    }
}