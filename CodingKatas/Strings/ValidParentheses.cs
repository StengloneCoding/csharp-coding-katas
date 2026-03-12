namespace CodingKatas.Strings;
public class ValidParentheses
{
    private static readonly Dictionary<char, char> ParenthesesPairs = new()
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

    public bool IsValid(string input)
    {
        Stack<char> stack = new();
        foreach (char c in input)
        {
            if (!ParenthesesPairs.ContainsKey(c))
            {
                stack.Push(c);
            }
           else
            {
                if (stack.Count == 0) return false;
                else if (stack.Peek() == ParenthesesPairs[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            
        }
        return stack.Count == 0;
    }
}
