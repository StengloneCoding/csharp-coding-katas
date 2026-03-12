namespace CodingKatas.Strings;
public class GroupAnagrams
{
    public IList<IList<string>> GetGroupAnagrams(string[] words)
    {
        Dictionary<string, List<string>> sortedStrings = [];
        foreach (var word in words)   
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string currentSortedWord = new(chars);
            if (!sortedStrings.ContainsKey(currentSortedWord))
            {
                sortedStrings.Add(currentSortedWord, []);
            }
                sortedStrings[currentSortedWord].Add(word);

        }
        return [.. sortedStrings.Values];
    }
}
