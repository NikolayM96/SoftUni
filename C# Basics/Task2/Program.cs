using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
   

            double Width = double.Parse(Console.ReadLine());
            double Lenght = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double AstrHeight = double.Parse(Console.ReadLine());

            double RocketSize = Width * Lenght * Height;
            double RoomSize = 2 * 2 * (AstrHeight + 0.40);
            double Astrounats = Math.Floor(RocketSize / RoomSize);

            if (Astrounats < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (Astrounats >= 3 && Astrounats <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Astrounats} astronauts.");
            }
            else if (Astrounats > 10)
            {
                Console.WriteLine($"The spacecraft is too big.");
            }

        }
    }
}
