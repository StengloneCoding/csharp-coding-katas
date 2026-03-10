namespace CodingKatas.Strings;

public class FirstUniqueCharacterTests
{
    [Theory]
    [InlineData("Bastian", 'B')]
    [InlineData("Anna", 'A')]
    [InlineData("anna", '\0')]
    [InlineData("testdtest", 'd')]
    [InlineData("a", 'a')]
    [InlineData("aabbcd", 'c')]
    [InlineData("aabbcc", '\0')]
    [InlineData("", '\0')]
    public void GetFirstUniqueCharacter_ReturnsExpectedCharacter(string input, char expected)
    {
        var firstUniqueCharacter = new FirstUniqueCharacter();

        char result = firstUniqueCharacter.GetFirstUniqueCharacter(input);

        Assert.Equal(expected, result);
    }
}