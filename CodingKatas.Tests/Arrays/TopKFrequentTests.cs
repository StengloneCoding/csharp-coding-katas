using CodingKatas.Arrays;

namespace CodingKatas.Tests.Arrays;
public class TopKFrequentTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 3 }, 1)]
    [InlineData(new int[] { 1, 1, 2, 2, 3 }, 2)]
    public void GetTopKFrequent_ReturnsCorrectLength(int[] input, int k)
    {
        TopKFrequent topKFrequent = new();

        int[] result = topKFrequent.GetTopKFrequent(input, k);

        Assert.Equal(k, result.Length);
    }
}