using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;
public class PalindromeTests
{
    [Theory]
    [InlineData("", false)]
    [InlineData("Bastian", false)]
    [InlineData("Anna", true)]
    public void IsPalindrome_ReturnsTrueForPalindromesAndFalseOtherwise(string input, bool expected)
    {
        Palindrome palindrome = new();

        bool result = palindrome.IsPalindrome(input);

        Assert.Equal(expected, result);
    }
}