using Palindromes.Output;

namespace Palindromes
{
	public class PalindromeService
	{
		private readonly PalindromeFinder _palindromeFinder;
		private readonly IOutput _output;

		public PalindromeService(PalindromeFinder palindromeFinder, IOutput output)
		{
			_palindromeFinder = palindromeFinder;
			_output = output;
		}

		public void Execute(string input)
		{
			var pallindromes = _palindromeFinder.Find(input);
			
			foreach (var palindrome in pallindromes)
			{
				_output.WriteLine(palindrome.ToString());
			}
		}
	}
}