﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Podaj 3 liczby: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a < b + c && b < a + c && c < b + a)
                {


                    Console.WriteLine("Zle liczbe do zbudowania trojkata, try again");
                }
                else
                {
                    Console.WriteLine("Taki trójkąt istenieje");
                }
                Console.ReadLine();
            }




        }
    }
}
