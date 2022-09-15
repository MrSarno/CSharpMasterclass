using System;

namespace MoreDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 20000000;
            // whole numbers between -2,147,483,648 and 2,147,483,647

            sbyte var2 = 120; // signed byte
            // whole numbers between -128 & 127

            short var3 = 30000;
            // whole numbers between -32,767 & 32,767

            long var4 = 90000000000000000;
            // whole numbers from -9,223,372,036,854,775,808 and
            // 9,223,372,036,854,775,807

            float var5 = 99.99f;
            // 7-digit precision

            // often used for graphics libraries

            double var6 = 1.5;
            // 15-digit precision

            // often used for real-world values

            decimal var7 = 1.5m;
            // 28-digit precision

            // often used in financial applications

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.ReadLine();
        }
    }
}