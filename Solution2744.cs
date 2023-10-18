public class Solution2744 {

    public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    public int MaximumNumberOfStringPairs(string[] words) {
        
        var answer = 0;
        
        for (int i = 0; i < words.Length; i++)
        {
            for (int k = i+1; k < words.Length; k++ )
            {
                if (words[i] == Reverse(words[k]))
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}