using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());

            int depositLenght = int.Parse(Console.ReadLine());

            double anualInterest = double.Parse(Console.ReadLine());

            double acumulatedInterest = (deposit * anualInterest) / 100;

            double interes = acumulatedInterest / 12;

            double result = deposit + (depositLenght * interes);

            Console.WriteLine(result);
        }
    }
}
