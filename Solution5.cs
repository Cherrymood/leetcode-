public class Solution5 {
    public bool Is_Palindrome(char[] t, int i, int k)
    {
        int left = i;
        int right = k-1;

        while (left < right)
        {
            if (t[left] != t[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;

    }
    public string LongestPalindrome(string s) {

        var charArr = s.ToCharArray();

        for (int i = s.Length; i > 0; i--)
        {
            for (int k = 0; k <= s.Length - i; k++)
            {
                if (Is_Palindrome(charArr, k, k+i))
                {
                    return s.Substring(k, i);
                }
            }
        }
        
        return "";
    }
}