public class Solution3 {
    public int LengthOfLongestSubstring(string s) {
        
        var charSet = new HashSet<char>();
        int left = 0;
        int right = 0;
        int count = 0;

        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                count = Math.Max(count, charSet.Count);
            }

            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }

        return count;

    }
}
