using System.Linq.Expressions;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40 };

            foreach (int element in numbers)            // foreach loop
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n\n--\n\n");

            for (int i = 0; i < numbers.Count; i++)     // for loop
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}