﻿//  a program that prints the numbers from 1 to 100 separated by a space.
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }

            if (i < 100)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
