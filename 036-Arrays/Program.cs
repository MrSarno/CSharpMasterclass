using System;
using System.ComponentModel.DataAnnotations;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays store a fixed-size sequential collection of elements.");
            Console.WriteLine("Elements must all be of the same type.");
            Console.WriteLine("Arrays can be of all different kinds of types; ints, strings, objects, etc.");
            Console.WriteLine("Arrays are great for storing a collection of data. It is easier to think of a collection of variables of the same type stored at contiguous memory locations.");
            Console.WriteLine("Array indexes begin at 0, incrementing by one each time.");

            // declaring an array
            // dataType[] arrayName;
            // e.g. int[] grades;

            // initialising an array
            // dataType[] arrayName = new dataType[amountOfEntries];
            int[] grades = new int[5];

            // assigning values to an array
            // arrayName[index] = value;
            grades[0] = 39;
            grades[1] = 57;

            Console.ReadLine();
        }
    }
}