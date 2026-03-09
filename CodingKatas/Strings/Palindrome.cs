namespace CodingKatas.Strings;
public class Palindrome
{
    public bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text)) return false;
        
        string reversedText = new string(text.Reverse().ToArray());

        return text.Equals(reversedText, StringComparison.OrdinalIgnoreCase);

    }
}
