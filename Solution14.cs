public class Solution14 {

    public string LongestCommonPrefix(string[] strs) {
        
        string answer = "";

        Array.Sort(strs);

        for (int i = 0; i < strs[0].Length; i++)
        {
            if (strs[0][i] == strs[^1][i])
            {
                answer += strs[0][i];
            }
            else
            {
                return answer;
            }
        }

        return answer;
        
    }
}