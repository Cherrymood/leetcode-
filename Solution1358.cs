public class Solution1358 {
    public int NumberOfSubstrings(string s) {

        int count = 0;
        int countA = 0;
        int countB = 0;
        int countC = 0;
        int j = 0;


       for (int i = 0; i < s.Length; i++)
       {
            if (s[i] == 'a')
            {
                countA++;
            }
            else if (s[i] == 'b')
            {
                countB++;
            }
            else if (s[i] == 'c')
            {
                countC++;
            }

       while (countA > 0 && countB > 0 && countC > 0)
       {
            count += s.Length - i;

            if (s[j] == 'a')
            {
                countA--;
            }
            else if (s[j] == 'b')
            {
                countB--;
            }
            else if (s[j] == 'c')
            {
                countC--;
            }

            j++;
            if (j == s.Length)
            {
                return count;
            }

       }
       }

        return count;

    }
}