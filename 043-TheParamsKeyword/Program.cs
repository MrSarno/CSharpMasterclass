namespace TheParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The price is {0}, pi is {1}, and at is {2}.", 32, 3.14, '@');
            Console.WriteLine("\n{0} + {1} + {2} + {3} + {4} + {5} + {6} + {7} = {8}.", 1, 2, 3, 4, 5, 6, 7, 8, 1 + 2 + 3 + 4 + 5 + 6 + 7);

            ParamsMethod("\nThis ", "is ", "a ", "stupid ", "long ", "string ", "I ", "have ", "no ", "idea ", "when ", "it ", "will ", "end.");

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The C Programming Language, 2nd Edition";

            ParamsMethodTwo(price, pi, at, book);

            ParamsMethodTwo("Hello", 5.3, '$');

            Console.ReadLine();
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]); // This won't add spaces between the strings, so the spaces must be included above if they are desired.
            }
        }

        public static void ParamsMethodTwo(params object[] stuff)
        {
            Console.WriteLine("\n");
            foreach (object obj in stuff)
            {
                // print each object followed by a space
                Console.Write(obj + " ");
            }
        }
    }
}