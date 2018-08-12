using System;
using Palindromes.Output;

namespace Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args.Length == 0 || args[0].Length == 0)
				{
					throw new ArgumentException("Please supply an input string");
				}

				var store = new PalindromeStore();
				var finder = new PalindromeFinder(store);

				var doStuff = new PalindromeService(finder, new ConsoleOutput());
				doStuff.Execute(args[0]);
			}
			catch(Exception exception)
			{
				Console.WriteLine(exception);
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
