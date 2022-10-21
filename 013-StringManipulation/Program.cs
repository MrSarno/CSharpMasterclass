using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some variables
            string firstName = "John";
            int improbableAge = 5;
            string currentJob = "developer";

            // 1. String concatenation
            Console.WriteLine("1. String concatenation");
            Console.WriteLine("Hello, my name is " + firstName + " and I am " + improbableAge + " years old. I am a " + currentJob + ".");

            // 2. String formatting
            // string formatting uses index
            Console.WriteLine("\n2. String formatting");
            Console.WriteLine("Hello, my name is {0} and I am {1} years old. I am a {2}.", firstName, improbableAge, currentJob);

            // 3. String interpolation
            Console.WriteLine("\n3. String interpolation");
            Console.WriteLine($"Hello, my name is {firstName} and I am {improbableAge} years old. I am a {currentJob}.");

            // 4. Verbatim strings
            // will ignore any escape characters
            Console.WriteLine("\n4. Verbatim strings");
            Console.WriteLine(@"Hello, 
my name is John and I am 5 years old. I am     a developer.");
            Console.WriteLine(@"This can be particularly handy for filepaths,
e.g. C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");

            // Keep window open so text can actually be seen
            Console.ReadLine();
        }
    }
}