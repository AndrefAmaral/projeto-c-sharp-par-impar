﻿using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else 
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
