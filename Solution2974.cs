public class Solution2974 {

    public int[] NumberGame(int[] nums) {
        
        if(nums.Length == 1) return nums;
        Array.Sort(nums);

        for(int i = 0; i <= nums.Length - 2; i+=2)
        {
            (nums[i], nums[i+1]) = (nums[i+1], nums[i]);
        }

        return nums;
    }
}
