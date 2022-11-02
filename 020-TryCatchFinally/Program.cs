using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number;");
            string userInput = Console.ReadLine();

            try
            {
                int UserInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception! Please enter your input using only numerical characters next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception! Please enter a differently sized number next time.");
            }
            catch (Exception) // ArgumentNullException is technically possible, however a user would instead submit an empty string.
            {
                Console.WriteLine("There was an error. Please try again.");
            }
            finally
            {
                Console.WriteLine("This will be shown no matter what!");
            }

            Console.ReadLine();
        }
    }
}