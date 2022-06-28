using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * high;

            double liters = (volume * 0.001)*(1-(percent /100));

            Console.WriteLine(liters);
        }
    }
}
