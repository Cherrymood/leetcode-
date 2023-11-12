public class Solution9 {
    public bool IsPalindrome(int x) {
        
        if (x < 0)
        {
            return false;
        }

        int a = 0;
        int b = x;

        while (b > 0)
        {
            a = a*10 + b % 10;
            b /= 10;
        }

        return a == x;
        
    }
}