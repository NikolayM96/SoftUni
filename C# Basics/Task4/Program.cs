﻿using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i != S)
                {
                    
               
                   Console.Write($"{i} ");
                    
                }
                else if (i % 2 == 0 && i % 3 == 0 && i == S)
                {
                    return;
                }
            }
        }
    }
}