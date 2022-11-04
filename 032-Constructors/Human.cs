using System;
using System.Runtime.CompilerServices;

namespace Constructors
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColour;

        // constructor
        public Human(string firstName, string lastName, int age, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColour = eyeColour;
        }

        public void IntroduceMyself()
        {
            if (age > 5) // babies don't talk!
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
                Console.WriteLine("I am {0} years old and I have {1} eyes.", age, eyeColour);
            }
        }
    }
}