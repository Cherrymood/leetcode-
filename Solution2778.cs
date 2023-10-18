public class Solution2778 {
    public int SumOfSquares(int[] nums) {
        
        int answer = 0;

        for (int i = 1; i <= nums.Length; i++)
        {
            if (nums.Length % i == 0)
            {
                answer += (nums[i - 1] * nums[i - 1]);
            }
        }

        return answer;
    }
}