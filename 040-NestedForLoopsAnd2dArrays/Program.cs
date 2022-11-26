using System.Diagnostics.Metrics;

namespace NestedForLoopsAnd2dArrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Using a Foreach loop;\n");
            foreach (int item in matrix)
            {
                Console.Write(item + " "); // Console.WriteLine would put each element on its own line
            }
            
            Console.WriteLine("\n\nUsing nested For loops;\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine("\n\nAnd now we'll modify the array;\n");

            for (int i = 0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    int random_int = rnd.Next(1,225);
                    matrix[i, j] = random_int;
                    Console.Write(matrix[i, i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}