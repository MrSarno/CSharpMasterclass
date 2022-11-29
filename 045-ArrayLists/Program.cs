using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList1 = new ArrayList();               // no fixed size
            ArrayList myArrayList2 = new ArrayList(20);     // capacity of 20

            myArrayList1.Add(1);
            myArrayList1.Add("Hello");
            myArrayList1.Add(404);
            myArrayList1.Add(13);
            myArrayList1.Add(128);
            myArrayList1.Add("there");

            myArrayList1.Remove(128); // this will remove '128' from the array list

            myArrayList1.RemoveAt(2); // this will remove the third item (404)

            Console.WriteLine("The count of myArrayList1 is: {0}.", myArrayList1.Count);

            double sum = 0;

            foreach(object obj in myArrayList1)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine("The object is: {0}.", obj);
                }
            }
            Console.WriteLine("The sum is: {0}.", sum);

            Console.ReadLine();
        }
    }
}