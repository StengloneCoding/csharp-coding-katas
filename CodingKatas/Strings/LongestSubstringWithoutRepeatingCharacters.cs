namespace CodingKatas.Strings;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int GetLengthOfLongestSubstring(string input)
    {
        HashSet<char> window = [];
        int left = 0;
        int longestSubstring = 0;

        for (int right = 0; right < input.Length; right++)
        {
            while (window.Contains(input[right]))
            {
                window.Remove(input[left]);
                left++;
            }

            window.Add(input[right]);
            longestSubstring = Math.Max(longestSubstring, right - left + 1);
        }

        return longestSubstring;
    }
}