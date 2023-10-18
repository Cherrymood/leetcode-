public class Solution2176 {
    public int CountPairs(int[] nums, int k) {
        
        int answer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && (i*j) % k == 0 )
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}