using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFirstNumber = 12;
            int mySecondNumber = 13;
            int myThirdNumber;

            // unary operators

            myThirdNumber = -myFirstNumber;
            Console.WriteLine("myThirdNumber is " + myThirdNumber + ".");

            bool isSunny = true;
            Console.WriteLine("\nIs it sunny? {0}", !isSunny);

            int myFourthNumber = 1;
            myFourthNumber++;

            Console.WriteLine("\nmyFourthNumber is {0}", myFourthNumber);
            Console.WriteLine("myFourthNumber is {0}", myFourthNumber++); // +1, after number is displayed
            Console.WriteLine("myFourthNumber is {0}", myFourthNumber);
            Console.WriteLine("myFourthNumber is {0}", ++myFourthNumber); // +1, before number is displayed

            int myFifthNumber = 10;

            Console.WriteLine("\nmyFifthNumber is {0}", myFifthNumber);
            Console.WriteLine("myFifthNumber is {0}", myFifthNumber--);
            Console.WriteLine("myFifthNumber is {0}", myFifthNumber);
            Console.WriteLine("myFifthNumber is {0}", --myFifthNumber);

            int mySixthNumber = myFirstNumber + mySecondNumber;
            Console.WriteLine("\nmyFirstNumber + mySecondNumber = {0}", mySixthNumber);

            int mySeventhNumber = myFirstNumber - mySecondNumber;
            Console.WriteLine("myFirstNumber - mySecondNumber = {0}", mySeventhNumber);

            int myEighthNumber = myFirstNumber * mySecondNumber;
            Console.WriteLine("myFirstNumber x mySecondNumber = {0}", myEighthNumber);

            int myNinthNumber = myFirstNumber / mySecondNumber;
            Console.WriteLine("myFirstNumber / mySecondNumber = {0}", myNinthNumber);

            int myTenthNumber = myFirstNumber % mySecondNumber;
            Console.WriteLine("myFirstNumber % mySecondNumber = {0}", myTenthNumber);

            // relational, type operators

            bool isHigher;
            isHigher = myFirstNumber > mySecondNumber;
            Console.WriteLine("\nIs myFirstNumber bigger than mySecondNumber? {0}", isHigher);

            bool isEqual;
            isEqual = myFirstNumber == mySecondNumber;
            Console.WriteLine("Is myFirstNumber equal to mySecondNumber? {0}", isEqual);

            bool isInequal;
            isInequal = myFirstNumber != mySecondNumber;
            Console.WriteLine("Is myFirstNumber different than mySecondNumber? {0}", isInequal); // alternatively, isInequal = !isEqual

            // conditional operators

            bool isHigherAndSunny;
            isHigherAndSunny = isHigher && isSunny;
            Console.WriteLine("\nisHigherAndSunny = " + isHigherAndSunny);

            bool isHigherOrSunny;
            isHigherOrSunny = isHigher || isSunny;
            Console.WriteLine("isHigherOrSunny = " + isHigherOrSunny);

            Console.ReadLine();
        }
    }
}