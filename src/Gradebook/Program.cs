using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 11.2;
            double result = x + y;

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
                Console.WriteLine($"The result is {result}");
            }
            else
            {
                Console.WriteLine("Hi");
            }
        }
    }
}
