using System;

namespace ReturnValuesAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = Add(46, 72);
            // Console.WriteLine(result);

            Console.WriteLine(Add(46, 72));

            Console.WriteLine(Add(Add(1, 2), Add(5, 6)));

            Console.WriteLine(Multiply(5,10));

            Console.WriteLine(Divide(4, 2));

            Console.ReadLine();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}