public class Solution1768 {
    public string MergeAlternately(string word1, string word2) {
        
        var answer = "";
        var a = word1.Length;
        var b = word2.Length;
        
        for (int i = 0; i < Math.Min(a, b); i++)
            { 
                answer += word1[i];
                answer += word2[i];
            }

        if (a > b)
        {
            answer += word1[b..a];
        }
        else
        {
            answer += word2[a..b];
        }
        return answer;
        }
    }