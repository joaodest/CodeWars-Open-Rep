
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine(validBraces("[(])"));

    }

    public static bool validBraces(String braces)
    {
        Dictionary<char, char> bracesPairs = new Dictionary<char, char>
        {
            {'{', '}' },
            {'[', ']' },
            {'(', ')' },
        };

        Stack<char> stack = new Stack<char>();

        foreach (char brace in braces)
        {
            if (bracesPairs.ContainsKey(brace))
            {
                stack.Push(brace);
            } else
            {
                if (stack.Count == 0 || brace != bracesPairs[stack.Pop()])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}


