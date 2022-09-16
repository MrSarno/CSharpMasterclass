using System;

namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A value type holds data directly in its own memory space. It uses a heap to store the value.\n");
            Console.WriteLine("Value types include: int, float, long, double, char, bool, decimal, and double.\n\n");
            Console.WriteLine("Reference types instead store the memory location of the actual data.\n");
            Console.WriteLine("Reference types include: string, class, array.");
            Console.ReadLine();
        }
    }
}