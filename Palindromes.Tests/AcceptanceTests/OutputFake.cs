using System.Collections.Generic;
using Palindromes.Output;

namespace Palindromes.Tests.AcceptanceTests
{
	public class OutputFake : IOutput
	{
		public List<string> Output = new List<string>();
		public void WriteLine(string text)
		{
			Output.Add(text);
		}
	}
}