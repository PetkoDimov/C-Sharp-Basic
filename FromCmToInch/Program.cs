using System;

namespace FromCmToInch
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            Double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
