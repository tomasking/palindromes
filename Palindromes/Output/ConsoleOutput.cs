using System;

namespace Palindromes.Output
{
	public class ConsoleOutput : IOutput
	{
		public void WriteLine(string text)
		{
			Console.WriteLine(text);
		}
	}
}