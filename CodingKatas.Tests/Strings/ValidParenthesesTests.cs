namespace CodingKatas.Strings;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void IsValid_ReturnsExpectedResult(string input, bool expected)
    {
        ValidParentheses validParantheses = new();

        bool result = validParantheses.IsValid(input);

        Assert.Equal(expected, result);
    }
}