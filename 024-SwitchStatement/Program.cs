using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 25; // change variable value to explore different program behaviours

            switch(myAge)
            {
                case 15:
                    Console.WriteLine("Too young to be allowed entry.");
                    Console.ReadLine();
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("How old are you, then?");
                    Console.ReadLine();
                    break;
            }
        }
    }
}