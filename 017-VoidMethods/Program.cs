using System;
using System.Threading.Tasks.Dataflow;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("\nI am an argument and I am called from a method.");
        }

        public static void WriteSomething() // must be static as Main is static
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.ReadLine();
        }
    }
}