namespace GetMinValueUsingParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min1 = MinV2(6, 4, 2, 8, 0, 1, 5);
            int min2 = MinV2(5, 1, -11, 40, 12);
            int min3 = MinV2(404, 429, 500, 403, 301, 200, 501);

            Console.WriteLine("The smallest value in the first range provided was {0}.", min1);
            Console.WriteLine("The smallest value in the second range provided was {0}.", min2);
            Console.WriteLine("The smallest value in the third range provided was {0}.", min3);

            Console.ReadLine();
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue; // Setting the variable to an implausably high value initially.
            // Among other uses, this is helpful for testing as 'min' being set to 2,147,483,647
            // could be assumed to be a sign that the method is not functioning correctly.

            foreach (int number in numbers)
            {
                if (min > number)
                    min = number;
            }

            return min;
        }
    }
}