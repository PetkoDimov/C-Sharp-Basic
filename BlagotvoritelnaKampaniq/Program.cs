using System;

namespace BlagotvoritelnaKampaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int torti = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int palachinki = int.Parse(Console.ReadLine());
            double cenaTorti = torti * 45;
            double cenaGofreti = gofreti * 5.80;
            double cenaPalachinki = palachinki * 3.20;

            double total = ((cenaTorti + cenaGofreti + cenaPalachinki) * bakers) * days;
            double endResult = total - (total / 8);
            Console.WriteLine(endResult);
        }
    }
}
