using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression;
            // condition has to be either true or false

            // The conditional operator is right - associative.
            // The expression a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e),
            // not as (a ? b : c) ? d : e.

            // The conditional operator cannot be overloaded.

            int temperatureCelsius = -5;
            string stateOfMatter;

            // if(temperatureCelsius < 0)
            // {
            //     stateOfMatter = "solid";
            // }
            // else
            // {
            //     stateOfMatter = "liquid";
            // }

            // or, in short
            stateOfMatter = temperatureCelsius < 0 ? "solid" : "liquid";

            Console.WriteLine("The state of matter is: {0}.", stateOfMatter);
            Console.ReadLine();
        }
    }
}