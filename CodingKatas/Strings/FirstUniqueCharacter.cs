namespace CodingKatas.Strings;
public class FirstUniqueCharacter
{
    public char GetFirstUniqueCharacter(string text)
    {
        if (string.IsNullOrEmpty(text)) return '\0';

        Dictionary<char, int> charCountPairs = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (!charCountPairs.ContainsKey(c))
            {
                charCountPairs[c] = 0;
            }
            charCountPairs[c]++;

        }

        foreach (char c  in text)
        {
            if (charCountPairs[c] == 1) return c;
        }
        return '\0';
    }
}
