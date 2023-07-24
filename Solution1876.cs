public class Solution1876 {
    public int CountGoodSubstrings(string s) {

        var count = 0;
        var length = s.Length - 2;

        for (int i = 0; i < length; i++)
        {
            if (s[i] != s[i+1] && s[i] != s[i+2] && s[i+1] != s[i+2])
                {
                    count++;
                }

        }


        return count;

    }
}