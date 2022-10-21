using System;

namespace SomeStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // SubString(int32)
            Console.WriteLine("The SubString method is used to extract part of a string, beginning at the specified index.");

            // ToLower()
            Console.WriteLine("The ToLower method is used to convert the string to lowercase.");

            // ToUpper()
            Console.WriteLine("The ToUpper method is used to convert the string to uppercase.");

            // Trim()
            Console.WriteLine("The Trim method is used to remove all leading and trailing whitespace.");

            // IndexOf(string)
            Console.WriteLine("The IndexOf method is used too get the first occurrence of the string or character inside the string.");

            // IsNullOrWhiteSpace
            Console.WriteLine("The IsNullOrWhiteSpace method will return true if the string is either null or blank. Otherwise it will return false.");

            // Format
            Console.WriteLine("The Format method is used to replace the value in the specified format."); // e.g. String.Format("My name is {0}", name)

            Console.ReadLine();
        }
    }
}