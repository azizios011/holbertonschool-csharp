// a program that print the float stored in the variable number with a precision of 2 digits.
using System;

class Program
{
	static void Main(string[] args)
        {
		float number = 3.14159f;
        // Display float with two decimal places
		Console.WriteLine($"Float: {number:F2}");
        }
}
