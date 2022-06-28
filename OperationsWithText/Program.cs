using System;

namespace OperationsWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, I am {name}!");
            Console.WriteLine($"I am, {age} years old!");
        }
    }
}
