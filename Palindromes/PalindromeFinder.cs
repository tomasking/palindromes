using System.Collections.Generic;
using Palindromes.Model;

namespace Palindromes
{
    public class PalindromeFinder
    {
	    private readonly PalindromeStore _store;

	    public PalindromeFinder(PalindromeStore store)
	    {
		    _store = store;
	    }

	    public IEnumerable<Palindrome> Find(string input)
	    {
			for (int index = 0; index < input.Length - 1; index++)
		    {
			    if (input[index] == input[index + 1])
			    {
				    _store.AddWord(GetPalindrome(index, index + 1, input));
			    }
			    else if (index + 2 < input.Length && input[index] == input[index + 2])
			    {
				    _store.AddWord(GetPalindrome(index, index + 2, input));
			    }
		    }

		    return _store.Palindromes();
		}

	    private static Palindrome GetPalindrome(int leftIndex, int rightIndex, string input)
	    {
		    while (leftIndex - 1 >= 0 && rightIndex + 1 < input.Length && input[leftIndex - 1] == input[rightIndex + 1])
		    {
			    leftIndex--;
			    rightIndex++;
		    }

		    var word = input.Substring(leftIndex, rightIndex - leftIndex + 1);

		    return new Palindrome(leftIndex, word);
	    }
	}
}
