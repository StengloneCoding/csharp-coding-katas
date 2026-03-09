using CodingKatas.Basics;

namespace CodingKatas.Tests.Basics;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void GetFizzBuzz_ReturnsExpectedValue(int input, string expected)
    {
        var fizzbuzz = new FizzBuzz();

        var result = fizzbuzz.GetFizzBuzzNumber(input);

        Assert.Equal(expected, result);
    }
}