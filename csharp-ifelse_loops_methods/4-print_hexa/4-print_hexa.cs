// a program that prints all numbers from 0 to 98 in decimal and in hexadecimal.
using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                string hex = i.ToString("x");
                Console.Write($"{i} = 0x{hex}\n");
            }
        }
    }
}
