# Palindrome Finder

Program to take an input string and return the top 3 unique palindromes in the string.

## Usage

1) Make sure you have [.Net Core 2.1](https://www.microsoft.com/net/download/dotnet-core/2.1) installed
2) Navigate to the root palindromes directory
3) -> dotnet build
4) -> cd /Palindromes/bin/Debug/netcoreapp2.1 (or wherever it has built too)
5) -> dotnet Palindromes.dll "inputstring"


### Limitations

- Doesn't work with spaces yet, ie the following wouldn't be clasified a palindrome: "Was it a car or a cat I saw".
- Only works with the same case
- No logging, global catch all exceptions logs to output window
- If there are multiple words of the same length it will take the first 3 found in size order