public class Solution2269 {
    public int DivisorSubstrings(int num, int k) {
        
        var numString = num.ToString();
        var length = numString.Length - k+1;
        var counter = 0;

        for (int i = 0, j = i + k; i < length; i++)
        {
            var window = numString.Substring(i, j);
        
            var divisor = Int32.Parse(window);

            if (divisor == 0)
            {
                continue;
            }

            if (num % divisor == 0)
            {
                counter ++;
            }

        }
        return counter;
    }
}