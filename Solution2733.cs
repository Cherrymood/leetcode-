public class Solution2733 {
    public int FindNonMinOrMax(int[] nums) {
        
        if (nums.Length <= 2)
        {
            return -1;
        }

        Array.Sort(nums);

        return nums[1];
    }
}