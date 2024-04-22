public class Solution17 {
    public IList<string> LetterCombinations(string digits) {
        
        var ans = new List<string>();

        if(string.IsNullOrEmpty(digits)) return ans;

        var dict = new Dictionary<string,string>{
            { "2", "abc" },
            { "3", "def" },
            { "4", "ghi" },
            { "5", "jkl" },
            { "6", "mno" },
            { "7", "qprs" },
            { "8", "tuv" },
            { "9", "wxyz" }
        };

        void Backtracking(int index, string curr)
        {
            if(curr.Length == digits.Length)
            {
                ans.Add(curr);
                return;
            }

            string chars = dict[digits[index].ToString()];
            for(int i = 0; i < chars.Length; i++)
            {
                Backtracking(index+1, curr + chars[i]);
            }
        }

        Backtracking(0, string.Empty);

        return ans;
    }   
}
