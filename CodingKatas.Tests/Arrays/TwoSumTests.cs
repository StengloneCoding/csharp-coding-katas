using CodingKatas.Arrays;

namespace CodingKatas.Tests.Arrays;
public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, 0, 1)]
    [InlineData(new int[] { 0, 4, 10, 5 }, 15, 2, 3)]
    [InlineData(new int[] { -3, 4, 3, 90 }, 0, 0, 2)]
    [InlineData(new int[] { 0, 4, 3, 0 }, 0, 0, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6, 0, 4)]
    public void GetTwoSumNumbers_ReturnsIndexesOfNumbersThatAddUpToTarget(int[] input, int target, int expectedOne, int expectedTwo)
    {
        TwoSum twoSum = new();

        int[] result = twoSum.GetTwoSumNumbers(input, target);

        Assert.Contains(expectedOne, result);
        Assert.Contains(expectedTwo, result);
    }
}