public class Solution1456 {
    public int MaxVowels(string s, int k) {

       HashSet <char> vowels = new () {'a', 'e', 'i', 'o', 'u'};

       int count = s.Take(k).Count(c => vowels.Contains(c)), maxCount = count;

       for ( int i = k; i < s.Length; i++)
       {
            if (vowels.Contains(s[i]))
            {
                count ++;
            }
            if (vowels.Contains(s[i -k]))
            {
                count --;
            }
            maxCount=Math.Max(maxCount,count);
        }

        return maxCount;
        
    }
}