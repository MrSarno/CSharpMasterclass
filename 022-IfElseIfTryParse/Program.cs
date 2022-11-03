using System;

namespace IfElseIfTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current temperature in degrees Celsius?");
            string currentTemperature = Console.ReadLine();
            int currentTemperatureInt;
            int numberPlaceholder;
            
            if(int.TryParse(currentTemperature, out numberPlaceholder))
            {
                currentTemperatureInt = numberPlaceholder;
            }
            else
            {
                currentTemperatureInt = 0;
                Console.WriteLine("Input not recognised - please only enter numbers. Setting temperature to 0.");
            }

            if(currentTemperatureInt < 20)
            {
                Console.WriteLine("A t-shirt and shorts should be fine.");
            }
            else if(currentTemperatureInt == 20)
            {
                Console.WriteLine("Wear a shirt and a pair of jeans.");
            }
            else if(currentTemperatureInt > 30)
            {
                Console.WriteLine("Bring a warm jacket with you.");
            }
            else
            {
                Console.WriteLine("Bring a light jacket with you.");
            }

            Console.ReadLine();
        }
    }
}