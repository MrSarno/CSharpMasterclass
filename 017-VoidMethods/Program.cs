using System;
using System.Threading.Tasks.Dataflow;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
        }

        public static void WriteSomething() // must be static as Main is static
        {
            Console.WriteLine("I am called from a method.");
            Console.ReadLine();
        }
    }
}