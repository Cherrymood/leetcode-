public class Solution2185 {
    public int PrefixCount(string[] words, string pref) {
        
        int answer = 0;

        foreach (var word in words)
        {
            bool flag = false;

            for (int k = 0; k < pref.Length; k++)
            {

                if(pref.Length > word.Length)
                {
                    continue;
                }

                if (word[k] != pref[k])
                {
                    break;
                }

                flag = k == pref.Length-1;
            }

            if (flag)
               
            {
                answer++;
            }
        }
        return answer;
    }
}