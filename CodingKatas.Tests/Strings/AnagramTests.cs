using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;
public class AnagramTests
{
    [Theory]
    [InlineData("rail safety", "fairy tales", true)]
    [InlineData("sorry", "not sorry", false)]
    [InlineData("abc", "ab", false)]
    [InlineData("listen", "listen", true)]
    [InlineData("", "", true)]
    public void IsAnagramm_ReturnsExpectedResult(string a, string b, bool expected)
    {
        Anagram anagram = new();
        bool result = anagram.IsAnagram(a, b);
        Assert.Equal(expected, result);
    }

}