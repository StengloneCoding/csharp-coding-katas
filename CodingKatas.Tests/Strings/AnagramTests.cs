using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;
public class AnagramTests
{
    [Theory]
    [InlineData("rail safety", "fairy tales", true)]
    [InlineData("sorry", "not sorry", false)]
    public void IsAnagramm_ReturnsBool(string a, string b, bool expected)
    {
        Anagram anagramm = new Anagram();
        bool result = anagramm.IsAnagram(a, b);
        Assert.Equal(result, expected);
    }

}