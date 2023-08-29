public class Solution1249 {
    public string MinRemoveToMakeValid(string s) {
        
        var stack = new Stack<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')' && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (s[i] == ')' && stack.Count == 0)
            {
                s = s.Remove(i, 1);
                --i;
            }
        }

        while (stack.Count > 0)
        {
            s = s.Remove(stack.Pop(), 1);
        }

        return s;
    }
}