using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = "15";
            string mySecondString = "13";

            string myFirstResult = myFirstString + mySecondString;
            Console.WriteLine("myFirstString + mySecondString = " + myFirstResult + ".");

            string myThirdString = "15";
            string myFourthString = "13";

            int num1 = Int32.Parse(myThirdString);
            int num2 = Int32.Parse(myFourthString);

            int mySecondResult = num1 + num2;
            Console.WriteLine("\n\nmyThirdString + myFourthString = " + mySecondResult + ".");

            Console.ReadLine();
        }
    }
}