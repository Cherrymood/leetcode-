public class Solution791 {
    public string CustomSortString(string order, string s) {

        var answer = "";

        foreach (char ch in order)
        {
            if (s.Contains(ch))
            {
                answer += ch;
            }
        }
        foreach (char letter in s)
        {
            if (!answer.Contains(letter))
            {
                answer += letter;
            }
        }
        return answer;
    }
}