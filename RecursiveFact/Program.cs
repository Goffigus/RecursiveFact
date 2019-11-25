using System;

namespace RecursiveFact
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;

            string input = Console.ReadLine();

            f = Convert.ToInt32(input);

            
            Console.WriteLine("The Factorial is {0}", fact(f));

        }

        private static int fact(int f)
        {
            if (f == 0)
            {
                return 1;
            }
            else
            {
                return f * fact(f - 1);
            }
        }
    }
}
