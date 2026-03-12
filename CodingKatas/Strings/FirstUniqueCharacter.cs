using System.Diagnostics.Metrics;

namespace CodingKatas.Strings;
public class FirstUniqueCharacter
{
    public char GetFirstUniqueCharacter(string text)
    {
        if (string.IsNullOrEmpty(text)) return '\0';

        Dictionary<char, int> charCountPairs = [];
        foreach (char c in text)
        {
            charCountPairs[c] = charCountPairs.GetValueOrDefault(c) + 1;

        }

        foreach (char c  in text)
        {
            if (charCountPairs[c] == 1) return c;
        }
        return '\0';
    }
}
