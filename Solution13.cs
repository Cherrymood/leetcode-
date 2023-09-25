public class Solution13 {
    public int RomanToInt(string s) {
        
        int answer = 0;
        var dict = new Dictionary<char, int> {
            {'I' , 1}, {'V' , 5}, {'X' , 10}, {'L' , 50}, {'C' , 100}, {'D' , 500}, {'M' , 1000}};

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && dict[s[i]] < dict[s[i+1]])
            {
                answer -=  dict[s[i]];
            }
            else
            {
                answer += dict[s[i]];
            }
        }


        return answer;

    }
}