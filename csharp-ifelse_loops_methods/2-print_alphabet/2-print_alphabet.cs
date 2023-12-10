// a program that prints the alphabet, in lowercase, not followed by a new line.
using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 97;
        while (i <= 122)
        {
            Console.Write((char)i);
            i++;
        }
    }
}