using System;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string username = "";

            Console.WriteLine("Please enter your username;");
            username = Console.ReadLine();

            if(username.Equals("MrSarno"))
            {
                isAdmin = true;
            }

            if(isRegistered)
            {
                if(username != "")
                {
                    Console.WriteLine("\nWelcome, " + username + ".");
                }
                else {
                    Console.WriteLine("\nWelcome, registered user.");
                }    
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }

            if (isAdmin)
            {
                Console.WriteLine("Administrator privileges are available.");
            }

            Console.ReadLine();
        }
    }
}