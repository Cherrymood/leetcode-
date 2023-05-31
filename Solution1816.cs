public class Solution1816 {
    public string TruncateSentence(string s, int k) {
        
        var splitstring = s.Split(" ");

        var res = "";

            for (int i = 0; i < k; i++)
            {
                res += splitstring[i] + " ";
            }
            return res.Trim();

    }
}