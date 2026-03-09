namespace CodingKatas.Strings;
public class Anagram
{
    public bool IsAnagram(string a, string b)
    {
        a = a.ToLower();
        b = b.ToLower();
        var arrA = a.ToCharArray();
        var arrB = b.ToCharArray();
        Array.Sort(arrA);
        Array.Sort(arrB);
        return new string(arrA) == new string(arrB);
    }
}
