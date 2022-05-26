using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int FoodBought = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int KiloToGrams = FoodBought * 1000;
            int TotalGrams = 0;

            while (command != "Adopted")
            {
                int Grams = int.Parse(command);
                TotalGrams += Grams;

                command = Console.ReadLine();
            }

            int difference = KiloToGrams - TotalGrams;

            if (difference < 0)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Food is not enough. You need {difference} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {difference} grams.");
            }
        }
    }
}
