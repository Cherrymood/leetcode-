public class Solution424 {
    public int CharacterReplacement(string s, int k) {
        
        var dict = new Dictionary<char, int>();
        var res = 0;
        var maxF = 0;

        for(int l = 0, r = 0; r < s.Length; r++){
            if(!dict.ContainsKey(s[r]))
            {
                dict[s[r]] = 1;
            }
            else 
            {
                dict[s[r]]++;
            }

            maxF = Math.Max(maxF, dict[s[r]]);
            while((r-l + 1) - maxF > k)
            {
                dict[s[l++]]--;
            }

            res = Math.Max(res, r-l +1);
        }

        return res;
    }
}
