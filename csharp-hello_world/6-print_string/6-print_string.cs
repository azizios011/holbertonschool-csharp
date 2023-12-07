﻿// a program that print a string stored in the variable str 3 times, followed by its first 9 characters.
using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine($"{str}{str}{str}");
        Console.WriteLine(str.Substring(0, Math.Min(9, str.Length)));
        }
}
