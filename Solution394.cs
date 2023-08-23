public class Solution402 {
    public string RemoveKdigits(string num, int k) {
        
        if (k == num.Length)
        {
            return "0";
        }

        var stack = new Stack<char>();

        foreach (var ch in num)
        {
            while (stack.Count > 0 && stack.Peek() > ch && k > 0)
            {
                stack.Pop();
                k--;
            }
            stack.Push(ch);
        }

        if (k > 0)
        {
            while (k > 0)
        {
            stack.Pop();
            k--;
        }
        }
        
        var str = new char[stack.Count];
        for (int i = str.Length -1; i >= 0; i--)
        {
            str[i] = stack.Pop();
        }
        var answer = "";

        foreach (var v in str)
        {
            answer += v;
        }

        answer.TrimStart("0");
        if (answer.Length < 0)
        { 
            return "0";
        }
        
        return answer;
    }
}