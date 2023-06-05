public class Solution1684 {
    public int CountConsistentStrings(string allowed, string[] words) {
        
        int answer = words.Length;

        foreach (string word in words)
        {
            foreach (char ch in word)
            {
                if (!allowed.Contains(ch))
                {
                    answer--;
                    break;
                }
            }
        }
        return answer;
    }
}