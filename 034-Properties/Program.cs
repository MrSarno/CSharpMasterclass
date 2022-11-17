using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            box.Height = -4;
            box.Width = 5;

            Console.WriteLine("The volume of the box is " + box.GetVolume() + ".");
            Console.ReadLine();
        }
    }
}