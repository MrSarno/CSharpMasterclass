using System;

namespace ImplicitAndExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble; // An example of explicit conversion
            Console.WriteLine("My int is " + myInt + ".");
            //Console.Read();

            int myFirstBigNum = 12390532;
            long mySecondBigNum = myFirstBigNum; // An example of implicit conversion

            Console.WriteLine("\n\nMy next int is " + myFirstBigNum + ".");
            Console.WriteLine("My long is " + mySecondBigNum + ".");

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            Console.WriteLine("\n\nMy float is " + myFloat + ".");
            Console.WriteLine("My long is " + myNewDouble + ".");

            string myString = myNewDouble.ToString();
            Console.WriteLine("\n\nMy string is '" + myString + "'.");

            Console.Read();
        }
    }
}