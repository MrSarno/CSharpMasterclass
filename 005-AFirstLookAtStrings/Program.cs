using System;

namespace AFirstLookAtStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = "John";
            string printMyFirstName = "My name is " + myFirstName + ".";
            Console.WriteLine(printMyFirstName);
            Console.WriteLine("\n");

            string printANewSentence = "This sentence will be displayed with various different capitalisations.";
            Console.WriteLine(printANewSentence);
            Console.WriteLine(printANewSentence.ToUpper());
            Console.WriteLine(printANewSentence.ToLower());

            string printTheSameSentenceInAllCaps = printANewSentence.ToUpper();
            Console.WriteLine(printTheSameSentenceInAllCaps);

            Console.ReadLine();
        }
    }
}