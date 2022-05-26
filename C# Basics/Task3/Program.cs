using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сладкиш - текст - "Cake", "Souffle" или "Baklava"
            //2.Брой на поръчаните сладкиши - цяло число в интервала[1 … 10000]
            //3.Ден от месец декември преди Коледа - цяло число в интервала[1 … 24]

            string Sweet = Console.ReadLine();
            int SweetsOrdered = int.Parse(Console.ReadLine());
            int DayOfMonth = int.Parse(Console.ReadLine());

            double Price = 0;

            if (Sweet == "Cake")
            {
                if (DayOfMonth <= 15)
                {
                    Price = 24.00;
                }
                else
                {
                    Price = 28.70;
                }
            }
            else if (Sweet == "Souffle")
            {
                if (DayOfMonth <= 15)
                {
                    Price = 6.66;
                }
                else
                {
                    Price = 9.80; 
                }
            }
            else if (Sweet == "Baklava")
            {
                if (DayOfMonth <= 15)
                {
                    Price = 12.60;
                }
                else
                {
                    Price = 16.98;
                }
            }
            double TotalPrice = SweetsOrdered * Price;

            if (DayOfMonth <= 22 && TotalPrice >= 100 && TotalPrice <= 200)
            {
                TotalPrice -= TotalPrice * 0.15;
            }
            else if (DayOfMonth <= 22 && TotalPrice > 200)
            {
                TotalPrice -= TotalPrice * 0.25;
            }

            if (DayOfMonth <= 15)
            {
                TotalPrice -= TotalPrice * 0.10;
            }

            Console.WriteLine($"{TotalPrice:f2}");
        }
    }
}
