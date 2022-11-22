using System;

namespace ArraysContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialise
            int[] grades = new int[5];
            grades[0] = 87;
            grades[1] = 39;
            grades[2] = 93;
            grades[3] = 57;
            grades[4] = 71;
            Console.WriteLine("Grade at index 0: {0}.", grades[0]);

            Console.WriteLine("This student has lodged an appeal. Please enter their revised grade;");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("Grade at index 0 has been changed to: {0}.", grades[0]);

            Console.WriteLine("\n----\n");

            // alternative way of initialising an array
            int[] maths_grades = { 43, 31, 25, 45, 67 };

            // another way again to initialise an array
            int[] art_grades = new int[] { 83, 76, 93, 78, 68 };

            Console.WriteLine("The number of maths students is: {0}.", maths_grades.Length);

            Console.ReadLine();
        }
    }
}