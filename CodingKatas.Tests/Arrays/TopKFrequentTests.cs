using CodingKatas.Arrays;

namespace CodingKatas.Tests.Arrays;
public class TopKFrequentTests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 4, 4, 4, 6, 6, 1 }, 2, new int[] { 4, 6 })]
    public void GetTopKFrequent_ReturnsArrayWithRequestedLength(int[] input, int k, int[] expected)
    {
        TopKFrequent topKFrequent = new();

        int[] result = topKFrequent.GetTopKFrequent(input, k);

        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }
}