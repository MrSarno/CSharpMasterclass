using System;

namespace MoreDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers

            int num1;
            num1 = 13;
            Console.WriteLine(num1);

            int num2 = 23;

            int num3 = num1 + num2;
            Console.WriteLine(num3);

            Console.WriteLine("num1 (" + num1 + ") + num2 (" + num2 + ") is " + num3 + ".");
            Console.WriteLine("\n----\n");

            // doubles

            double num4, num5, num6;

            num4 = 3.1415;
            num5 = 5.1;
            num6 = num4 / num5;
            Console.WriteLine("num4 / num5 = " + num6 + ".");
            Console.WriteLine("\n----\n");

            // floats

            float num7, num8, num9;

            num7 = 3.1415f;
            num8 = 5.1f;
            num9 = num7 / num8;
            Console.WriteLine("num7 / num8 = " + num9 + ".");

            Console.ReadLine();
        }
    }
}