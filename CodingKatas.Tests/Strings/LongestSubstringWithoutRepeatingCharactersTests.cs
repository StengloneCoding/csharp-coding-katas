using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData("abcdef", 6)]
    public void GetLengthOfLongestSubstring_ReturnsLongestUniqueSubstringLength(string input, int expected)
    {
        LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new();

        var result = longestSubstringWithoutRepeatingCharacters.GetLengthOfLongestSubstring(input);

        Assert.Equal(expected, result);
    }
}