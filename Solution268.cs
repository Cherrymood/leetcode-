public class Solution {
    public int MissingNumber(int[] nums) {
        
        Array.Sort(nums);
        var length = nums.Length;

        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i] - nums[i-1] != 1)
            {
                return nums[i - 1] + 1;
            }
        }

        if (nums[length-1] != length)
        {
            return length;
        }

        return 0;
    }
}
