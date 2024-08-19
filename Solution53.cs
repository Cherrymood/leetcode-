public class Solution53 {
    public int MaxSubArray(int[] nums) {
        
        var sum = 0;
        var maxSum = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(nums[i] > sum)
            {
                sum = nums[i];
            }
            if(sum > maxSum)
            {
                maxSum = sum;
            }
        }

     
        return maxSum;
    }
}
