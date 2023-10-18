public class Solution1827 {
    public int MinOperations(int[] nums) {
        
        if (nums.Length == 1)
        {
            return 0;
        }
        
        
        int answer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int k = i+1; k < nums.Length; k++)
            {
                if (nums[i] >= nums[k])
                {
                    answer += 1 + (nums[i] - nums[k]);
                    nums[k] = nums[i] + 1;
                }
            }
        }

        return answer;
    }
}