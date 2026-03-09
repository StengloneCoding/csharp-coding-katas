namespace CodingKatas.Strings;

public class FirstUniqueCharacterTests
{
    [Theory]
    [InlineData("Bastian", 'B')]
    [InlineData("Anna", 'A')]
    [InlineData("anna", '\0')]
    [InlineData("testdtest", 'd')]
    public void GetFirstUniqueCharacter_ReturnsExpectedCharacter(string input, char expected)
    {
        var firstUniqueCharacter = new FirstUniqueCharacter();

        char result = firstUniqueCharacter.GetFirstUniqueCharacter(input);

        Assert.Equal(result, expected);
    }
}