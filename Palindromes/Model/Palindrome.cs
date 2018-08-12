namespace Palindromes.Model
{
	public class Palindrome
	{
		public int Index { get; }

		public string Word { get; }

		public Palindrome(int index, string word)
		{
			Index = index;
			Word = word;
			Length = word.Length;
		}

		public int Length { get; }

		public override string ToString()
		{
			return $"Text: {Word}, Index: {Index}, Length: {Length}";
		}
	}
}