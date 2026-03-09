using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;
public class PalindromeTests
{
    [Theory]
    [InlineData("", false)]
    [InlineData("Bastian", false)]
    [InlineData("Anna", true)]
    public void IsPalindrome_ReturnsBool(string input, bool expected)
    {
        var palindrome = new Palindrome();

        var result = palindrome.IsPalindrome(input);

        Assert.Equal(expected, result);
    }
}