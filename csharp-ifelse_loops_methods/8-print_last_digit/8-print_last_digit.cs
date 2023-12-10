// a method that prints the last digit of a number.
using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        Console.Write(lastDigit);
        return lastDigit;
    }
}
