using System;

namespace fruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfStrallberries = double.Parse(Console.ReadLine());
            double kilosOfBananas = double.Parse(Console.ReadLine());
            double kilosOfOranges = double.Parse(Console.ReadLine());
            double kilosOfBerries = double.Parse(Console.ReadLine());
            double kilosOfStrallberries = double.Parse(Console.ReadLine());

            double priceOfBerries = priceOfStrallberries / 2;
            double priceOfOranges = priceOfBerries - (priceOfBerries * 0.4);
            double priceofBananas = priceOfBerries - (priceOfBerries * 0.8);

            double resultStrallberries = kilosOfStrallberries * priceOfStrallberries;
            double resultBananas = kilosOfBananas * priceofBananas;
            double resultOranges = kilosOfOranges * priceOfOranges;
            double resultBerries = kilosOfBerries * priceOfBerries;

            double neeededSum = resultStrallberries + resultBananas + resultOranges + resultBerries;

            Console.WriteLine(neeededSum) ;
        }
    }
}
