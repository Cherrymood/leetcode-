public class Solution1408 {
    public IList<string> StringMatching(string[] words) {
        var hs = new HashSet<string>();

        for(int i = 0; i < words.Length; i++)
        {
            for(int k = i+1; k < words.Length; k++)
            {
                if(words[i].Contains(words[k]))
                {
                    hs.Add(words[k]);
                }
                else if(words[k].Contains(words[i]))
                {
                    hs.Add(words[i]);
                }
            }
        }

        var ans = new List<string>();

        foreach(var item in hs)
        {
            ans.Add(item);
        }

        return ans;
    }
}
