public class Solution1657 {
    public bool CloseStrings(string word1, string word2) {

        if (word1.Length != word2.Length)
        {
            return false;
        }

        var word1Dict = new Dictionary <char, int> ();
        var word2Dict = new Dictionary <char, int> ();

        for (int i = 0; i < word1.Length; i++)
        {
            if (!word1Dict.ContainsKey(word1[i]))
            {
                word1Dict.Add(word1[i], 1);
            }
            else
            {
                word1Dict[word1[i]]++;
            }
        }

        for (int i = 0; i < word1.Length; i++)
        {
            if (!word2Dict.ContainsKey(word2[i]))
            {
                word2Dict.Add(word2[i], 1);
            }
            else
            {
                word2Dict[word2[i]]++;
            }
        }

        var word1values = new int [word1Dict.Count];
        word1Dict.Values.CopyTo(word1values, 0);
        var word2values = new int [word2Dict.Count];
        word2Dict.Values.CopyTo(word2values, 0);
        Array.Sort(word1values);
        Array.Sort(word2values);

        var word1Keys = new char [word1Dict.Count];
        word1Dict.Keys.CopyTo(word1Keys, 0);
        var word2Keys = new char [word2Dict.Count];
        word2Dict.Keys.CopyTo(word2Keys, 0);
        Array.Sort(word1Keys);
        Array.Sort(word2Keys);

        for (int i = 0; i < word1values.Length; i++)
        {
            if (word1values[i] != word2values[i] || word1Keys[i] != word2Keys[i])
            {
                return false;
            }    
        }
        return true;

    }
}
