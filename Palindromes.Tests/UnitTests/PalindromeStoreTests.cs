using System.Linq;
using Palindromes.Model;
using Shouldly;
using Xunit;

namespace Palindromes.Tests.UnitTests
{
    public class PalindromeStoreTests
    {
	    private readonly PalindromeStore _store;

	    public PalindromeStoreTests()
	    {
		    _store = new PalindromeStore();
	    }

		[Fact]
	    public void ShouldReturnNoPalindromesIfNoneAdded()
		{
			var palindromes = _store.Palindromes();

			palindromes.ShouldNotBeNull();
			palindromes.ShouldBeEmpty();
		}

	    [Fact]
	    public void ShouldReturnSortedListOfPalindromes()
	    {
		    _store.AddWord(new Palindrome(1, "abba"));
		    _store.AddWord(new Palindrome(7, "abcba"));

		    var palindromes = _store.Palindromes().ToList();

		    palindromes.Count.ShouldBe(2);
		    palindromes[0].Word.ShouldBe("abcba");
		    palindromes[1].Word.ShouldBe("abba");
	    }

	    [Fact]
	    public void ShouldOnlyReturn3Palindromes()
	    {
		    _store.AddWord(new Palindrome(1, "abba"));
		    _store.AddWord(new Palindrome(7, "abcba"));
		    _store.AddWord(new Palindrome(14, "abccba"));
		    _store.AddWord(new Palindrome(20, "axa"));

		    var palindromes = _store.Palindromes().ToList();

		    palindromes.Count.ShouldBe(3);
		    palindromes[0].Word.ShouldBe("abccba");
		    palindromes[1].Word.ShouldBe("abcba");
		    palindromes[2].Word.ShouldBe("abba");
	    }

	}
}
