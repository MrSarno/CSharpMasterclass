using System;

namespace NamingConventions
{
    class Program // Pascal case: e.g. ClientActivity
    {
        static void Main(string[] args) // Pascal case: e.g. MyMethodName
        {

            int myAge = 30; // Camel case

            // Use full words; e.g. userControl; not UsrCtr

            // Don't use numbers at the start of variable names

            // Avoid capitalising variable types, e.g. int, not Int

            Console.WriteLine("Hello, World!");
            Console.WriteLine("\nI am currently " + myAge + " years old.");
            Console.ReadLine();

            // https://www.dofactory.com/csharp-coding-standards is a great reference
        }
    }
}