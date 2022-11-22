using System;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i * 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} is {1}.", j, nums[j]);
            }

            Console.WriteLine("\n");
            int counter = 0;
            foreach (int k in nums) // data type is same as array
            {
                Console.WriteLine("Element {0} is (still) {1}.", counter, k);
                counter++;
            } // for loops tend to be faster than foreach loops

            Console.ReadLine();
        }
    }
}