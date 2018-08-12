using System.Linq;
using Shouldly;
using Xunit;

namespace Palindromes.Tests.UnitTests
{
    public class PalindromeFinderTests
    {
	    private readonly PalindromeFinder _palindromeFinder;

	    public PalindromeFinderTests()
	    {
		    _palindromeFinder = new PalindromeFinder(new PalindromeStore());
	    }

	    [Fact]
	    public void ShouldReturnEvenNumberPalindromeFromInput()
	    {
		    string input = "qwertABBAdkljdlkj";

		    var results = _palindromeFinder.Find(input).ToList();

		    results.Count.ShouldBe(1);
		    results[0].Index.ShouldBe(5);
		    results[0].Word.ShouldBe("ABBA");
		    results[0].Length.ShouldBe(4);
	    }

	    [Fact]
	    public void ShouldReturnOddNumberPalindromeFromInput()
	    {
		    string input = "qwertABAdkljdlkj";

		    var results = _palindromeFinder.Find(input).ToList();

		    results.Count.ShouldBe(1);
		    results[0].Index.ShouldBe(5);
		    results[0].Word.ShouldBe("ABA");
		    results[0].Length.ShouldBe(3);
	    }
	}
}
