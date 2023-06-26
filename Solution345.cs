using System.Text;
public class Solution345 {
    public string ReverseVowels(string s) {
        
        var str1 = new StringBuilder();
        var stackVowels = new Stack<char>();

        foreach (var item in s)
        {
            if ("AEUIOaeuio".Contains(item))
            {
                stackVowels.Push(item);
            }
        }

        foreach (var letter in s)
        {
            if ("AEUIOaeuio".Contains(letter))
            {
                str1.Append(stackVowels.Pop());
            }
            else
            {
                str1.Append(letter);
            }
        }

        return str1.ToString();
        
    }
    
}