public class Solution413 {
    public int NumberOfArithmeticSlices(int[] nums) {
        
        var count = 2;
        var answer = 0;


        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i -1] == nums[i - 1] - nums[i -2])
            {
                count++;
            }
            else
            {
                answer += (count - 2) * (count - 1) / 2;
                count = 2;
            }
        }

        answer += (count - 2) * (count - 1) / 2;
        return answer;
    }
}