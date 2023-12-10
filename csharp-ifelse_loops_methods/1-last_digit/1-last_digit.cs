using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int num = number % 10;
        if (num == 0)
        {
            Console.WriteLine($"The last digit of {number} is {num} and is 0");
        }
        else if (num > 5)
        {
            Console.WriteLine($"The last digit of {number} is {num} and is greater than 5");
        }
        else
        {
            Console.WriteLine($"The last digit of {number} is {num} and is less than 6 and not 0");
        }
    }
}
