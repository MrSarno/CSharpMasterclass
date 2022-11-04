using System;
using System.Runtime.CompilerServices;

namespace Classes
{
	// this class is a blueprint for a datatype
	public class Human
	{
		// member variable
		public string firstName = "still waiting for a name"; // seems like as good a PH as any!

		// member method
		public void IntroduceMyself()
		{
			Console.WriteLine("\nHi, I'm {0}.", firstName);
		}
	}
}