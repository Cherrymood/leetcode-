public class Solution9 {
    public bool IsPalindrome(int x) {
        
        var str = x.ToString();

        for (int i = 0; i < str.Length/2; i++)
        {
            if (str[i] != str[str.Length -1 - i])
            {
                return false;
            }
        }

        return true;

    }
}