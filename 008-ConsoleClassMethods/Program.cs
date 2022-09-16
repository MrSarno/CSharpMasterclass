namespace ConsoleClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This will leave the cursor on the same line.");
            Console.WriteLine("This will put the cursor on a new line.");
            Console.Read(); // Take a single input of type string; return the ASCII value of that input.
            Console.ReadLine(); // Take input (string or int) and return it as the output. Does not return it as ASCII.
            Console.ReadKey(); // Take the input of a single character.

            Console.ReadLine(); // My favourite! I (ab)use this to keep the console window open so text can be viewed. :)
        }
    }
}