using System;

namespace ConsoleApp4
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzzGame");
            Console.WriteLine("Enter number (0-100)");
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            if (!int.TryParse(Console.ReadLine(), out var x)) x = 100;
            for (var i = 1; i <= x; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(fizz);
                }

                if (i % 5 == 0)
                {
                    Console.Write(buzz);
                }
                
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}