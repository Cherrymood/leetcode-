public class Solution1455 {
    public int IsPrefixOfWord(string sentence, string searchWord) {

        var arr = sentence.Split(" ");
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i].Contains(searchWord) && arr[i].Substring(0, searchWord.Length) == searchWord)
            {
                return i+1;
            }
        }
        return -1;
    }
}
