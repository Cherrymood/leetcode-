public class Solution804 {
    public int UniqueMorseRepresentations(string[] words) {
        
        if (words.Length == 1)
        {
            return 1;
        }
        
        var alphaKey = "abcdefghijklmnopqrstuvwxyz";
        var morseValue = new string[]{ ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

        var dictAlpha = new Dictionary<char, string>();

        for (int i = 0; i < morseValue.Length; i++)
        {
            dictAlpha[alphaKey[i]] = morseValue[i];
        }

        var dictWords = new Dictionary<string,int>();

        foreach (var w in words)
        {
            var word = "";

            foreach (var letter in w)
            {
                word += dictAlpha[letter];
            }

            if (!dictWords.ContainsKey(word))
            {
                dictWords[word] = 1;
            }
            else
            {
                dictWords[word]++;
            }
        }

        var answer = dictWords.Values.Max();

        return answer;
            
        
    }
}