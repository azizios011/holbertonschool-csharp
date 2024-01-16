// a function that divides 2 integers and prints the result.
using System;

class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
        }

        catch (DivideByZeroException)
        {
           Console.WriteLine($"Cannot divide by zero");
        }

        finally
        {
            Console.WriteLine($"{a} / {b} = {(b != 0 ? a / b : 0)}");
        }
    }
}
