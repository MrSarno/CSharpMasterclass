using System;
using System.Runtime.CompilerServices;

namespace MultipleConstructors
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColour;

        // default constructor
        public Human()
        {
            Console.WriteLine("\n[Constructor called. Object has been created.]");
        }

        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        // parameterised constructor
        public Human(string firstName, string lastName, int age, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColour = eyeColour;
        }

        public void IntroduceMyself()
        {
            if (age != 0)
            {
                Console.WriteLine("\nHi, I'm {0} {1}.", firstName, lastName);
                Console.WriteLine("I am {0} years old and I have {1} eyes.", age, eyeColour);
            }
            else
            {
                Console.WriteLine("\nHi, I'm {0} {1}, and I have {2} eyes.", firstName, lastName, eyeColour);
            }
        }
    }
}