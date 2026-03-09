using CodingKatas.Arrays;

namespace CodingKatas.Tests.Arrays;
public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, 0, 1)]
    public void GetTwoSumNumbers_ReturnsArrayWithIndexes(int[] input, int target, int expectedOne, int expectedTwo)
    {
        var twoSum = new TwoSum();

        int[] result = twoSum.GetTwoSumNumbers(input, target);

        Assert.Contains(expectedOne, result);
        Assert.Contains(expectedTwo, result);
    }
}