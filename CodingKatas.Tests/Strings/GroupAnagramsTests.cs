using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;

public class GroupAnagramsTests
{
    [Theory]
    [InlineData(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }, 3)]
    [InlineData(new[] { "abc", "bca", "cab" }, 1)]
    [InlineData(new[] { "abc", "def", "ghi" }, 3)]
    [InlineData(new[] { "a" }, 1)]
    [InlineData(new string[] { }, 0)]
    public void GetGroupAnagrams_ReturnsExpectedNumberOfGroups(string[] input, int expectedGroupCount)
    {
        var groupAnagrams = new GroupAnagrams();

        var result = groupAnagrams.GetGroupAnagrams(input);

        Assert.Equal(expectedGroupCount, result.Count);
    }
}