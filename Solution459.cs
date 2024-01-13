public class Solution459 {
    public bool RepeatedSubstringPattern(string s) {
        var n = s.Length;
        for(int i = 1; i <= n/2; i++)
        {
            if(n % i == 0)
            {
                var subs = s.Substring(0, i);
                var builder = new StringBuilder();
                for(int j = 0; j < n/i; j++)
                {
                    builder.Append(subs);
                }
                if(builder.ToString() == s) return true;
            }
        }
        return false;
    }
}