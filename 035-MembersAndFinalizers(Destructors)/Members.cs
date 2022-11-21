using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalizers
{
    internal class Members
    {
        // member - private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely
        // properties start with a capital letter!
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and I am a {1}. I am {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}.", salary);
        }

        // member - constructor
        public Members()
        {
            age = 45;
            memberName = "Stephen";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("[Object created.]");
        }

        // member - finalizer (previously known as destructor)
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("[Deconstruction of Members object.]");
            // only have one of these if it is important
            // empty finalizers are bad for performance
            Debug.Write("[DEBUG] Destruction of Members object.");
        }
    }
}
