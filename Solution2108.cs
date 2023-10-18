public class Solution2108 {

    public string Reverse(string s)
    {
        var chArray = s.ToCharArray();
        Array.Reverse(chArray);
        return new string(chArray);

    }
    public string FirstPalindrome(string[] words) {
        
        var answer = "";

        foreach (var word in words)
        {
            if (word == Reverse(word))
            {
                return word;
            }
        }
        return answer;
    }
}