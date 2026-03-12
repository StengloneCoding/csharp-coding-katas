using CodingKatas.Strings;

namespace CodingKatas.Tests.Strings;

public class GroupAnagramsTests
{
    [Fact]
    public void GetGroupAnagrams_ReturnsCorrectGroups()
    {
        var input = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        var groupAnagrams = new GroupAnagrams();
        var result = groupAnagrams.GetGroupAnagrams(input);

        Assert.Equal(3, result.Count);
    }
}