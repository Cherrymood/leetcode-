public class Solution2390 {
    public string RemoveStars(string s) {
        
        var stackS = new Stack<char>();
        var alphabeth = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        

        foreach (char ch in s)
        {
            if (alphabeth.Contains(ch))
            {
                stackS.Push(ch);
            }
            else if (ch == '*')
            {
                stackS.Pop();
            }
        }

        var answer = new char[stackS.Count];
        var index = stackS.Count - 1;

        while ( index >= 0)
        {
            answer[index] = stackS.Pop();
            index --;
        }

        return new string(answer);
    }
}