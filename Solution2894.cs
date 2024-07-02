public class Solution {
    public int DifferenceOfSums(int n, int m) {
        
        var num1 = 0;
        var num2 = 0;

        for(int i = 1; i <= n; i++)
        {
            if(i % m == 0)
            {
                num1 += i;
            }
            if(i % m != 0)
            {
                num2 += i;
            }

        }

        return num2 - num1;
    }
}
