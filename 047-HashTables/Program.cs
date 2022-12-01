using System;
using System.Collections;

namespace HashTables
{
    // e.g. Auto (German) - Car (English)
    // limitation of only one "translation";
    // Hash Tables operate using key - value pairs

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();                      // create, initialise empty hash table

            Student pupil1 = new Student(1, "Siún", 96);
            Student pupil2 = new Student(2, "Dave", 72);
            Student pupil3 = new Student(3, "Mary", 53);
            Student pupil4 = new Student(4, "Sean", 84);

            studentsTable.Add(pupil1.Id, pupil1);
            studentsTable.Add(pupil2.Id, pupil2);
            studentsTable.Add(pupil3.Id, pupil3);
            studentsTable.Add(pupil4.Id, pupil4);

            // retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[pupil1.Id];     // cast object to student

            Console.WriteLine("Student ID: {0}, Name: {1}, Grade: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.Grade);

            Console.WriteLine(value: "\n----");

            // retrieve all values from a hash table
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;

                Console.WriteLine("\nStudent ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student Grade: {0}", temp.Grade);
            }

            Console.WriteLine(value: "\n----");

            // simplify foreach loop
            foreach(Student value in studentsTable.Values)
            {
                Console.WriteLine("\nStudent ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student Grade: {0}", value.Grade);
            }
            
            Console.ReadLine();
        }
    }

    class Student
    {
        // property called Id
        public int Id { get; set; }

        // property called Name
        public string Name { get; set; }

        // property called Grade
        public float Grade { get; set; }

        // simple constructor
        public Student(int id, string name, float grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }
    }
}