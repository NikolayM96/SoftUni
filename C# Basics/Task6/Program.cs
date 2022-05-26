using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());

            for (int i = 1; i <= location ; i++)
            {
                double AverageGold = double.Parse(Console.ReadLine());
                int DaysMining = int.Parse(Console.ReadLine());
                double TotalGold = 0;
                for (int n = 1; n <= DaysMining; n++)
                {
                    double GoldMined = double.Parse(Console.ReadLine());
                    TotalGold += GoldMined; 
                }

                double AverageGoldPerDay = TotalGold / DaysMining;
                if (AverageGoldPerDay >= AverageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {AverageGoldPerDay:f2}.");
                }
                else
                {
                    double difference = AverageGold - AverageGoldPerDay;
                    Console.WriteLine($"You need {difference:f2} gold.");
                }
            }
        }
    }
}
