using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare (but not initialising) 2D array
            string[,] matrix;

            // declare (but not initialising) 3D array
            int[,,] threeD;

            // two-dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9}, // row 2

            };

            Console.WriteLine("The middle value is {0}", array2D[1, 1]);

            // three-dimensional array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up?"}
                },
                // the below must have the same number of rows as the above
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"another one", "last entry"}
                }
            };

            Console.WriteLine("\nThe value is {0}", array3D[1, 1, 0]);
            Console.WriteLine("'Hi there' can be found at 0,2,0: {0}", array3D[0, 2, 0]);
            Console.WriteLine("'last entry' can be found at 1,2,1: {0}", array3D[1, 2, 1]);

            // specify the number of entries
            string[,] array2DString = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"}
            };

            // change 'four' to 'fourteen'
            array2DString[1, 1] = "fourteen";

            Console.WriteLine("\nThe value at 1,1 is now set to {0}", array2DString[1, 1]);

            // find out the number of arrays
            int dimensions = array2DString.Rank;
            Console.WriteLine("\nThe array has this many dimensions: {0}", dimensions);

            Console.ReadLine();
        }
    }
}