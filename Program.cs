using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string fizz,buzz;
            fizz = "Fizz";
            buzz = "Buzz";
            Console.WriteLine("FizzBuzzGame");
            Console.WriteLine("Enter number (0-100)");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                }
               else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
               else if (i % 3 == 15)
                {
                    Console.WriteLine(fizz + buzz);
                }

                Console.WriteLine(i);
            }
        }
    }
}
