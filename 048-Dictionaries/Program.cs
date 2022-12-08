using System;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // similar to hash tables, dictionaries store key : value pairs

            // Dictionary<TKey, TValue>
            Dictionary<int, string> myDictionaryOne = new Dictionary<int, string>();

            Dictionary<int, string> myDictionaryTwo = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            Employee[] employees =
            {
                new Employee("CEO", "Sarah", 53,200),
                new Employee("Manager", "Lauren", 41,120),
                new Employee("HR", "Simon", 43,40),
                new Employee("Secretary", "Matt", 32,35),
                new Employee("Lead Developer", "Ciara", 39,185),
                new Employee("Intern", "Stephen", 21,12),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp); // makes the assumption there is only one employee per role
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return they key value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                // store the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // print the properties of the employee object
                Console.WriteLine("\n\nEmployee name: {0}", employeeValue.Name);
                Console.WriteLine("Employee role: {0}", employeeValue.Role);
                Console.WriteLine("Employee age: {0}", employeeValue.Age);
                Console.WriteLine("Employee salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory["CEO"];
                Console.WriteLine("\n\nEmployee name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("\nNo employee found with this key: {0}", key);
            }

            Employee result = null;

            // using TryGetValue() it returns true if the operation was successful; otherwise, it returns false
            if (employeesDirectory.TryGetValue(key: "Intern", out result))
            {
                Console.WriteLine("\n\nValue retrieved!");

                Console.WriteLine("\nEmployee name: {0}", result.Name);
                Console.WriteLine("Employee role: {0}", result.Role);
                Console.WriteLine("Employee age: {0}", result.Age);
                Console.WriteLine("Employee salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        // few properties like name & age
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
                // hourly pay x number of work hours per day x number of days per
                // week x number of weeks per month x number of months per year
            }
        }

        // simple constructor
        public Employee (string role, string name, int age, float Rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }
}