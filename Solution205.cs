public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        var dict1 = new Dictionary<char,char>();
        var dict2 = new Dictionary<char,char>();

        for(int i = 0; i < s.Length; i++)
        {
            if (dict1.ContainsKey(s[i]))
            {
                if(dict1[s[i]] != t[i]) return false;
                continue;
            }
            else if(dict2.ContainsKey(t[i]))
            {
                if(dict2[t[i]] != s[i]) return false;
                continue;
            }
            else
            {
                dict1[s[i]] = t[i];
                dict2[t[i]] = s[i];
            }
        }


        return true;

    }
}
