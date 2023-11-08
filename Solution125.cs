public class Solution125 {
    public bool IsPalindrome(string s) {

        var result = "";

        foreach (var letter in s)
        {
            if (Char.IsLetter(letter))
            {
                result += letter;
            }
        }

        result.ToLower();

        for (int i = 0, k = s.Length-1; i < k; i++, k--)
        {
            if (s[i] != s[k])
            {
                return false;
            }
        }

        return true;
    }
}