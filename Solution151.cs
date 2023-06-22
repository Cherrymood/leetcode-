public class Solution151 {
    public string ReverseWords(string s) {
        
        var listOfS = s.Split().Reverse();
        var answer = "";
        
        foreach (var item in listOfS)
        {
            if (item.Length != 0)
            {
                answer += item + " ";
            }

        }
        return answer.Trim();

    }
}