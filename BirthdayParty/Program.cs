using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double priceOfCace = rent * 0.2;
            double drinks = priceOfCace - (priceOfCace * 0.45);
            double animator = rent / 3;

            double resut = rent + priceOfCace + drinks + animator;

            Console.WriteLine(resut);
        }
    }
}
