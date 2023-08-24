public class Solution921 {
    public int MinAddToMakeValid(string s) {
        
        if (s.Length == 0)
        {
            return 0;
        }

        var stack = new Stack<char>();
        var answer = 0;

        foreach (var ch in s)
        {
            if (ch == ')' && stack.Count == 0)
            {
                answer ++;
            }
            else if (ch == ')' && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (ch == '(')
            {
                stack.Push(ch);
            }
        }

        if (stack.Count > 0)
        {
            answer += stack.Count;
        }
        
        return answer;

    }
}