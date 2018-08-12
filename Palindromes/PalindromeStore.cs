using System.Collections.Generic;
using System.Linq;
using Palindromes.Model;

namespace Palindromes
{
	/// <summary>
	/// This is a very basic in-efficient implementation. If there were a million palindromes added I would
	/// be storing all million when in actual fact I only need to store 3
	///
	/// It also doesn't work if there are multiple words with the same length, it will just chop to 3 
	/// </summary>
	public class PalindromeStore
	{
		private readonly List<Palindrome> _palindromes = new List<Palindrome>();
		
		public void AddWord(Palindrome palindrome)
		{
			_palindromes.Add(palindrome);
		}

		public IEnumerable<Palindrome> Palindromes()
		{
			return _palindromes.OrderByDescending(p => p.Length).Take(3);
		}
	}
}