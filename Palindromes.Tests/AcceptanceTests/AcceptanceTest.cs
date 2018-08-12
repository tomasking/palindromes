using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace Palindromes.Tests.AcceptanceTests
{
    public class AcceptanceTest
    {
	    private readonly PalindromeService _palindromeService;
	    private readonly OutputFake _outputFake;

	    public AcceptanceTest()
	    {
		    var store = new PalindromeStore();
		    var finder = new PalindromeFinder(store);
		    _outputFake = new OutputFake();
		    _palindromeService = new PalindromeService(finder, _outputFake);
		}

		[Fact]
        public void ShouldOutputTop3PalindromesFromInput()
        {
	        _palindromeService.Execute("sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop");
			
	        List<string> output = _outputFake.Output;

	        output.Count.ShouldBe(3);
	        output[0].ShouldBe("Text: hijkllkjih, Index: 23, Length: 10");
	        output[1].ShouldBe("Text: defggfed, Index: 13, Length: 8");
	        output[2].ShouldBe("Text: abccba, Index: 5, Length: 6");
        }
    }
}
