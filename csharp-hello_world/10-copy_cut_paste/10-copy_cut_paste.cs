// See https://aka.ms/new-console-template for more information
using System;
class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		string word_first_3 = word.Substring(0, Math.Min(3, word.Length));
		string word_last_2 = word.Substring(Math.Max(0, word.Length - 2));
		string middle_word = word.Substring(1, word.Length - 2);
		Console.WriteLine("First 3 letters: {0}", word_first_3);
		Console.WriteLine("Last 2 letters: {0}", word_last_2);
		Console.WriteLine("Middle word: {0}", middle_word);
        }
}
