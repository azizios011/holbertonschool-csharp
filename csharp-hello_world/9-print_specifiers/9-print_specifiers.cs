using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine($"Percent: {(percent * 100):F2}%");
        Console.WriteLine($"Currency: ${currency.ToString("N2", CultureInfo.InvariantCulture)}");
	}
}
