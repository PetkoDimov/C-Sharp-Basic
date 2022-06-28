using System;

namespace DogParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            int otherAnimalFoodPrice = 4;
            double totalDogFoodPrice = numberOfDogs * dogFoodPrice;
            double totalOtherAnilamFoodPrice = otherAnimals * otherAnimalFoodPrice;

            double totalPrice = totalDogFoodPrice + totalOtherAnilamFoodPrice;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
