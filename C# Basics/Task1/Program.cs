using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int BoxesPaint = int.Parse(Console.ReadLine());
            int Rolls = int.Parse(Console.ReadLine());
            double GlovesPrice = double.Parse(Console.ReadLine());
            double BrushPrice = double.Parse(Console.ReadLine());

            double Gloves = Math.Ceiling(Rolls * 0.35);
            double Brushes = Math.Floor(BoxesPaint * 0.48);
            double PaintPrice = BoxesPaint * 21.50;
            double RollsPrice = Rolls * 5.20;
            double TotalGlovesPrice = Gloves * GlovesPrice;
            double TotalBrushesPrice = Brushes * BrushPrice;

            double TotalAmount = PaintPrice + RollsPrice + TotalBrushesPrice + TotalGlovesPrice;
            double Delivery = TotalAmount / 15;

            Console.WriteLine($"This delivery will cost {Delivery:f2} lv.");
            
        }
    }
}
