using System;
using System.Runtime.CompilerServices;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your input;");
            string myStringInput = Console.ReadLine();
            Console.WriteLine("You entered: " + myStringInput + ".");

            Console.WriteLine(Calculate());
            Console.ReadLine();
        }

        public static int Calculate()
        {
            Console.WriteLine("\nPlease enter the first number: ");
            string myFirstStringNumber = Console.ReadLine();

            Console.WriteLine("Please enter the second number: ");
            string mySecondStringNumber = Console.ReadLine();

            int myFirstIntNumber = int.Parse(myFirstStringNumber);
            int mySecondIntNumber = int.Parse(mySecondStringNumber);
            int result = myFirstIntNumber + mySecondIntNumber;

            return result;
        }
    }
}