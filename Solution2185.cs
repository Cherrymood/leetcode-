public class Solution2185 {
    public int PrefixCount(string[] words, string pref) {
        
        int answer = 0;
        bool flag = false;

        for (int i = 0; i < words.Length; i++)
        {
            for (int k = 0; k < pref.Length; k++)
            {
                if (words[i][k] != pref[k])
                {
                    flag = true;
                    break;
                }

                if (flag == false)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}