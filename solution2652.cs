public class Solution2652 {
    public int SumOfMultiples(int n) 
    {
        var answer = 0;

        for (int i = 3; i <= n; i++ )
            {
                if ( i % 3 == 0)
                {
                    answer += i;
                }
                else if ( i % 5 == 0)
                {
                     answer += i;
                }
                else if ( i % 7 == 0)
                {
                    answer += i;
                }
        }
        return answer;
    }
}